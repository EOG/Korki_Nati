// Core.NodeStore
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Korki9
{
    public sealed class NodeStore
    {
        private static NodeStore instance;

        private static object syncRoot = new object();

        private Dictionary<string, INode> dictNodeStore = new Dictionary<string, INode>();

        private HashSet<string> setVoucherIDs = new HashSet<string>();

        private Dictionary<string, HashSet<string>> dictNodeChildIDs = new Dictionary<string, HashSet<string>>();

        public long NodeStoreByteLength;

        private const string cstrCacheFile = "data.json";

        private System.Timers.Timer nodeRefreshTimer;

        public bool Running
        {
            get;
            private set;
        }

        public static NodeStore Instance
        {
            get
            {
                if (NodeStore.instance == null)
                {
                    lock (NodeStore.syncRoot)
                    {
                        if (NodeStore.instance == null)
                        {
                            NodeStore.instance = new NodeStore();
                        }
                    }
                }
                return NodeStore.instance;
            }
        }

        public NodeStore()
        {
            //string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string text = Path.Combine(folderPath, "data.json");
            //CoreApplication coreApplication = (CoreApplication)Application.Context;
            //if (File.Exists(text))
            //{
            //    try
            //    {
            //        FileInfo fileInfo = new FileInfo(text);
            //        this.NodeStoreByteLength = fileInfo.Length;
            //        byte[] data = File.ReadAllBytes(text);
            //        string setting = Settings.GetSetting(coreApplication, "arb");
            //        if (!string.IsNullOrEmpty(setting))
            //        {
            //            string s = Utilities.DecryptStringAES(setting, Utilities.arb_string);
            //            int num = -1;
            //            if (int.TryParse(s, out num))
            //            {
            //                PackageInfo packageInfo = ((CoreApplication)Application.Context).PackageManager.GetPackageInfo(((CoreApplication)Application.Context).PackageName, PackageInfoFlags.MetaData);
            //                if (packageInfo.VersionCode < num)
            //                {
            //                    this.DeleteAllNodes(true);
            //                    Settings.ClearAllSettings((CoreApplication)Application.Context);
            //                    Settings.SaveSetting(Application.Context, "DeviceGUID", coreApplication.RuntimeDeviceGUID);
            //                    Settings.SaveSetting(Application.Context, "AuthHeader", coreApplication.RuntimeAuthHeader);
            //                }
            //            }
            //        }
            //        string setting2 = Settings.GetSetting(coreApplication, "NSSC");
            //        if (!string.IsNullOrEmpty(setting2))
            //        {
            //            string text2 = File.ReadAllText(text);
            //            string setting3 = Settings.GetSetting(coreApplication, "ContentRoot");
            //            string b = Utilities.Security.GenerateMD5(text2 + "|" + setting3 + "|" + coreApplication.RuntimeDeviceGUID);
            //            if (setting2 == b)
            //            {
            //                IEnumerable<INode> enumeration = NodeFactory.FromJson(data);
            //                enumeration.ForEach(delegate (INode n)
            //                {
            //                    if (n.Type == "Node.Voucher")
            //                    {
            //                        this.setVoucherIDs.Add(n.ID);
            //                    }
            //                    if (!string.IsNullOrEmpty(n.ParentID))
            //                    {
            //                        if (!this.dictNodeChildIDs.ContainsKey(n.ParentID))
            //                        {
            //                            this.dictNodeChildIDs[n.ParentID] = new HashSet<string>();
            //                        }
            //                        this.dictNodeChildIDs[n.ParentID].Add(n.ID);
            //                    }
            //                    this.dictNodeStore[n.ID] = n;
            //                });
            //                Utilities.ConsoleLog("NodeStore loaded " + this.dictNodeStore.Count.ToString() + " items from storage.");
            //            }
            //            else
            //            {
            //                Settings.ClearAllSettings((CoreApplication)Application.Context);
            //                Settings.SaveSetting(Application.Context, "DeviceGUID", coreApplication.RuntimeDeviceGUID);
            //                Settings.SaveSetting(Application.Context, "AuthHeader", coreApplication.RuntimeAuthHeader);
            //                this.DeleteAllNodes(true);
            //            }
            //        }
            //        else
            //        {
            //            Settings.ClearAllSettings((CoreApplication)Application.Context);
            //            Settings.SaveSetting(Application.Context, "DeviceGUID", coreApplication.RuntimeDeviceGUID);
            //            Settings.SaveSetting(Application.Context, "AuthHeader", coreApplication.RuntimeAuthHeader);
            //            this.DeleteAllNodes(true);
            //        }
            //    }
            //    catch
            //    {
            //        this.dictNodeStore.Clear();
            //        Settings.ClearAllSettings((CoreApplication)Application.Context);
            //        Settings.SaveSetting(Application.Context, "DeviceGUID", coreApplication.RuntimeDeviceGUID);
            //        Settings.SaveSetting(Application.Context, "AuthHeader", coreApplication.RuntimeAuthHeader);
            //    }
            //}
            //else
            //{
            //    Utilities.ConsoleLog("NodeStore initialised empty store.");
            //}
        }

        public void Start(object Caller, Action<IEnumerable<INode>> OnCompletion, int millisecs)
        {
            CoreApplication app = (CoreApplication)Application.Context;
            this.nodeRefreshTimer = new System.Timers.Timer((double)millisecs);
            this.nodeRefreshTimer.AutoReset = true;
            this.nodeRefreshTimer.Elapsed += delegate
            {
                if (app.CurrentActivity.GetType() == typeof(ABS_Browser_Activity) || app.CurrentActivity.GetType() == typeof(CycleHireActivity))
                {
                    Base_ActionBarActivity base_ActionBarActivity = (Base_ActionBarActivity)app.CurrentActivity;
                    if (Utilities.DeviceIsConnected(base_ActionBarActivity) == Utilities.DeviceConnectionStatus.Connected)
                    {
                        INode nodeRoot = base_ActionBarActivity.nodeRoot;
                        IEnumerable<INode> listChildren = base_ActionBarActivity.listChildren;
                        Utilities.ConsoleLog("Timer HIT - current node name " + nodeRoot.Name + " " + nodeRoot.CacheExpires);
                        if (base_ActionBarActivity.activityIsPaused)
                        {
                            Utilities.ConsoleLog("Not updating - current activity is paused");
                            return;
                        }
                        if (base_ActionBarActivity.activityIsVoucher)
                        {
                            Utilities.ConsoleLog("Not updating - current activityIsVoucher true");
                            return;
                        }
                        if (base_ActionBarActivity.activityUpdatingDisabled)
                        {
                            Utilities.ConsoleLog("Not updating - current activityUpdatingDisabled true");
                            return;
                        }
                        if (nodeRoot.CacheExpires != DateTime.MinValue)
                        {
                            if (DateTime.UtcNow.CompareTo(nodeRoot.CacheExpires) == 1)
                            {
                                Utilities.ConsoleLog("node expired - refreshing: " + nodeRoot.Name + " " + nodeRoot.CacheExpires);
                                OnCompletion(this.RefreshNode(Caller, nodeRoot));
                                return;
                            }
                        }
                        else
                        {
                            Utilities.ConsoleLog("Not updating - node does not have a CacheExpires");
                        }
                        int num = (from child in listChildren
                                   where child.CacheExpires != DateTime.MinValue && DateTime.UtcNow.CompareTo(child.CacheExpires) == 1
                                   select child).Count();
                        if (num > 1)
                        {
                            OnCompletion(this.RefreshNode(Caller, nodeRoot));
                            return;
                        }
                        if (num == 1)
                        {
                            INode node = (from singleChild in listChildren
                                          where singleChild.CacheExpires != DateTime.MinValue && DateTime.UtcNow.CompareTo(singleChild.CacheExpires) == 1
                                          select singleChild).FirstOrDefault();
                            OnCompletion(this.RefreshNode(Caller, node));
                            return;
                        }
                        if (nodeRoot is Node.Container.MapListingNavigator)
                        {
                            List<INode> listExpiredTabGroups = new List<INode>();
                            (from n in listChildren
                             where n is Node.Container.Tabs
                             select n).ForEach(delegate (INode tabNode)
                             {
                                 INode node2 = (from n in app.NodeStore.Descendants(tabNode.ID)
                                                where n is Node.Group && n.CacheExpires != DateTime.MinValue && DateTime.UtcNow.CompareTo(n.CacheExpires) == 1
                                                select n).FirstOrDefault();
                                 if (node2 != null)
                                 {
                                     listExpiredTabGroups.Add(node2);
                                 }
                             });
                            if (listExpiredTabGroups.Count > 0)
                            {
                                OnCompletion(this.RefreshNode(Caller, nodeRoot));
                                return;
                            }
                        }
                    }
                    else
                    {
                        Console.Write("not refreshing - device not connected");
                    }
                }
                else
                {
                    Console.Write("not refreshing - current activity is not a ActivityBrowserScrollView");
                }
                this.ExpireActivatedTicket(Caller);
                this.FlagCachedVoucherOpened(Caller);
                this.FlagSetTicketTimeout(Caller);
            };
            this.nodeRefreshTimer.Start();
        }

        private void UploadHitLog(object Caller)
        {
            CoreApplication app = (CoreApplication)Application.Context;
            if (app.LogItems.Count() > 20)
            {
                List<LogItem> itemsToUpload = app.LogItems.Take(20).ToList();
                NodeFactory.UploadHitLog(this, itemsToUpload, delegate
                {
                    itemsToUpload.ForEach(delegate (LogItem i)
                    {
                        app.LogItems.Remove(i);
                    });
                    Settings.SerializeLogItem(app.ApplicationContext, app.LogItems.ToList());
                });
            }
        }

        //public void ExpireActivatedTickets(CoreApplication app)
        //{
        //    try
        //    {
        //        if (app.ActivatedTickets.Count > 0)
        //        {
        //            Dictionary<string, Dictionary<string, string>> dictionary = app.ActivatedTickets.ToDictionary((KeyValuePair<string, Dictionary<string, string>> entry) => entry.Key, (KeyValuePair<string, Dictionary<string, string>> entry) => entry.Value);
        //            foreach (KeyValuePair<string, Dictionary<string, string>> item in dictionary)
        //            {
        //                NodeFactory.ActivateServerTicket(this, app.ActivatedTickets[item.Key], delegate (IEnumerable<INode> nodes)
        //                {
        //                    INode node = nodes.FirstOrDefault();
        //                    if (node.Name == "OK")
        //                    {
        //                        app.ActivatedTickets.Remove(item.Key);
        //                    }
        //                });
        //            }
        //            Settings.SerializeActivatedTickets(app.ApplicationContext, app.ActivatedTickets);
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        //private void ExpireActivatedTicket(object Caller)
        //{
        //    CoreApplication app = (CoreApplication)Application.Context;
        //    if (app.ActivatedTickets.Count > 0)
        //    {
        //        string firstKey = app.ActivatedTickets.Keys.First();
        //        Console.Write("ExpireActivatedTicket called");
        //        NodeFactory.ActivateServerTicket(this, app.ActivatedTickets[firstKey], delegate (IEnumerable<INode> nodes)
        //        {
        //            INode node = nodes.FirstOrDefault();
        //            if (node.Name == "OK")
        //            {
        //                app.ActivatedTickets.Remove(firstKey);
        //                Console.Write(" - successful");
        //            }
        //            else
        //            {
        //                Console.Write(" - failed");
        //            }
        //            Settings.SerializeActivatedTickets(app.ApplicationContext, app.ActivatedTickets);
        //        });
        //    }
        //}

        //private void FlagCachedVoucherOpened(object Caller)
        //{
        //    CoreApplication app = (CoreApplication)Application.Context;
        //    if (app.TicketOpenDTs.Count > 0)
        //    {
        //        string firstKey = app.TicketOpenDTs.Keys.First();
        //        Console.Write("UploadOpenTicketDT called");
        //        NodeFactory.FlagVoucherOpened(this, app.TicketOpenDTs[firstKey], delegate (IEnumerable<INode> nodes)
        //        {
        //            INode node = nodes.FirstOrDefault();
        //            if (node.Name == "OK")
        //            {
        //                app.TicketOpenDTs.Remove(firstKey);
        //                Console.Write(" - successful");
        //            }
        //            else
        //            {
        //                Console.Write(" - failed");
        //            }
        //            Settings.SerializeTicketOpenDTs(app.ApplicationContext, app.TicketOpenDTs);
        //        }, delegate
        //        {
        //            Console.Write(" - failed");
        //        });
        //    }
        //}

        //private void FlagSetTicketTimeout(object Caller)
        //{
        //    CoreApplication app = (CoreApplication)Application.Context;
        //    if (app.TicketTimeouts.Count > 0)
        //    {
        //        string firstKey = app.TicketTimeouts.Keys.First();
        //        Console.Write("FlagSetTicketTimeout called");
        //        NodeFactory.FlagSetTicketTimeout(this, app.TicketTimeouts[firstKey], delegate (IEnumerable<INode> nodes)
        //        {
        //            INode node = nodes.FirstOrDefault();
        //            if (node.Name == "OK")
        //            {
        //                app.TicketTimeouts.Remove(firstKey);
        //                Console.Write(" - successful");
        //            }
        //            else
        //            {
        //                Console.Write(" - failed");
        //            }
        //            Settings.SerializeTicketTimeouts(app.ApplicationContext, app.TicketTimeouts);
        //        });
        //    }
        //}

        private IEnumerable<INode> RefreshNode(object Caller, INode node)
        {
            IEnumerable<INode> nodes = null;
            NodeFactory.FetchWithNode(Caller, node, delegate (IEnumerable<INode> n)
            {
                nodes = n;
            }, delegate (Exception ex)
            {
                Utilities.ConsoleLog(ex.Message);
            });
            while (nodes == null)
            {
                Thread.Sleep(5);
            }
            return nodes;
        }

        public void Stop()
        {
            this.Running = false;
            this.nodeRefreshTimer.Stop();
        }

        //      [DebuggerStepThrough]
        //      [AsyncStateMachine(typeof(< SaveToCache > c__async0))]
        //      public Task SaveToCache()
        //      {

        //      < SaveToCache > c__async0 < SaveToCache > c__async = default(< SaveToCache > c__async0);

        //      < SaveToCache > c__async.$this = this;

        //      < SaveToCache > c__async.$builder = AsyncTaskMethodBuilder.Create();
        //          ref AsyncTaskMethodBuilder $builder = ref < SaveToCache > c__async.$builder;
        //$builder.Start(ref < SaveToCache > c__async);
        //          return $builder.Task;
        //      }

        public void ClearCache()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string path = Path.Combine(folderPath, "data.json");
            if (File.Exists(path))
            {
                File.Delete(path);
                lock (NodeStore.syncRoot)
                {
                    this.dictNodeStore.Clear();
                    this.setVoucherIDs.Clear();
                    this.dictNodeChildIDs.Clear();
                }
            }
        }

        public bool Exists(string ID)
        {
            lock (NodeStore.syncRoot)
            {
                return this.dictNodeStore.ContainsKey(ID);
            }
        }

        public int ChildCount(string ID)
        {
            lock (NodeStore.syncRoot)
            {
                return this.dictNodeChildIDs.ContainsKey(ID) ? this.dictNodeChildIDs[ID].Count() : 0;
            }
        }

        public int Count()
        {
            lock (NodeStore.syncRoot)
            {
                return this.dictNodeStore.Count();
            }
        }

        public INode NodeWithID(string ID)
        {
            if (this.dictNodeStore != null)
            {
                lock (NodeStore.syncRoot)
                {
                    try
                    {
                        return this.dictNodeStore[ID];
                    }
                    catch
                    {
                    }
                }
            }
            return null;
        }

        public INode NodeByServiceID(string ID)
        {
            if (this.dictNodeStore != null)
            {
                lock (NodeStore.syncRoot)
                {
                    return this.dictNodeStore.Values.FirstOrDefault((INode node) => node.Tags.ContainsKey("Service.ID") && node.Tags["Service.ID"] == ID);
                }
            }
            return null;
        }

        public INode NodeByOriginalID(string ID)
        {
            if (this.dictNodeStore != null)
            {
                lock (NodeStore.syncRoot)
                {
                    return this.dictNodeStore.Values.FirstOrDefault((INode n) => n.OriginalID == ID);
                }
            }
            return null;
        }

        public string NodeServiceID(INode node)
        {
            string result = null;
            if (node.Tags.ContainsKey("Service.ID"))
            {
                result = node.Tags["Service.ID"];
            }
            return result;
        }

        public string BookmarkedServiceAliasNodeID(string contentRoot, string serviceID)
        {
            string serviceAliasID = null;
            List<INode> list = this.Children(contentRoot).ToList();
            list.ForEach(delegate (INode node)
            {
                if (node.Tags.ContainsKey("Service.ID") && node.Tags["Service.ID"] == serviceID)
                {
                    serviceAliasID = node.ID;
                }
            });
            return serviceAliasID;
        }

        public IEnumerable<INode> Children(string ID)
        {
            lock (NodeStore.syncRoot)
            {
                List<INode> listChildren = new List<INode>();
                if (!string.IsNullOrEmpty(ID) && this.dictNodeChildIDs.ContainsKey(ID))
                {
                    this.dictNodeChildIDs[ID].ToList().ForEach(delegate (string id)
                    {
                        if (this.dictNodeStore.ContainsKey(id))
                        {
                            listChildren.Add(this.dictNodeStore[id]);
                        }
                        else
                        {
                            this.dictNodeChildIDs[ID].Remove(id);
                        }
                    });
                }
                return listChildren;
            }
        }

        public IEnumerable<INode> Children(string ID, string Type)
        {
            lock (NodeStore.syncRoot)
            {
                List<INode> listChildren = new List<INode>();
                if (this.dictNodeChildIDs.ContainsKey(ID))
                {
                    this.dictNodeChildIDs[ID].ToList().ForEach(delegate (string id)
                    {
                        if (this.dictNodeStore.ContainsKey(id))
                        {
                            INode node = this.dictNodeStore[id];
                            if (node.Type == Type)
                            {
                                listChildren.Add(node);
                            }
                        }
                        else
                        {
                            this.dictNodeChildIDs[ID].Remove(id);
                        }
                    });
                }
                return listChildren;
            }
        }

        public IEnumerable<INode> Descendants(string ID)
        {
            lock (NodeStore.syncRoot)
            {
                return (from n in this.dictNodeStore.Values
                        where n.ParentID == ID || n.AncestorIDs.Contains(ID)
                        select n).ToList();
            }
        }

        public IEnumerable<INode> Descendants(string ID, string Type)
        {
            lock (NodeStore.syncRoot)
            {
                return (from n in this.dictNodeStore.Values
                        where (n.ParentID == ID || n.AncestorIDs.Contains(ID)) && n.Type == Type
                        select n).ToList();
            }
        }

        public IEnumerable<INode> Tickets()
        {
            lock (NodeStore.syncRoot)
            {
                List<INode> listTickets = new List<INode>();
                this.setVoucherIDs.ForEach(delegate (string id)
                {
                    if (this.dictNodeStore.ContainsKey(id))
                    {
                        listTickets.Add(this.dictNodeStore[id]);
                    }
                });
                return listTickets;
            }
        }

        public string NavigateBack(string id, int levels)
        {
            lock (NodeStore.syncRoot)
            {
                INode node = this.dictNodeStore[id];
                if (node.ParentID == string.Empty)
                {
                    return "root";
                }
                string result = string.Empty;
                for (int i = 0; i < levels; i++)
                {
                    INode node2 = this.dictNodeStore[node.ParentID];
                    if (node2.Type == "Node.Group")
                    {
                        node2 = this.dictNodeStore[node2.ParentID];
                    }
                    result = node2.ID;
                    node = node2;
                }
                return result;
            }
        }

        public bool HasChildren(string ID)
        {
            int num = 0;
            lock (NodeStore.syncRoot)
            {
                foreach (INode value in this.dictNodeStore.Values)
                {
                    if (value.ParentID == ID && value.Type != "Node.QueryResult.FurtherResultsAvailable")
                    {
                        num++;
                    }
                }
            }
            return (byte)((num > 0) ? 1 : 0) != 0;
        }

        public bool HasChildren(string ID, string Type)
        {
            lock (NodeStore.syncRoot)
            {
                return this.dictNodeChildIDs[ID].Any((string childid) => this.dictNodeStore[childid].ParentID == ID && this.dictNodeStore[childid].Type == Type);
            }
        }

        public void Remove(string nodeID)
        {
            lock (NodeStore.syncRoot)
            {
                if (this.dictNodeStore.ContainsKey(nodeID))
                {
                    INode node = this.dictNodeStore[nodeID];
                    if (!string.IsNullOrEmpty(node.ParentID) && this.dictNodeChildIDs.ContainsKey(node.ParentID))
                    {
                        this.dictNodeChildIDs[node.ParentID].Remove(nodeID);
                    }
                }
                this.setVoucherIDs.Remove(nodeID);
                this.dictNodeStore.Remove(nodeID);
            }
        }

        public void Update(INode nodeToSave)
        {
            lock (NodeStore.syncRoot)
            {
                INode node = (!this.dictNodeStore.ContainsKey(nodeToSave.ID)) ? null : this.dictNodeStore[nodeToSave.ID];
                if (node != null)
                {
                    Utilities.ConsoleLog(node.Name);
                    List<string> ancestorIDs = node.AncestorIDs;
                    string parentID = node.ParentID;
                    this.Remove(node.ID);
                    nodeToSave.AncestorIDs = ancestorIDs;
                    nodeToSave.ParentID = parentID;
                    if (nodeToSave.Type == "Node.Voucher")
                    {
                        this.setVoucherIDs.Add(nodeToSave.ID);
                    }
                    if (!string.IsNullOrEmpty(parentID))
                    {
                        if (!this.dictNodeChildIDs.ContainsKey(parentID))
                        {
                            this.dictNodeChildIDs[parentID] = new HashSet<string>();
                        }
                        this.dictNodeChildIDs[parentID].Add(nodeToSave.ID);
                    }
                    this.dictNodeStore[nodeToSave.ID] = nodeToSave;
                }
            }
        }

        public void UpdateWithNewPosition(INode nodeToSave, string _parentID, List<string> _anc)
        {
            lock (NodeStore.syncRoot)
            {
                INode node = this.dictNodeStore[nodeToSave.ID];
                this.Remove(node.ID);
                nodeToSave.AncestorIDs = _anc;
                nodeToSave.ParentID = _parentID;
                if (nodeToSave.Type == "Node.Voucher")
                {
                    this.setVoucherIDs.Add(nodeToSave.ID);
                }
                if (!string.IsNullOrEmpty(_parentID))
                {
                    if (!this.dictNodeChildIDs.ContainsKey(_parentID))
                    {
                        this.dictNodeChildIDs[_parentID] = new HashSet<string>();
                    }
                    this.dictNodeChildIDs[_parentID].Add(nodeToSave.ID);
                }
                this.dictNodeStore[nodeToSave.ID] = nodeToSave;
            }
        }

        //      [DebuggerStepThrough]
        //      [AsyncStateMachine(typeof(< Add > c__async1))]
        //      public Task Add(INode node, bool nodesAreTemp = false, bool isTicket = false)
        //      {

        //      < Add > c__async1 < Add > c__async = default(< Add > c__async1);

        //      < Add > c__async.node = node;

        //      < Add > c__async.nodesAreTemp = nodesAreTemp;

        //      < Add > c__async.isTicket = isTicket;

        //      < Add > c__async.$this = this;

        //      < Add > c__async.$builder = AsyncTaskMethodBuilder.Create();
        //          ref AsyncTaskMethodBuilder $builder = ref < Add > c__async.$builder;
        //$builder.Start(ref < Add > c__async);
        //          return $builder.Task;
        //      }

        //      [DebuggerStepThrough]
        //      [AsyncStateMachine(typeof(< Add > c__async2))]
        //      public Task Add(IEnumerable<INode> nodes, bool nodesAreTemp = false, bool isTicket = false, bool isBanner = false, bool saveToCache = true)
        //      {

        //      < Add > c__async2 < Add > c__async = default(< Add > c__async2);

        //      < Add > c__async.nodes = nodes;

        //      < Add > c__async.nodesAreTemp = nodesAreTemp;

        //      < Add > c__async.isTicket = isTicket;

        //      < Add > c__async.saveToCache = saveToCache;

        //      < Add > c__async.$this = this;

        //      < Add > c__async.$builder = AsyncTaskMethodBuilder.Create();
        //          ref AsyncTaskMethodBuilder $builder = ref < Add > c__async.$builder;
        //$builder.Start(ref < Add > c__async);
        //          return $builder.Task;
        //      }

        public void DeleteNodeAndChildren(string ID)
        {
            this.DeleteNodeAndChildren(ID, true);
        }

        //[DebuggerStepThrough]
        //[AsyncStateMachine(typeof(< DeleteNodeAndChildren > c__async3))]
        //public void DeleteNodeAndChildren(string ID, bool SaveAfterwards)
        //{

        //< DeleteNodeAndChildren > c__async3 < DeleteNodeAndChildren > c__async = default(< DeleteNodeAndChildren > c__async3);

        //< DeleteNodeAndChildren > c__async.ID = ID;

        //< DeleteNodeAndChildren > c__async.SaveAfterwards = SaveAfterwards;

        //< DeleteNodeAndChildren > c__async.$this = this;

        //< DeleteNodeAndChildren > c__async.$builder = AsyncVoidMethodBuilder.Create();

        //< DeleteNodeAndChildren > c__async.$builder.Start(ref < DeleteNodeAndChildren > c__async);
        //}

        public void DeleteVouchersAndChildren(List<Node.Voucher> nodes)
        {
            Utilities.ConsoleLog("dictNodeStore.Count: " + this.dictNodeStore.Count);
            nodes.ForEach(delegate (Node.Voucher node)
            {
                this.DeleteNodeAndChildren(node.ID, false);
            });
            Utilities.ConsoleLog("dictNodeStore.Count: " + this.dictNodeStore.Count);
        }

        public void DeleteNodesAndChildren(List<Node> nodes)
        {
            Utilities.ConsoleLog("dictNodeStore.Count: " + this.dictNodeStore.Count);
            nodes.ForEach(delegate (Node node)
            {
                this.DeleteNodeAndChildren(node.ID, false);
            });
            Utilities.ConsoleLog("dictNodeStore.Count: " + this.dictNodeStore.Count);
        }

        private void DeleteNodeAndChildren(object iD, bool v)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllTickets()
        {
            Utilities.ConsoleLog("node count before deleting tickets: " + this.dictNodeStore.Count);
            this.setVoucherIDs.ToList().ForEach(delegate (string vid)
            {
                this.DeleteNodeAndChildren(vid, false);
            });
            this.setVoucherIDs.Clear();
            Utilities.ConsoleLog("node count after deleting tickets: " + this.dictNodeStore.Count);
        }

        //[DebuggerStepThrough]
        //[AsyncStateMachine(typeof(< DeleteAllNodes > c__async4))]
        //public void DeleteAllNodes(bool _saveToCache = true)
        //{

        //< DeleteAllNodes > c__async4 < DeleteAllNodes > c__async = default(< DeleteAllNodes > c__async4);

        //< DeleteAllNodes > c__async._saveToCache = _saveToCache;

        //< DeleteAllNodes > c__async.$this = this;

        //< DeleteAllNodes > c__async.$builder = AsyncVoidMethodBuilder.Create();

        //< DeleteAllNodes > c__async.$builder.Start(ref < DeleteAllNodes > c__async);
        //}

        private INode ReconcileTicketExpiry(INode newTicket, Dictionary<string, string> dictStoredTicketExpiries)
        {
            newTicket.IsVoucher = true;
            if (newTicket.Type != "Node.Internal.Error" && newTicket.Type != "Node.Internal.QueryResult" && newTicket.IsVoucher && newTicket.AncestorIDs.Count() == 0 && dictStoredTicketExpiries.ContainsKey(newTicket.ID))
            {
                string empty = string.Empty;
                string empty2 = string.Empty;
                string value = string.Empty;
                empty = dictStoredTicketExpiries[newTicket.ID];
                empty2 = newTicket["Expiry"];
                if (!string.IsNullOrEmpty(empty2) && string.IsNullOrEmpty(empty))
                {
                    value = empty2;
                }
                else if (string.IsNullOrEmpty(empty2) && !string.IsNullOrEmpty(empty))
                {
                    value = empty;
                }
                else if (!string.IsNullOrEmpty(empty2) && !string.IsNullOrEmpty(empty))
                {
                    if (empty2 != empty)
                    {
                        DateTime utcNow = DateTime.UtcNow;
                        DateTime d = empty.ToUTCDateTime();
                        DateTime d2 = empty2.ToUTCDateTime();
                        TimeSpan t = d - utcNow;
                        TimeSpan t2 = d2 - utcNow;
                        value = ((!(t2 > t)) ? empty2 : empty);
                    }
                    else
                    {
                        value = empty2;
                    }
                }
                else if (!string.IsNullOrEmpty(empty2) || !string.IsNullOrEmpty(empty))
                {
                    ;
                }
                newTicket["Expiry"] = value;
            }
            return newTicket;
        }

        private Dictionary<string, string> BackupExistingTickets(Dictionary<string, string> dictStoredTicketExpiries)
        {
            foreach (string setVoucherID in this.setVoucherIDs)
            {
                INode node = this.NodeWithID(setVoucherID);
                if (node.IsVoucher && node.AncestorIDs.Count() == 0 && !string.IsNullOrEmpty(node["Expiry"]) && !dictStoredTicketExpiries.ContainsKey(node.ID))
                {
                    dictStoredTicketExpiries.Add(node.ID, node["Expiry"]);
                }
            }
            return dictStoredTicketExpiries;
        }

        //       public bool QueryWithNode(object Caller, INode nodeQuery)
        //       {
        //           IEnumerable<INode> result = Communications.QueryWithNode(Caller, nodeQuery);
        //           if (result is Node.Internal.Error)
        //           {
        //               return false;
        //           }

        //       < QueryWithNode > c__AnonStorey28 <> f__ref$;
        //           Task.Run(delegate
        //           {


        //               < QueryWithNode > c__AnonStorey28.< QueryWithNode > c__async27 < QueryWithNode > c__async = default(< QueryWithNode > c__AnonStorey28.< QueryWithNode > c__async27);

        //           < QueryWithNode > c__async.<> f__ref$40 = <> f__ref$;

        //           < QueryWithNode > c__async.$builder = AsyncTaskMethodBuilder.Create();
        //           ref AsyncTaskMethodBuilder $builder = ref < QueryWithNode > c__async.$builder;
        //		$builder.Start(ref < QueryWithNode > c__async);
        //           return $builder.Task;
        //       });
        //	return true;
        //}

        public void ForceExpiry(string id)
        {
            lock (NodeStore.syncRoot)
            {
                if (this.dictNodeStore.ContainsKey(id))
                {
                    this.dictNodeStore[id].CacheExpires = DateTime.UtcNow.AddHours(-1.0);
                }
            }
        }
    }
}