namespace Simple_RDP_Client
{
    partial class ListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuCards1 = new ns1.BunifuCards();
            this.backButton = new ns1.BunifuThinButton2();
            this.closeButton = new ns1.BunifuThinButton2();
            this.gradientPanel = new ns1.BunifuGradientPanel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.dummySeperator = new ns1.BunifuSeparator();
            this.deleteButton = new ns1.BunifuThinButton2();
            this.connectButton = new ns1.BunifuThinButton2();
            this.dummyComputerNameLabel = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.headingLabel = new ns1.BunifuCustomLabel();
            this.bunifuCards1.SuspendLayout();
            this.gradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.AutoScroll = true;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.backButton);
            this.bunifuCards1.Controls.Add(this.closeButton);
            this.bunifuCards1.Controls.Add(this.gradientPanel);
            this.bunifuCards1.Controls.Add(this.headingLabel);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1, 1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(795, 453);
            this.bunifuCards1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.ActiveBorderThickness = 1;
            this.backButton.ActiveCornerRadius = 20;
            this.backButton.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.backButton.ActiveForecolor = System.Drawing.Color.White;
            this.backButton.ActiveLineColor = System.Drawing.Color.Red;
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.ButtonText = " <";
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Red;
            this.backButton.IdleBorderThickness = 1;
            this.backButton.IdleCornerRadius = 20;
            this.backButton.IdleFillColor = System.Drawing.Color.White;
            this.backButton.IdleForecolor = System.Drawing.Color.Chocolate;
            this.backButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.backButton.Location = new System.Drawing.Point(733, 5);
            this.backButton.Margin = new System.Windows.Forms.Padding(5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(28, 38);
            this.backButton.TabIndex = 11;
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.closeButton.Location = new System.Drawing.Point(762, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 38);
            this.closeButton.TabIndex = 10;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // gradientPanel
            // 
            this.gradientPanel.AutoScroll = true;
            this.gradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanel.BackgroundImage")));
            this.gradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel.Controls.Add(this.bunifuCustomLabel4);
            this.gradientPanel.Controls.Add(this.dummySeperator);
            this.gradientPanel.Controls.Add(this.deleteButton);
            this.gradientPanel.Controls.Add(this.connectButton);
            this.gradientPanel.Controls.Add(this.dummyComputerNameLabel);
            this.gradientPanel.Controls.Add(this.bunifuCustomLabel2);
            this.gradientPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.gradientPanel.GradientBottomRight = System.Drawing.Color.White;
            this.gradientPanel.GradientTopLeft = System.Drawing.Color.White;
            this.gradientPanel.GradientTopRight = System.Drawing.Color.White;
            this.gradientPanel.Location = new System.Drawing.Point(19, 77);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Quality = 10;
            this.gradientPanel.Size = new System.Drawing.Size(756, 360);
            this.gradientPanel.TabIndex = 4;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(554, 10);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(89, 24);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Options";
            // 
            // dummySeperator
            // 
            this.dummySeperator.BackColor = System.Drawing.Color.Transparent;
            this.dummySeperator.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dummySeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dummySeperator.LineThickness = 1;
            this.dummySeperator.Location = new System.Drawing.Point(3, 103);
            this.dummySeperator.Name = "dummySeperator";
            this.dummySeperator.Size = new System.Drawing.Size(753, 10);
            this.dummySeperator.TabIndex = 9;
            this.dummySeperator.Transparency = 255;
            this.dummySeperator.Vertical = false;
            // 
            // deleteButton
            // 
            this.deleteButton.ActiveBorderThickness = 1;
            this.deleteButton.ActiveCornerRadius = 20;
            this.deleteButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.deleteButton.ActiveForecolor = System.Drawing.Color.White;
            this.deleteButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.ButtonText = "Delete";
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteButton.IdleBorderThickness = 1;
            this.deleteButton.IdleCornerRadius = 20;
            this.deleteButton.IdleFillColor = System.Drawing.Color.White;
            this.deleteButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.deleteButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.deleteButton.Location = new System.Drawing.Point(609, 61);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(124, 41);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectButton
            // 
            this.connectButton.ActiveBorderThickness = 1;
            this.connectButton.ActiveCornerRadius = 20;
            this.connectButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.connectButton.ActiveForecolor = System.Drawing.Color.White;
            this.connectButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.connectButton.BackColor = System.Drawing.Color.White;
            this.connectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectButton.BackgroundImage")));
            this.connectButton.ButtonText = "Connect";
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.connectButton.IdleBorderThickness = 1;
            this.connectButton.IdleCornerRadius = 20;
            this.connectButton.IdleFillColor = System.Drawing.Color.White;
            this.connectButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.connectButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.connectButton.Location = new System.Drawing.Point(465, 61);
            this.connectButton.Margin = new System.Windows.Forms.Padding(5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(124, 41);
            this.connectButton.TabIndex = 7;
            this.connectButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dummyComputerNameLabel
            // 
            this.dummyComputerNameLabel.AutoSize = true;
            this.dummyComputerNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dummyComputerNameLabel.Location = new System.Drawing.Point(93, 69);
            this.dummyComputerNameLabel.Name = "dummyComputerNameLabel";
            this.dummyComputerNameLabel.Size = new System.Drawing.Size(87, 24);
            this.dummyComputerNameLabel.TabIndex = 6;
            this.dummyComputerNameLabel.Text = "Ramsha";
            this.dummyComputerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(173, 24);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Computer Name";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(11, 18);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(344, 44);
            this.headingLabel.TabIndex = 3;
            this.headingLabel.Text = "List Of Computers";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 454);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListForm";
            this.Text = "List";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.gradientPanel.ResumeLayout(false);
            this.gradientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCards bunifuCards1;
        private ns1.BunifuCustomLabel headingLabel;
        private ns1.BunifuGradientPanel gradientPanel;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuSeparator dummySeperator;
        private ns1.BunifuThinButton2 deleteButton;
        private ns1.BunifuThinButton2 connectButton;
        private ns1.BunifuCustomLabel dummyComputerNameLabel;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuThinButton2 closeButton;
        private ns1.BunifuThinButton2 backButton;
    }
}