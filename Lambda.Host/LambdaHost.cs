using Lambda.CoreService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.Host
{
    public class LambdaHost
    {
        ServiceHost host;

        #region Singleton
        private static volatile LambdaHost instance;
        private static readonly object syncRoot = new Object();
        private LambdaHost() 
        { 
            //host = new ServiceHost(typeof(Lambda.AutoService.DataService));
            host = new WebServiceHost(typeof(Lambda.AutoService.DataService));
            host.Opened += host_Opened;
            
        }

        void host_Opened(object sender, EventArgs e)
        {
            WriteLog();
        }
        public static LambdaHost Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new LambdaHost();
                    }
                }
                return instance;
            }
        }
        #endregion

        public void AddEndpoint()
        {
            host.Description.Endpoints.Clear();
            
            string tcpAddress = string.Format("net.tcp://localhost:{0}/Autoservice", 9998);
            var tcpBinding = new NetTcpBinding();
            tcpBinding.MaxReceivedMessageSize = 100000000;
            tcpBinding.ListenBacklog = 200;
            tcpBinding.MaxConnections = 200;

            ServiceEndpoint tcpEndPoint = host.AddServiceEndpoint(typeof(IDataService), tcpBinding, tcpAddress);

            host.AddServiceEndpoint(typeof(IDataService), new WebHttpBinding(), string.Format("http://localhost:{0}/Autoservice", 9999));

            //ServiceMetadataBehavior metadata = new ServiceMetadataBehavior();
            //metadata.HttpGetEnabled = true;
            //metadata.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            //host.Description.Behaviors.Add(metadata);  

            //var mexBinding = MetadataExchangeBindings.CreateMexTcpBinding();
            //host.AddServiceEndpoint(typeof(IMetadataExchange), mexBinding, "mex");

            //var mexBinding = MetadataExchangeBindings.CreateMexHttpBinding();
            //host.AddServiceEndpoint(typeof(IMetadataExchange), mexBinding, string.Format("http://localhost:{0}/Autoservice/mex", 9999));

            //string httpAddress = string.Format("http://localhost:{0}/Autoservice", 9999);
            //var httpBinding = new WSHttpBinding();
            //httpBinding.MaxReceivedMessageSize = 100000000;
            
            //host.AddServiceEndpoint(typeof(IDataService), httpBinding, httpAddress);
        }
        public void Open()
        {
            try
            {
                AddEndpoint();
                host.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Close()
        {
            try
            {
                if (host != null)
                {
                    host.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void WriteLog()
        {
            try
            {
                using (var sw = new StreamWriter(string.Format("{0}_AutoServiceLog.txt", DateTime.Now.ToString("yyyy_MM_dd")), true))
                {
                    foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
                    {
                        sw.WriteLine("{0} ({1})", endpoint.Address.ToString(), endpoint.Binding.Name);
                    }
                    sw.Close();
                }
            }
            catch
            {
            }
        }
    }
}
