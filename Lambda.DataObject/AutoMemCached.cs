using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.DataObject
{
    public class AutoMemCached
    {
        static MemoryCache AutoCached = MemoryCache.Default;
        static string MakeKey(string ConnectionStringName, string spName, List<AutoItem> param)
        {
            var vkey = new StringBuilder("");
            if (param == null)
                return string.Format("{0}{1}{2}", ConnectionStringName, spName,vkey.ToString());

            for (int i = 0; i < param.Count; i++)
            {
                if (param[i].SqlType != SqlDbType.Timestamp)
                    vkey.Append(string.Format("{0}",param[i].Value));
            }
            var key = string.Format("{0}{1}{2}", ConnectionStringName, spName,vkey.ToString());
            return key;
        }
        
        public static List<AutoObject> Get(string key, string regionName = null)
        {
            if (!AutoCached.Contains(key))
                return null;
            var result = AutoCached.Get(key, regionName) as List<AutoObject>;
            if (result == null)
                return null;
            return result;
        }
        public static bool Add(string key, List<AutoObject> value, DateTimeOffset absoluteExpiration, string regionName = null)
        {
            if (AutoCached.Contains(key))
                AutoCached.Remove(key, regionName);
            return AutoCached.Add(key, value, absoluteExpiration, regionName);
        }
        public static string MakeKey(string ConnectionStringName, AutoObject item)
        {
            return MakeKey(ConnectionStringName, item.SpName, item.Items);
        }
    }
}
