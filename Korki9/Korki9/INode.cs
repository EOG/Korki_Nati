using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Korki9
{
    public interface INode
    {
        string ID
        {
            get;
            set;
        }

        string OriginalID
        {
            get;
            set;
        }

        string ParentID
        {
            get;
            set;
        }

        string CommonChildType
        {
            get;
            set;
        }

        List<string> AncestorIDs
        {
            get;
            set;
        }

        int TTL
        {
            get;
            set;
        }

        DateTime CacheExpires
        {
            get;
            set;
        }

        DateTime TimeStamp
        {
            get;
            set;
        }

        int SortOrder
        {
            get;
            set;
        }

        string AliasUri
        {
            get;
            set;
        }

        string AliasMode
        {
            get;
            set;
        }

        string AliasContext
        {
            get;
            set;
        }

        string TreeMode
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        string Type
        {
            get;
            set;
        }

        string Subtitle
        {
            get;
            set;
        }

        string Desc
        {
            get;
            set;
        }

        string URLRef
        {
            get;
            set;
        }

        TagProxy Tags
        {
            get;
        }

        string this[string Key]
        {
            get;
            set;
        }

        bool IsTemp
        {
            get;
            set;
        }

        bool IsVoucher
        {
            get;
            set;
        }

        IEnumerable<INode> Children
        {
            get;
            set;
        }

        void RemoveAncestorID(string ID);

        void SetTag(string Key, string Value);

        bool HasTag(string Key);

        bool HasTags();

        string GetTag(string Key);

        string GetTagOrDefault(string Key);

        IDictionary<string, string> GetAllTags();

        T GetValue<T>(string Key);

        string ToXml();

        XElement ToXmlElement();

        JObject ToJsonObject();

        void Initialize(JObject jsonObject);

        INode Copy();

        INode JSONCopy();

        bool TagValueIsTrue(string Key);
    }
}
