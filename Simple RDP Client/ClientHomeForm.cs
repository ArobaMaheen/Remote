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
    public partial class ClientHomeForm : Form
    {

        public bool textBoxClicked = false;
        public ns1.BunifuMetroTextbox cStringTextBoxPublic;
        public ns1.BunifuCustomLabel headingLabelPublic;

        public ClientHomeForm()
        {
            
            InitializeComponent();
            this.CenterToScreen();
            cStringTextBox.Click += cStringTextBox_Click;
            cStringTextBox.MouseDown += cStringTextBox_Click;
            cStringTextBox.Enter += cStringTextBox_Click;
            cStringTextBoxPublic = cStringTextBox;
            headingLabelPublic = headingLabel;

        }

        private void cStringTextBox_Click(object sender, EventArgs e)
        {
            if (!textBoxClicked)
            {
                cStringTextBox.Text = "";
                textBoxClicked = true;
                cStringTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        public void Connect(string cString)
        {
            AxRDPCOMAPILib.AxRDPViewer displayy = new AxRDPCOMAPILib.AxRDPViewer();
           displayy.Enabled = true;
            displayy.Location = new System.Drawing.Point(98, 12);
            displayy.Name = "axRDPViewer";

            displayy.Size = new System.Drawing.Size(192, 192);
            displayy.TabIndex = 6;
            displayy.Enabled = true;
            ((System.ComponentModel.ISupportInitialize)(displayy)).BeginInit();
            displayy.OcxState = ((System.Windows.Forms.AxHost.State)(new System.ComponentModel.ComponentResourceManager(typeof(ClientHomeForm)).GetObject("axRDPViewer.OcxState")));
            this.Controls.Add(displayy);
            ((System.ComponentModel.ISupportInitialize)(displayy)).EndInit();

            displayy.Connect(cString, "", "");
            displayy.OnConnectionAuthenticated += Display_OnConnectionAuthenticated;
            displayy.OnConnectionFailed += Display_OnConnectionFailed;

        }

        private void Display_OnConnectionFailed(object sender, EventArgs e)
        {
            MessageBox.Show("Unable to Connect");
        }

        private void Display_OnConnectionAuthenticated(object sender, EventArgs e)
        {

            DisplayForm f1 = new DisplayForm(cStringTextBox.Text);
            f1.StartPosition = FormStartPosition.WindowsDefaultBounds;
            f1.Parent = null;
            f1.WindowState = FormWindowState.Maximized;
            f1.Show();

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connect(cStringTextBox.Text);

            }
            catch (Exception ee)
            {
                MessageBox.Show("Enter a valid connection String");
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddNewForm addForm = new AddNewForm(this);
            addForm.Show();
            this.Hide();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm(this);
            listForm.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
