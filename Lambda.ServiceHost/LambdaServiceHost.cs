using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.ServiceHost
{
    public partial class LambdaServiceHost : ServiceBase
    {
        public LambdaServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Lambda.Host.LambdaHost.Instance.Open();
        }

        protected override void OnStop()
        {
            Lambda.Host.LambdaHost.Instance.Close();
        }
    }
}
