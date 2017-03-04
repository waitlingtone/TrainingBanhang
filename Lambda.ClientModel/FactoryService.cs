using Lambda.CoreService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace Lambda.ClientModel
{
    /// <summary>
    /// http://msdn.microsoft.com/en-us/library/ms733040.aspx
    /// blogs.msdn.com/b/wenlong/archive/2006/01/23/516041.aspx
    /// http://msdn.microsoft.com/en-us/library/ms752234.aspx
    /// msdn.microsoft.com/en-us/library/aa702682.aspx
    /// http://msdn.microsoft.com/en-us/library/hh205277(v=vs.110).aspx
    /// msdn.microsoft.com/en-us/library/dd456789(v=vs.110).aspx  -- new
    /// http://channel9.msdn.com/Events/BUILD/BUILD2011/PLAT-581T
    /// 
    /// code.msdn.microsoft.com/windowsapps/HttpClient-sample-55700664/sourcecode?fileId=63906&pathId=720736535 
    /// 
    /// 
    /// </summary>
    public class FactoryService
    {
        static IDataService proxy;
        static ChannelFactory<IDataService> channelFactory;
        private static readonly object syncRoot = new Object();
        static NetTcpBinding tcpBinding = new NetTcpBinding();
        static EndpointAddress endPoint = new EndpointAddress(string.Format("net.tcp://localhost:{0}/Autoservice", 9998));
        public static IDataService CreateProxy()
        {
            lock (syncRoot)
            {
                if (channelFactory != null && channelFactory.State == CommunicationState.Faulted)
                {
                    channelFactory.Abort();
                    channelFactory = null;
                }
                if (channelFactory == null)
                {
                    tcpBinding.MaxReceivedMessageSize = 100000000;
                    channelFactory = new ChannelFactory<IDataService>(tcpBinding, endPoint);
                }

                if (proxy != null && ((IClientChannel)proxy).State == CommunicationState.Faulted)
                {
                    ((IClientChannel)proxy).Abort();
                    proxy = null;
                }
                if (proxy == null)
                {
                    try
                    {
                        proxy = channelFactory.CreateChannel();
                        ((IClientChannel)proxy).Open();
                        ModelCore.MakeToken(proxy);
                        ModelCore.Count++;
                    }
                    catch(Exception ex)
                    {
                        ex.ToString();
                        proxy = null;
                    }
                }
                return proxy;
            }
        }
        
    }
}
