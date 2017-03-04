using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.CoreService
{
    [Synchronization()]
    public class SimpleData
    {
        #region Singleton
        private static volatile SimpleData instance;
        private static readonly object syncRoot = new Object();

        private SimpleData() { }
        public static SimpleData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SimpleData();
                    }
                }
                return instance;
            }
        }
        #endregion

        #region Gen Id, DateTime
        private static readonly object syncDatetime = new Object();
        public long GetLongId()
        {
            lock (syncDatetime)
            {
                System.Threading.Thread.Sleep(1);
                string s = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                return Convert.ToInt64(s);
            }
        }
        private static readonly object syncGuid = new Object();
        public Guid GetGuidId()
        {
            lock (syncGuid)
            {
                return Guid.NewGuid();
            }
        }
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
        #endregion
    }
}
