namespace Simple_RDP_Client
{
    partial class ClientHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientHomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.axRDPViewer = new AxRDPCOMAPILib.AxRDPViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuCards1 = new ns1.BunifuCards();
            this.closeButton = new ns1.BunifuThinButton2();
            this.addNewButton = new ns1.BunifuTileButton();
            this.listButton = new ns1.BunifuTileButton();
            this.connectButton = new ns1.BunifuFlatButton();
            this.cStringTextBox = new ns1.BunifuMetroTextbox();
            this.cStringLabel = new ns1.BunifuCustomLabel();
            this.headingLabel = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String:";
            // 
            // axRDPViewer
            // 
            this.axRDPViewer.Enabled = true;
            this.axRDPViewer.Location = new System.Drawing.Point(98, 12);
            this.axRDPViewer.Name = "axRDPViewer";
            this.axRDPViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRDPViewer.OcxState")));
            this.axRDPViewer.Size = new System.Drawing.Size(192, 192);
            this.axRDPViewer.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(89, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 133);
            this.panel1.TabIndex = 7;
            this.panel1.UseWaitCursor = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.closeButton);
            this.bunifuCards1.Controls.Add(this.addNewButton);
            this.bunifuCards1.Controls.Add(this.listButton);
            this.bunifuCards1.Controls.Add(this.connectButton);
            this.bunifuCards1.Controls.Add(this.cStringTextBox);
            this.bunifuCards1.Controls.Add(this.cStringLabel);
            this.bunifuCards1.Controls.Add(this.headingLabel);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(799, 443);
            this.bunifuCards1.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.ActiveBorderThickness = 1;
            this.closeButton.ActiveCornerRadius = 20;
            this.closeButton.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.closeButton.ActiveForecolor = System.Drawing.Color.White;
            this.closeButton.ActiveLineColor = System.Drawing.Color.Red;
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.ButtonText = " X";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.IdleBorderThickness = 1;
            this.closeButton.IdleCornerRadius = 20;
            this.closeButton.IdleFillColor = System.Drawing.Color.White;
            this.closeButton.IdleForecolor = System.Drawing.Color.Red;
            this.closeButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.closeButton.Location = new System.Drawing.Point(766, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 38);
            this.closeButton.TabIndex = 10;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.Tomato;
            this.addNewButton.color = System.Drawing.Color.Tomato;
            this.addNewButton.colorActive = System.Drawing.Color.Salmon;
            this.addNewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.addNewButton.ForeColor = System.Drawing.Color.White;
            this.addNewButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewButton.Image")));
            this.addNewButton.ImagePosition = 20;
            this.addNewButton.ImageZoom = 50;
            this.addNewButton.LabelPosition = 41;
            this.addNewButton.LabelText = "Add New";
            this.addNewButton.Location = new System.Drawing.Point(605, 219);
            this.addNewButton.Margin = new System.Windows.Forms.Padding(6);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(109, 122);
            this.addNewButton.TabIndex = 6;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.Color.Tomato;
            this.listButton.color = System.Drawing.Color.Tomato;
            this.listButton.colorActive = System.Drawing.Color.Salmon;
            this.listButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.listButton.ForeColor = System.Drawing.Color.White;
            this.listButton.Image = ((System.Drawing.Image)(resources.GetObject("listButton.Image")));
            this.listButton.ImagePosition = 20;
            this.listButton.ImageZoom = 50;
            this.listButton.LabelPosition = 41;
            this.listButton.LabelText = "List";
            this.listButton.Location = new System.Drawing.Point(605, 68);
            this.listButton.Margin = new System.Windows.Forms.Padding(6);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(109, 113);
            this.listButton.TabIndex = 5;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.connectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectButton.BorderRadius = 0;
            this.connectButton.ButtonText = "Connect";
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.DisabledColor = System.Drawing.Color.Gray;
            this.connectButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Iconcolor = System.Drawing.Color.Transparent;
            this.connectButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("connectButton.Iconimage")));
            this.connectButton.Iconimage_right = null;
            this.connectButton.Iconimage_right_Selected = null;
            this.connectButton.Iconimage_Selected = null;
            this.connectButton.IconMarginLeft = 0;
            this.connectButton.IconMarginRight = 0;
            this.connectButton.IconRightVisible = true;
            this.connectButton.IconRightZoom = 0D;
            this.connectButton.IconVisible = true;
            this.connectButton.IconZoom = 90D;
            this.connectButton.IsTab = false;
            this.connectButton.Location = new System.Drawing.Point(138, 234);
            this.connectButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.connectButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.connectButton.OnHoverTextColor = System.Drawing.Color.White;
            this.connectButton.selected = false;
            this.connectButton.Size = new System.Drawing.Size(199, 58);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectButton.Textcolor = System.Drawing.Color.White;
            this.connectButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // cStringTextBox
            // 
            this.cStringTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.cStringTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cStringTextBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.cStringTextBox.BorderThickness = 3;
            this.cStringTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cStringTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cStringTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cStringTextBox.isPassword = false;
            this.cStringTextBox.Location = new System.Drawing.Point(228, 137);
            this.cStringTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cStringTextBox.Name = "cStringTextBox";
            this.cStringTextBox.Size = new System.Drawing.Size(192, 44);
            this.cStringTextBox.TabIndex = 3;
            this.cStringTextBox.Text = "Enter String Here";
            this.cStringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cStringLabel
            // 
            this.cStringLabel.AutoSize = true;
            this.cStringLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cStringLabel.Location = new System.Drawing.Point(39, 147);
            this.cStringLabel.Name = "cStringLabel";
            this.cStringLabel.Size = new System.Drawing.Size(182, 24);
            this.cStringLabel.TabIndex = 2;
            this.cStringLabel.Text = "Connection String:";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(33, 25);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(281, 56);
            this.headingLabel.TabIndex = 1;
            this.headingLabel.Text = "TeamShare";
            // 
            // ClientHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axRDPViewer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientHomeForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AxRDPCOMAPILib.AxRDPViewer axRDPViewer;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCards bunifuCards1;
        private ns1.BunifuFlatButton connectButton;
        private ns1.BunifuMetroTextbox cStringTextBox;
        private ns1.BunifuCustomLabel cStringLabel;
        private ns1.BunifuCustomLabel headingLabel;
        private ns1.BunifuTileButton addNewButton;
        private ns1.BunifuTileButton listButton;
        private ns1.BunifuThinButton2 closeButton;
    }
}