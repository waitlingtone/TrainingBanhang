using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;

namespace Lambda.CoreService
{
    public enum ModelType {Local = 1, Service =2 }
    [Synchronization()]
    public class ConfigService
    {
        #region Client Config
        string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        ModelType _SelectModelType = ModelType.Service;
        public ModelType SelectModelType
        {
            get { return _SelectModelType; }
            set { _SelectModelType = value; }
        }

        string _Serial = "quanlykhachsan";
        /// <summary>
        /// 
        /// </summary>
        public string Serial
        {
            get { return _Serial; }
            set { _Serial = value; }
        }

        string _AppCSName = "CS";
        /// <summary>
        /// Connection String Name
        /// </summary>
        public string AppCSName
        {
            get { return _AppCSName; }
            set { _AppCSName = value; }
        }

        string _PublicKey;
        /// <summary>
        /// Public Key for RSA
        /// </summary>
        public string PublicKey
        {
            get
            {
                return _PublicKey;
            }
            set { _PublicKey = value; }
        }

        bool _IsCache = false;
        /// <summary>
        /// 
        /// </summary>
        public bool IsCache
        {
            get { return _IsCache; }
            set { _IsCache = value; }
        }

        long _MinuteToCache = 60;
        /// <summary>
        /// 
        /// </summary>
        public long MinuteToCache
        {
            get { return _MinuteToCache; }
            set { _MinuteToCache = value; }
        }
        #endregion

        #region Singleton
        private static volatile ConfigService instance;
        private static readonly object syncRoot = new Object();

        private ConfigService() { }
        public static ConfigService Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ConfigService();
                    }
                }
                return instance;
            }
        }
        #endregion

        #region Server Config
        bool isCheck = false;
        /// <summary>
        /// Server Config, 
        /// Default = true
        /// </summary>
        public bool IsCheck
        {
            get { return isCheck; }
            set { isCheck = value; }
        }
        
        bool isEncrypt = false;
        /// <summary>
        /// Server Config, 
        /// Default = flase
        /// </summary>
        public bool IsEncrypt
        {
            get { return isEncrypt; }
            set { isEncrypt = value; }
        }
        
        bool isCheckSum = false;
        /// <summary>
        /// Server Config, 
        /// Default = flase
        /// </summary>
        public bool IsCheckSum
        {
            get { return isCheckSum; }
            set { isCheckSum = value; }
        }

        #endregion
    }
}
