using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace GlsTestApi
{
    public class SoapBinding : BasicHttpBinding
    {
        public SoapBinding(bool https)
            : base ()
        {
            this.SendTimeout = TimeSpan.FromMinutes(1);
            this.OpenTimeout = TimeSpan.FromMinutes(1);
            this.CloseTimeout = TimeSpan.FromMinutes(1);
            this.ReceiveTimeout = TimeSpan.FromMinutes(10);
            this.MaxReceivedMessageSize = 1024 * 1024 * 10;
            this.ReaderQuotas.MaxStringContentLength = 1024 * 1024 * 10;
            if (https)
                this.Security.Mode = BasicHttpSecurityMode.Transport;
        }
    }
}
