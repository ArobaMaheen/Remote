using AxRDPCOMAPILib;
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
    public partial class ListForm : Form
    {
        
        ClientHomeForm homeForm;
        public int labelY = 69;
        int buttY = 61;
        Font computerNameFont;
        Size connectButtonSize;
        Size seperatorSize;
        int seperatorYPosition;
        Color seperatorColor;
        string currentConnectionString;

        public ListForm(ClientHomeForm h)
        {
            InitializeComponent();
            homeForm = h;
            this.CenterToScreen();
        }

       
        private void ListForm_Load(object sender, EventArgs e)
        {
            computerNameFont = dummyComputerNameLabel.Font;
            connectButtonSize = connectButton.Size;
            seperatorSize = dummySeperator.Size;
            seperatorYPosition = dummySeperator.Location.Y;
            seperatorColor = dummySeperator.LineColor;

            deleteButton.Dispose();
            connectButton.Dispose();
            dummySeperator.Dispose();


            XmlTextReader textReader = new XmlTextReader("SavedComputers.xml");
            string name = "";
            string connString = "";
            while (textReader.Read())
            {

                if (textReader.NodeType == XmlNodeType.Element)
                {
                    if (textReader.LocalName.Equals("Name"))
                    {
                        name = textReader.ReadString();
                    }

                    if (textReader.LocalName.Equals("ConnectionString"))
                    {
                        connString = textReader.ReadString();
                        summonLabel(name, connString);
                    }
                    
                }
            }

            textReader.Close();
            
        }
        
        public void summonLabel(string computerName, String connString)
        {
            int x = 93;
            int y = labelY;
            Label l = new Label();
            l.Text = computerName;
            l.TextAlign = ContentAlignment.TopCenter;
            l.Location = new Point((int)x, (int)y);
            l.Font = computerNameFont;
            dummyComputerNameLabel.Dispose();
            l.Parent = gradientPanel;
            labelY += 60;
            ns1.BunifuThinButton2 summonedConnectButton = new ns1.BunifuThinButton2();
            summonedConnectButton.ButtonText = "Connect";
            summonedConnectButton.Location = new Point(465, buttY);
            summonedConnectButton.Size = connectButtonSize;
            summonedConnectButton.Parent = gradientPanel;

            ns1.BunifuThinButton2 summonedDeleteButton = new ns1.BunifuThinButton2();
            summonedDeleteButton.ButtonText = "Delete";
            summonedDeleteButton.Location = new Point(609, buttY);
            summonedDeleteButton.Size = connectButtonSize;
            summonedDeleteButton.Parent = gradientPanel;
            buttY += 60;
            summonedConnectButton.Click += (sender, EventArgs) => { connectButton_Click(sender, EventArgs, connString); };
            summonedDeleteButton.Click += (sender, EventArgs) => { deleteButton_Click(sender, EventArgs, connString,computerName); };

            ns1.BunifuSeparator seperator = new ns1.BunifuSeparator();
            seperator.Size = seperatorSize;
            seperator.Location = new Point(3, seperatorYPosition);
            seperatorYPosition += 60;
            seperator.Parent = gradientPanel;
            seperator.LineColor = seperatorColor;

        }

        private void deleteButton_Click(object sender, EventArgs e, String con,String text)
        {
            XDocument xmlDoc = XDocument.Load("SavedComputers.xml");
            var elementsToDelete = from ele in xmlDoc.Elements("Computers").Elements("Name")
                                   where ele != null && ele.Value.Equals(text)
                                   select ele;

            foreach (var ee in elementsToDelete)
            {
                ee.Remove();

            }

            xmlDoc.Save("SavedComputers.xml");

            XDocument xmlDoc2 = XDocument.Load("SavedComputers.xml");
            var elementsToDeletee = from ele in xmlDoc2.Elements("Computers").Elements("ConnectionString")
                                   where ele != null && ele.Value.Equals(con)
                                   select ele;

            foreach (var ee in elementsToDeletee)
            {
                ee.Remove();
            }
            xmlDoc2.Save("SavedComputers.xml");
            ListForm l = new ListForm(homeForm);
            l.Show();
            this.Close();
        }

        private void connectButton_Click(object sender, EventArgs e,String connString)
        {
           
            try
            {
                Connect(connString);
                currentConnectionString = connString;

            }
            catch (Exception)
            {
                MessageBox.Show("Not a Valid Connection String");
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
           
            DisplayForm f1 = new DisplayForm(currentConnectionString);
            f1.StartPosition = FormStartPosition.WindowsDefaultBounds;
            f1.Parent = null;
            f1.WindowState = FormWindowState.Maximized;
            f1.Show();
           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            homeForm.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
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
