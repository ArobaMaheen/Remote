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
using AxRDPCOMAPILib;

namespace Simple_RDP_Client
{
    public partial class DisplayForm : Form
    {
        public DisplayForm(String conString)
        {
            InitializeComponent();
            Connect(conString, this.axRDPViewer);
        }

        public static void Connect(string invitation, AxRDPViewer display)
        {
            display.Connect(invitation, "", "");
            display.SmartSizing = true;
        }

    }
}
