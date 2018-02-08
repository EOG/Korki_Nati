using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki9
{
    public static class NodeFactory
    {
        private delegate T ObjectActivator<T>(params object[] args);

        private const string cstrSanitisePhoneUri = "Corethree/Authentication/SanitisePhoneNumber?Country=United+Kingdom&Number={0}";

        private const string cstrQueryUri = "Corethree/ClientSupport/GetNodesWithQuery?CorePath={0}";

        private const string cstrQueryWithNode = "Corethree/ClientSupport/GetNodesWithNode";

        private const string cstrFetchVouchers = "/Corethree/ClientSupport/FetchVouchers?fromdt={0}";

        private const string cstrHitLog = "/Logging/Log_Hit";

        private const string cstrExpireTicket = "/Corethree/ClientSupport/SetTicketExpiry_v2";

        private const string cstrFlagVoucherOpened = "/Corethree/ClientSupport/FlagVoucherOpened";

        private const string cstrFlagSetTicketTimeout = "/Corethree/ClientSupport/SetTicketTimeout";

        private const string cstrFetchBanners = "/ep/corethree/get-app-banners";

        public static Dictionary<string, Type> TypeCache = new Dictionary<string, Type>();

        public static IEnumerable<INode> FromJson(string data)
        {
            List<INode> listNodes = new List<INode>();
            if (!string.IsNullOrEmpty(data))
            {
                JArray jArray = JArray.Parse(data);
                jArray.ForEach(delegate (JToken obj)
                {
                    JObject jsonObject = obj as JObject;
                    listNodes.Add(NodeFactory.GetNode(jsonObject));
                });
                jArray.Clear();
            }
            data = null;
            return listNodes;
        }

        public static IEnumerable<INode> FromJson(byte[] data)
        {
            return NodeFactory.FromJson(Encoding.UTF8.GetString(data));
        }

        public static void FetchWithQuery(object Caller, string Query, Action<IEnumerable<INode>> OnCompletion, Action<Exception> OnFailure)
        {
            string uRL = string.Format("Corethree/ClientSupport/GetNodesWithQuery?CorePath={0}", Query);
            //Communications.PerformRequestAsync(Caller, uRL, null, delegate (string str)
            //{
            //    OnCompletion(NodeFactory.FromJson(str));
            //}, delegate (Exception ex)
            //{
            //    OnFailure(ex);
            //});
        }

  //      [DebuggerStepThrough]
  //      [AsyncStateMachine(typeof(< FetchWithNodeTask > c__async0))]
  //      public static Task FetchWithNodeTask(object Caller, INode node, Action<IEnumerable<INode>> OnCompletion, Action<Exception> OnFailure)
  //      {

  //      < FetchWithNodeTask > c__async0 < FetchWithNodeTask > c__async = default(< FetchWithNodeTask > c__async0);

  //      < FetchWithNodeTask > c__async.Caller = Caller;

  //      < FetchWithNodeTask > c__async.node = node;

  //      < FetchWithNodeTask > c__async.OnCompletion = OnCompletion;

  //      < FetchWithNodeTask > c__async.OnFailure = OnFailure;

  //      < FetchWithNodeTask > c__async.$builder = AsyncTaskMethodBuilder.Create();
  //          ref AsyncTaskMethodBuilder $builder = ref < FetchWithNodeTask > c__async.$builder;
		//$builder.Start(ref < FetchWithNodeTask > c__async);
  //          return $builder.Task;
  //      }

        public static void FetchWithNode(object Caller, INode node, Action<IEnumerable<INode>> OnCompletion, Action<Exception> OnFailure)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Node", node.ToXml());
            //Communications.PerformRequestAsync(Caller, "Corethree/ClientSupport/GetNodesWithNode", dictionary, delegate (string str)
            //{
            //    OnCompletion(NodeFactory.FromJson(str));
            //}, delegate (Exception ex)
            //{
            //    OnFailure(ex);
            //});
        }

        public static void FetchNodesWithPartUri(object Caller, string PartUri, Action<IEnumerable<INode>> OnCompletion, Action<Exception> OnFailure)
        {
            //string empty = string.Empty;
            //if (PartUri.Contains("?"))
            //{
            //    string[] array = PartUri.Split('?');
            //    string text = array[0];
            //    string str2 = text.Substring(7, text.Length - 7).Replace('.', '/');
            //    empty = str2 + "?" + array[1];
            //}
            //else
            //{
            //    empty = PartUri.Substring(7, PartUri.Length - 7).Replace('.', '/');
            //}
            //Communications.PerformRequestAsync(Caller, empty, null, delegate (string str)
            //{
            //    OnCompletion(NodeFactory.FromJson(str));
            //}, delegate (Exception ex)
            //{
            //    OnFailure(ex);
            //});
        }

        public static Dictionary<string, string> UnexpiredVoucherIds(NodeStore nodeStore)
        {
            IEnumerable<INode> enumeration = nodeStore.Tickets();
            List<string> listUnexpiredVoucherIDs = new List<string>();
            enumeration.ForEach(delegate (INode ticket)
            {
                string text = string.Empty;
                if (!string.IsNullOrEmpty(ticket["Expiry"]))
                {
                    text = ticket["Expiry"];
                }
                if (!string.IsNullOrWhiteSpace(text))
                {
                    DateTime t = text.ToUTCDateTime().ToUniversalTime();
                    if (t > DateTime.UtcNow)
                    {
                        listUnexpiredVoucherIDs.Add(ticket.ID);
                    }
                }
                else
                {
                    listUnexpiredVoucherIDs.Add(ticket.ID);
                }
            });
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("unexpiredvoucherids", string.Join("|", listUnexpiredVoucherIDs));
            return dictionary;
        }

 //       public static void FetchAndStoreVouchers(Activity context, NodeStore nodeStore, Action OnCompletion, bool _alertUser, Action<Exception> OnFailure)
 //       {
 //           try
 //           {
 //               CoreApplication app = (CoreApplication)context.Application;
 //               if (app != null && app.FetchVouchers)
 //               {

 //               < FetchAndStoreVouchers > c__AnonStoreyB <> f__ref$;

 //               < FetchAndStoreVouchers > c__AnonStoreyA <> f__ref$2;
 //                   NodeFactory.FetchVouchers(context, nodeStore, app.ClientActions.LastTicketDownloadTimeStamp, delegate (IEnumerable<INode> vouchers)
 //                   {

 //                   < FetchAndStoreVouchers > c__AnonStoreyA.< FetchAndStoreVouchers > c__async9 < FetchAndStoreVouchers > c__async = default(< FetchAndStoreVouchers > c__AnonStoreyA.< FetchAndStoreVouchers > c__async9);

 //                   < FetchAndStoreVouchers > c__async.<> f__ref$11 = <> f__ref$;

 //                   < FetchAndStoreVouchers > c__async.<> f__ref$10 = <> f__ref$2;

 //                   < FetchAndStoreVouchers > c__async.vouchers = vouchers;

 //                   < FetchAndStoreVouchers > c__async.$builder = AsyncVoidMethodBuilder.Create();

 //                   < FetchAndStoreVouchers > c__async.$builder.Start(ref < FetchAndStoreVouchers > c__async);
 //               }, delegate (Exception ex)
 //            {
 //                if (OnFailure != null)
 //                {
 //                    OnFailure(ex);
 //                }
 //            });
 //           }

 //       }
	//	catch
	//	{
	//	}
	//}

    //[DebuggerStepThrough]
    //[AsyncStateMachine(typeof(< FetchVouchers > c__async1))]
    //public static void FetchVouchers(object Caller, NodeStore nodeStore, DateTime lastDownloadTime, Action<IEnumerable<INode>> OnCompletion, Action<Exception> OnFailure)
    //{

    //    < FetchVouchers > c__async1 < FetchVouchers > c__async = default(< FetchVouchers > c__async1);

    //    < FetchVouchers > c__async.nodeStore = nodeStore;

    //    < FetchVouchers > c__async.lastDownloadTime = lastDownloadTime;

    //    < FetchVouchers > c__async.Caller = Caller;

    //    < FetchVouchers > c__async.OnCompletion = OnCompletion;

    //    < FetchVouchers > c__async.OnFailure = OnFailure;

    //    < FetchVouchers > c__async.$builder = AsyncVoidMethodBuilder.Create();

    //    < FetchVouchers > c__async.$builder.Start(ref < FetchVouchers > c__async);
    //}

    //private static void UpdateExpiredVoucher(CoreApplication app, NodeStore nodeStore, List<Node.Voucher> voucherList, KeyValuePair<string, string> expiredVoucher)
    //{
    //    string voucherID = expiredVoucher.Key.Split('.')[1];
    //    Node.Voucher voucher = voucherList.SingleOrDefault((Node.Voucher v) => v.ID == voucherID);
    //    if (voucher != null)
    //    {
    //        DateTime utcNow = default(DateTime);
    //        if (!DateTime.TryParse(expiredVoucher.Value, out utcNow))
    //        {
    //            utcNow = DateTime.UtcNow;
    //        }
    //        voucherList.Remove(voucher);
    //        voucher.Expiry = utcNow;
    //        voucher.SetTag("Ticket.ExpiryReason", "Server update");
    //        app.ListExpiredVouchers.Add(voucher);
    //        nodeStore.Update(voucher);
    //    }
    //}

  //  [DebuggerStepThrough]
  //  [AsyncStateMachine(typeof(< StoreVouchers > c__async2))]
  //  public static Task StoreVouchers(CoreApplication app, Activity context, IEnumerable<INode> vouchers, Action OnCompletion, NodeStore nodeStore, bool _alertUser)
  //  {

  //      < StoreVouchers > c__async2 < StoreVouchers > c__async = default(< StoreVouchers > c__async2);

  //      < StoreVouchers > c__async.vouchers = vouchers;

  //      < StoreVouchers > c__async.context = context;

  //      < StoreVouchers > c__async.app = app;

  //      < StoreVouchers > c__async.OnCompletion = OnCompletion;

  //      < StoreVouchers > c__async.nodeStore = nodeStore;

  //      < StoreVouchers > c__async._alertUser = _alertUser;

  //      < StoreVouchers > c__async.$builder = AsyncTaskMethodBuilder.Create();
  //      ref AsyncTaskMethodBuilder $builder = ref < StoreVouchers > c__async.$builder;
		//$builder.Start(ref < StoreVouchers > c__async);
  //      return $builder.Task;
  //  }

    //public static void UploadHitLog(object Caller, List<LogItem> itemsToUpload, Action<IEnumerable<INode>> OnCompletion)
    //{
    //    string text = string.Empty;
    //    string text2 = string.Empty;
    //    string text3 = string.Empty;
    //    foreach (LogItem item in itemsToUpload)
    //    {
    //        text = text + item.DateLogged + ",";
    //        text2 = text2 + item.NodeId + ",";
    //        text3 = text3 + item.RefererId + ",";
    //    }
    //    text.TrimEnd(',');
    //    text2.TrimEnd(',');
    //    text3.TrimEnd(',');
    //    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    //    dictionary.Add("Device_ID", Settings.GetSetting(Application.Context, "DeviceGUID"));
    //    dictionary.Add("User_ID", string.Empty);
    //    dictionary.Add("DT", text);
    //    dictionary.Add("Node_ID", text2);
    //    dictionary.Add("ReferrerNode_ID", text3);
    //    Communications.PerformRequestAsync(Caller, "/Logging/Log_Hit", dictionary, delegate (string str)
    //    {
    //        OnCompletion(NodeFactory.FromJson(str));
    //    }, delegate (Exception ex)
    //    {
    //        Utilities.ConsoleLog(ex.Message);
    //    });
    //}

    //public static void ActivateServerTicket(object Caller, Dictionary<string, string> parameters, Action<IEnumerable<INode>> OnCompletion)
    //{
    //    Communications.PerformRequestAsync(Caller, "/Corethree/ClientSupport/SetTicketExpiry_v2", parameters, delegate (string str)
    //    {
    //        OnCompletion(NodeFactory.FromJson(str));
    //    }, delegate (Exception ex)
    //    {
    //        Utilities.ConsoleLog(ex.Message);
    //    });
    //}

    //public static void FlagVoucherOpened(object Caller, Dictionary<string, string> parameters, Action<IEnumerable<INode>> OnCompletion, Action<string> OnFailure)
    //{
    //    Communications.PerformRequestAsync(Caller, "/Corethree/ClientSupport/FlagVoucherOpened", parameters, delegate (string str)
    //    {
    //        OnCompletion(NodeFactory.FromJson(str));
    //    }, delegate (Exception ex)
    //    {
    //        Utilities.ConsoleLog(ex.Message);
    //        OnFailure(ex.Message);
    //    });
    //}

    //public static void FlagSetTicketTimeout(object Caller, Dictionary<string, string> parameters, Action<IEnumerable<INode>> OnCompletion)
    //{
    //    Communications.PerformRequestAsync(Caller, "/Corethree/ClientSupport/SetTicketTimeout", parameters, delegate (string str)
    //    {
    //        OnCompletion(NodeFactory.FromJson(str));
    //    }, delegate (Exception ex)
    //    {
    //        Utilities.ConsoleLog(ex.Message);
    //    });
    //}

//    public static void FetchBanners(object Caller, Action<IEnumerable<INode>> OnCompletion, Action<Exception> OnFailure)
//    {
//        string uRL = string.Format("/ep/corethree/get-app-banners");
//        Communications.PerformRequestAsync(Caller, uRL, null, delegate (string str)
//        {
//            OnCompletion(NodeFactory.FromJson(str));
//        }, delegate (Exception ex)
//        {
//            OnFailure(ex);
//        });
//    }

//    public static void FetchAndStoreBanners(Activity context, NodeStore nodeStore, Action OnCompletion, Action<Exception> OnFailure)
//    {
//        CoreApplication coreApplication = (CoreApplication)context.Application;

//        < FetchAndStoreBanners > c__AnonStorey1A <> f__ref$;
//        NodeFactory.FetchBanners(context, delegate (IEnumerable<INode> banners)
//        {

//            < FetchAndStoreBanners > c__AnonStorey1A.< FetchAndStoreBanners > c__async19 < FetchAndStoreBanners > c__async = default(< FetchAndStoreBanners > c__AnonStorey1A.< FetchAndStoreBanners > c__async19);

//            < FetchAndStoreBanners > c__async.<> f__ref$26 = <> f__ref$;

//            < FetchAndStoreBanners > c__async.banners = banners;

//            < FetchAndStoreBanners > c__async.$builder = AsyncVoidMethodBuilder.Create();

//            < FetchAndStoreBanners > c__async.$builder.Start(ref < FetchAndStoreBanners > c__async);
//    }, delegate (Exception ex)
//		{

//            OnFailure(ex);
//});
//	}

//	public static T GetInstance<T>(string assemblyName, string typeFullName, params object[] args)
//{
//    T val = default(T);
//    Assembly assembly = Assembly.Load(NodeFactory.GetAssemblyName(assemblyName));
//    Type type = assembly.GetType(typeFullName);
//    ConstructorInfo constructor = NodeFactory.GetConstructor(args, type);
//    ObjectActivator<T> activator = NodeFactory.GetActivator<T>(constructor);
//    return activator(args);
//}

//private static AssemblyName GetAssemblyName(string assemblyName)
//{
//    return new AssemblyName(assemblyName);
//}

//private static ConstructorInfo GetConstructor(object[] args, Type type)
//{
//    if (args == null)
//    {
//        args = new object[0];
//    }
//    return type.GetConstructor((from o in args
//                                select o.GetType()).ToArray());
//}

//public static T GetInstance<T>(Type type, params object[] args)
//{
//    T val = default(T);
//    ConstructorInfo constructor = NodeFactory.GetConstructor(args, type);
//    ObjectActivator<T> activator = NodeFactory.GetActivator<T>(constructor);
//    return activator(args);
//}

//public static T GetInstance<T>(string assemblyName, string typeFullName)
//{
//    return NodeFactory.GetInstance<T>(assemblyName, typeFullName, new object[0]);
//}

//public static T GetInstance<T>(string fullTypeName)
//{
//    string[] array = fullTypeName.Split(new char[1]
//    {
//            ','
//    }, 2);
//    return NodeFactory.GetInstance<T>(array[1].Trim(), array[0].Trim(), new object[0]);
//}

//private static ObjectActivator<T> GetActivator<T>(ConstructorInfo ctor)
//{
//    ParameterInfo[] parameters = ctor.GetParameters();
//    ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), "args");
//    Expression[] array = new Expression[parameters.Length];
//    for (int i = 0; i < parameters.Length; i++)
//    {
//        Expression index = Expression.Constant(i);
//        Type parameterType = parameters[i].ParameterType;
//        Expression expression = Expression.ArrayIndex(parameterExpression, index);
//        Expression expression2 = array[i] = Expression.Convert(expression, parameterType);
//    }
//    NewExpression body = Expression.New(ctor, array);
//    LambdaExpression lambdaExpression = Expression.Lambda(typeof(ObjectActivator<T>), body, parameterExpression);
//    return (ObjectActivator<T>)lambdaExpression.Compile();
//}

//public static INode GetNode(JObject jsonObject)
//{
//    Type type = null;
//    string text = jsonObject["Type"].ToString();
//    if (NodeFactory.TypeCache.ContainsKey(text))
//    {
//        type = NodeFactory.TypeCache[text];
//    }
//    else
//    {
//        type = Type.GetType("Core." + text.Replace("\"", string.Empty).Replace(".", "+"));
//        NodeFactory.TypeCache[text] = type;
//    }
//    INode node = Activator.CreateInstance(type) as INode;
//    node.Initialize(jsonObject);
//    return node;
//}
    }
}
