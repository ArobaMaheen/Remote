namespace TCP_to_RDP_Converter
{
    partial class ServerHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerHomeForm));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuCards1 = new ns1.BunifuCards();
            this.closeButton = new ns1.BunifuThinButton2();
            this.parentModeButton = new ns1.BunifuTileButton();
            this.gmailPicBox = new System.Windows.Forms.PictureBox();
            this.facebookPicBox = new System.Windows.Forms.PictureBox();
            this.whatsappPicBox = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.disconnectButton = new ns1.BunifuFlatButton();
            this.connectButton = new ns1.BunifuFlatButton();
            this.cStringTextBox = new ns1.BunifuMetroTextbox();
            this.cStringLabel = new ns1.BunifuCustomLabel();
            this.headingLabel = new ns1.BunifuCustomLabel();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gmailPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whatsappPicBox)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuCards1.Controls.Add(this.parentModeButton);
            this.bunifuCards1.Controls.Add(this.gmailPicBox);
            this.bunifuCards1.Controls.Add(this.facebookPicBox);
            this.bunifuCards1.Controls.Add(this.whatsappPicBox);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.disconnectButton);
            this.bunifuCards1.Controls.Add(this.connectButton);
            this.bunifuCards1.Controls.Add(this.cStringTextBox);
            this.bunifuCards1.Controls.Add(this.cStringLabel);
            this.bunifuCards1.Controls.Add(this.headingLabel);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(738, 444);
            this.bunifuCards1.TabIndex = 0;
         
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
            this.closeButton.Location = new System.Drawing.Point(705, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 38);
            this.closeButton.TabIndex = 14;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // parentModeButton
            // 
            this.parentModeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.parentModeButton.color = System.Drawing.Color.SeaGreen;
            this.parentModeButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.parentModeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parentModeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.parentModeButton.ForeColor = System.Drawing.Color.White;
            this.parentModeButton.Image = ((System.Drawing.Image)(resources.GetObject("parentModeButton.Image")));
            this.parentModeButton.ImagePosition = 20;
            this.parentModeButton.ImageZoom = 50;
            this.parentModeButton.LabelPosition = 41;
            this.parentModeButton.LabelText = "Parent Mode";
            this.parentModeButton.Location = new System.Drawing.Point(518, 225);
            this.parentModeButton.Margin = new System.Windows.Forms.Padding(6);
            this.parentModeButton.Name = "parentModeButton";
            this.parentModeButton.Size = new System.Drawing.Size(179, 162);
            this.parentModeButton.TabIndex = 13;
            this.parentModeButton.Click += new System.EventHandler(this.parentModeButton_Click);
            // 
            // gmailPicBox
            // 
            this.gmailPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gmailPicBox.Image = global::TCP_to_RDP_Converter.Properties.Resources.gmail;
            this.gmailPicBox.Location = new System.Drawing.Point(664, 128);
            this.gmailPicBox.Name = "gmailPicBox";
            this.gmailPicBox.Size = new System.Drawing.Size(46, 38);
            this.gmailPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gmailPicBox.TabIndex = 12;
            this.gmailPicBox.TabStop = false;
            this.gmailPicBox.Click += new System.EventHandler(this.gmailPicBox_Click);
            // 
            // facebookPicBox
            // 
            this.facebookPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebookPicBox.Image = global::TCP_to_RDP_Converter.Properties.Resources.facebook_circle_512;
            this.facebookPicBox.Location = new System.Drawing.Point(591, 128);
            this.facebookPicBox.Name = "facebookPicBox";
            this.facebookPicBox.Size = new System.Drawing.Size(39, 38);
            this.facebookPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookPicBox.TabIndex = 11;
            this.facebookPicBox.TabStop = false;
            this.facebookPicBox.Click += new System.EventHandler(this.facebookPicBox_Click);
            // 
            // whatsappPicBox
            // 
            this.whatsappPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whatsappPicBox.Image = global::TCP_to_RDP_Converter.Properties.Resources._134937;
            this.whatsappPicBox.Location = new System.Drawing.Point(517, 127);
            this.whatsappPicBox.Name = "whatsappPicBox";
            this.whatsappPicBox.Size = new System.Drawing.Size(42, 39);
            this.whatsappPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.whatsappPicBox.TabIndex = 10;
            this.whatsappPicBox.TabStop = false;
            this.whatsappPicBox.Click += new System.EventHandler(this.whatsappPicBox_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(561, 91);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(99, 24);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Share On";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.disconnectButton.BackColor = System.Drawing.Color.Firebrick;
            this.disconnectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.disconnectButton.BorderRadius = 0;
            this.disconnectButton.ButtonText = "Disconnect";
            this.disconnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnectButton.DisabledColor = System.Drawing.Color.Gray;
            this.disconnectButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Iconcolor = System.Drawing.Color.Transparent;
            this.disconnectButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("disconnectButton.Iconimage")));
            this.disconnectButton.Iconimage_right = null;
            this.disconnectButton.Iconimage_right_Selected = null;
            this.disconnectButton.Iconimage_Selected = null;
            this.disconnectButton.IconMarginLeft = 0;
            this.disconnectButton.IconMarginRight = 0;
            this.disconnectButton.IconRightVisible = true;
            this.disconnectButton.IconRightZoom = 0D;
            this.disconnectButton.IconVisible = true;
            this.disconnectButton.IconZoom = 40D;
            this.disconnectButton.IsTab = false;
            this.disconnectButton.Location = new System.Drawing.Point(248, 231);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Normalcolor = System.Drawing.Color.Firebrick;
            this.disconnectButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.disconnectButton.OnHoverTextColor = System.Drawing.Color.White;
            this.disconnectButton.selected = true;
            this.disconnectButton.Size = new System.Drawing.Size(178, 58);
            this.disconnectButton.TabIndex = 8;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disconnectButton.Textcolor = System.Drawing.Color.White;
            this.disconnectButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
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
            this.connectButton.Location = new System.Drawing.Point(49, 231);
            this.connectButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.connectButton.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.connectButton.OnHoverTextColor = System.Drawing.Color.White;
            this.connectButton.selected = false;
            this.connectButton.Size = new System.Drawing.Size(178, 58);
            this.connectButton.TabIndex = 7;
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
            this.cStringTextBox.Location = new System.Drawing.Point(234, 136);
            this.cStringTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cStringTextBox.Name = "cStringTextBox";
            this.cStringTextBox.Size = new System.Drawing.Size(192, 44);
            this.cStringTextBox.TabIndex = 6;
            this.cStringTextBox.Text = "Click Connect";
            this.cStringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cStringLabel
            // 
            this.cStringLabel.AutoSize = true;
            this.cStringLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cStringLabel.Location = new System.Drawing.Point(45, 146);
            this.cStringLabel.Name = "cStringLabel";
            this.cStringLabel.Size = new System.Drawing.Size(182, 24);
            this.cStringLabel.TabIndex = 5;
            this.cStringLabel.Text = "Connection String:";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(22, 20);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(281, 56);
            this.headingLabel.TabIndex = 2;
            this.headingLabel.Text = "TeamShare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 446);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gmailPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whatsappPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCards bunifuCards1;
        private ns1.BunifuFlatButton disconnectButton;
        private ns1.BunifuFlatButton connectButton;
        private ns1.BunifuMetroTextbox cStringTextBox;
        private ns1.BunifuCustomLabel cStringLabel;
        private ns1.BunifuCustomLabel headingLabel;
        private System.Windows.Forms.PictureBox whatsappPicBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox facebookPicBox;
        private System.Windows.Forms.PictureBox gmailPicBox;
        private ns1.BunifuTileButton parentModeButton;
        private ns1.BunifuThinButton2 closeButton;
    }
}

