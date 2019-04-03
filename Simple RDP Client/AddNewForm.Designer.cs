namespace Simple_RDP_Client
{
    partial class AddNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewForm));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuCards1 = new ns1.BunifuCards();
            this.closeButton = new ns1.BunifuThinButton2();
            this.saveButton = new ns1.BunifuThinButton2();
            this.cancelButton = new ns1.BunifuThinButton2();
            this.connectionStringTextBox = new ns1.BunifuMaterialTextbox();
            this.computerNameTextBox = new ns1.BunifuMaterialTextbox();
            this.cStringLabel = new ns1.BunifuCustomLabel();
            this.computerNameLabel = new ns1.BunifuCustomLabel();
            this.headingLabel = new ns1.BunifuCustomLabel();
            this.bunifuCards1.SuspendLayout();
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
            this.bunifuCards1.Controls.Add(this.saveButton);
            this.bunifuCards1.Controls.Add(this.cancelButton);
            this.bunifuCards1.Controls.Add(this.connectionStringTextBox);
            this.bunifuCards1.Controls.Add(this.computerNameTextBox);
            this.bunifuCards1.Controls.Add(this.cStringLabel);
            this.bunifuCards1.Controls.Add(this.computerNameLabel);
            this.bunifuCards1.Controls.Add(this.headingLabel);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(2, 1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(797, 449);
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
            this.closeButton.Location = new System.Drawing.Point(764, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 38);
            this.closeButton.TabIndex = 9;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ActiveBorderThickness = 1;
            this.saveButton.ActiveCornerRadius = 20;
            this.saveButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.saveButton.ActiveForecolor = System.Drawing.Color.White;
            this.saveButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.saveButton.IdleBorderThickness = 1;
            this.saveButton.IdleCornerRadius = 20;
            this.saveButton.IdleFillColor = System.Drawing.Color.White;
            this.saveButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.saveButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.saveButton.Location = new System.Drawing.Point(379, 304);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(181, 41);
            this.saveButton.TabIndex = 8;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ActiveBorderThickness = 1;
            this.cancelButton.ActiveCornerRadius = 20;
            this.cancelButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cancelButton.ActiveForecolor = System.Drawing.Color.White;
            this.cancelButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.ButtonText = "Cancel";
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelButton.IdleBorderThickness = 1;
            this.cancelButton.IdleCornerRadius = 20;
            this.cancelButton.IdleFillColor = System.Drawing.Color.White;
            this.cancelButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.cancelButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.cancelButton.Location = new System.Drawing.Point(127, 304);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(181, 41);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.connectionStringTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionStringTextBox.ForeColor = System.Drawing.Color.Silver;
            this.connectionStringTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.connectionStringTextBox.HintText = "";
            this.connectionStringTextBox.isPassword = false;
            this.connectionStringTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.connectionStringTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.connectionStringTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.connectionStringTextBox.LineThickness = 3;
            this.connectionStringTextBox.Location = new System.Drawing.Point(312, 189);
            this.connectionStringTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(278, 41);
            this.connectionStringTextBox.TabIndex = 6;
            this.connectionStringTextBox.Text = "Enter Connection String";
            this.connectionStringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // computerNameTextBox
            // 
            this.computerNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.computerNameTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.computerNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.computerNameTextBox.HintText = "";
            this.computerNameTextBox.isPassword = false;
            this.computerNameTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.computerNameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.computerNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.computerNameTextBox.LineThickness = 3;
            this.computerNameTextBox.Location = new System.Drawing.Point(312, 135);
            this.computerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.computerNameTextBox.Name = "computerNameTextBox";
            this.computerNameTextBox.Size = new System.Drawing.Size(278, 41);
            this.computerNameTextBox.TabIndex = 5;
            this.computerNameTextBox.Text = "Enter Computer\'s Name";
            this.computerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cStringLabel
            // 
            this.cStringLabel.AutoSize = true;
            this.cStringLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cStringLabel.Location = new System.Drawing.Point(108, 206);
            this.cStringLabel.Name = "cStringLabel";
            this.cStringLabel.Size = new System.Drawing.Size(182, 24);
            this.cStringLabel.TabIndex = 4;
            this.cStringLabel.Text = "Connection String:";
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerNameLabel.Location = new System.Drawing.Point(108, 153);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(166, 24);
            this.computerNameLabel.TabIndex = 3;
            this.computerNameLabel.Text = "Computer Name:";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(23, 23);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(366, 44);
            this.headingLabel.TabIndex = 2;
            this.headingLabel.Text = "Add New Computer";
            // 
            // AddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewForm";
            this.Text = "AddNewForm";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCards bunifuCards1;
        private ns1.BunifuCustomLabel headingLabel;
        private ns1.BunifuThinButton2 saveButton;
        private ns1.BunifuThinButton2 cancelButton;
        private ns1.BunifuMaterialTextbox connectionStringTextBox;
        private ns1.BunifuMaterialTextbox computerNameTextBox;
        private ns1.BunifuCustomLabel cStringLabel;
        private ns1.BunifuCustomLabel computerNameLabel;
        private ns1.BunifuThinButton2 closeButton;
    }
}