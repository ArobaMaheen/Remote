using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDPCOMAPILib;
using AxMSTSCLib;
using System.Runtime.InteropServices;

namespace TCP_to_RDP_Converter
{
    public partial class ServerHomeForm : Form
    {
        public static RDPSession currentSession = null;

        public static void createSession()
        {
            currentSession = new RDPSession();
        }

        public static void Connect(RDPSession session)
        {
            session.OnAttendeeConnected += Incoming;
            session.Open();
        }

        public static void Disconnect(RDPSession session)
        {
            session.Close();
        }

        public static string getConnectionString(RDPSession session, String authString, string group, string password, int clientLimit)
        {
            IRDPSRAPIInvitation invitation = session.Invitations.CreateInvitation(authString, group, password, clientLimit);
            
            return invitation.ConnectionString;
        }

        private static void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }

       
        public ServerHomeForm()
        {
            InitializeComponent();
            this.ActiveControl = headingLabel;
            this.CenterToScreen();
        }

        private void whatsappPicBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.whatsapp.com");
        }

        private void facebookPicBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void gmailPicBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gmail.com");
        }

        private void parentModeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try {
                createSession();
                Connect(currentSession);
                cStringTextBox.Text = getConnectionString(currentSession, "Test", "Group", "", 5);
            }
            catch
            {
                MessageBox.Show("Connection Failed. Check Internet");
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            Disconnect(currentSession);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
