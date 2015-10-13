using GlsTestApi.Api.Gls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlsTestApi
{
    public partial class Form1 : Form
    {
        public Ade2PortTypeClient client;
        private cSession cSession;


        public string apiUrl = "https://ade-test.gls-poland.com/adeplus/pm1/ade_webapi2.php";
        public Form1()
        {
            client = new Api.Gls.Ade2PortTypeClient(
                new SoapBinding(apiUrl.StartsWith("https")),
                new EndpointAddress(apiUrl)
                );
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            client.Open();
            InitializeComponent();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is FaultException)
            {
                FaultException fe = e.ExceptionObject as FaultException;
                ShowFaultException(fe);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            client.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cSession = client.adeLogin(txtLogin.Text, txtPassword.Text);
                txtSession.Text = cSession.session;
                grpStep2.Enabled = true;
                grpStepX.Enabled = true;
            }
            catch (FaultException fe)
            {
                txtSession.Text = fe.Code.Name;
                ShowFaultException(fe);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                cSession = client.adeLogout(cSession.session);
                txtSession.Text = "";
                grpStep2.Enabled = false;
                grpStepX.Enabled = false;
            }
            catch (FaultException fe) { ShowFaultException(fe); }

        }

        private void btnMakeConsign_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<cParcel> parcels = new List<cParcel>();
            float consignWeight = 0;

            // making parcels
            for (int i = 1; i < numCntParcels.Value + 1; i++)
            {
                cParcel parcel = new cParcel()
                {
                    weightSpecified = true, // mandatory to use weight 
                    weight = (float)rnd.Next(100, 3000) / 100 // mandatory field
                };

                consignWeight += parcel.weight;
                parcels.Add(parcel);
            }

            // making consignment
            cConsign cConsig = new cConsign()
            {
                parcels = parcels.ToArray(),
                date = DateTime.Today,
                rcity = "Wroclaw",
                rcountry = "PL",
                references = "123",
                rname1 = "Name1",
                rname2 = "Name2",
                rcontact = "Contact Person",
                rphone = "+48601601601",
                rstreet = "Street 1/2",
                rzipcode = "51001"
            };

            try
            {
                cID cid = client.adePreparingBox_Insert(cSession.session, cConsig); //sending consign
                txtID.Text = cid.id.ToString();
            }
            catch (FaultException fe)
            {
                txtID.Text = fe.Code.Name;
                ShowFaultException(fe);
            }

        }

        public void ShowFaultException(FaultException fe)
        {
            MessageBox.Show(string.Format("Code: {0}\nMessage: {1}", fe.Code.Name, fe.Message), "FaultException", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
