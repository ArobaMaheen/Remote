using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Simple_RDP_Client
{
    public partial class AddNewForm : Form
    {
        ClientHomeForm homeForm;
        bool computerNameTextBoxClicked = false;
        bool cStringTextBoxClicked = false;

        public AddNewForm(ClientHomeForm h)
        {

            InitializeComponent();
            homeForm = h;
            this.CenterToScreen();
            this.ActiveControl = headingLabel;
            computerNameTextBox.Click += computerNameTextBox_Click;
            connectionStringTextBox.Click += cStringTextBox_Click;
            computerNameTextBox.Enter += computerNameTextBox_Click;
            connectionStringTextBox.Enter += cStringTextBox_Click;
        }
        
        private void computerNameTextBox_Click(object sender, EventArgs e)
        {
            if (!computerNameTextBoxClicked)
            {
                computerNameTextBox.Text = "";
                computerNameTextBoxClicked = true ;
                computerNameTextBox.ForeColor = Color.FromArgb(64,64,64);
            }
        }

        private void cStringTextBox_Click(object sender, EventArgs e)
        {
            if (!cStringTextBoxClicked)
            {
                connectionStringTextBox.Text = "";
                cStringTextBoxClicked = true;
                connectionStringTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            XDocument doc = XDocument.Load("SavedComputers.xml");
            XElement name = new XElement("Name", computerNameTextBox.Text);
            XElement connectionString = new XElement("ConnectionString", connectionStringTextBox.Text);

            doc.Root.Add(name);
            doc.Root.Add(connectionString);
            doc.Save("SavedComputers.xml");
            ListForm listForm = new ListForm(homeForm);
            listForm.Show();
            this.Close();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            homeForm.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            homeForm.textBoxClicked = false;
            homeForm.cStringTextBoxPublic.Text = "Enter String Here";
            homeForm.cStringTextBoxPublic.ForeColor = Color.Gray;
            homeForm.ActiveControl = homeForm.headingLabelPublic;
            this.Close();
        }

    }
}
