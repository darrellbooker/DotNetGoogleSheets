namespace SampleProject
{
    partial class Form1
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
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lnkAuthUrl = new System.Windows.Forms.LinkLabel();
            this.lblAuthInstructions = new System.Windows.Forms.Label();
            this.txtAccessCode = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(85, 33);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(259, 20);
            this.txtClientID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client Secret";
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(85, 59);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(259, 20);
            this.txtClientSecret.TabIndex = 2;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(368, 96);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "Begin OAuth";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lnkAuthUrl
            // 
            this.lnkAuthUrl.AutoSize = true;
            this.lnkAuthUrl.Location = new System.Drawing.Point(189, 135);
            this.lnkAuthUrl.Name = "lnkAuthUrl";
            this.lnkAuthUrl.Size = new System.Drawing.Size(55, 13);
            this.lnkAuthUrl.TabIndex = 5;
            this.lnkAuthUrl.TabStop = true;
            this.lnkAuthUrl.Text = "linkLabel1";
            this.lnkAuthUrl.Visible = false;
            this.lnkAuthUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAuthUrl_LinkClicked);
            // 
            // lblAuthInstructions
            // 
            this.lblAuthInstructions.Location = new System.Drawing.Point(12, 163);
            this.lblAuthInstructions.Name = "lblAuthInstructions";
            this.lblAuthInstructions.Size = new System.Drawing.Size(431, 43);
            this.lblAuthInstructions.TabIndex = 6;
            this.lblAuthInstructions.Text = "Please visit the URL above to authorize your OAuth request token.  Once that is c" +
    "omplete, type in your access code to continue.";
            this.lblAuthInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAuthInstructions.Visible = false;
            // 
            // txtAccessCode
            // 
            this.txtAccessCode.Location = new System.Drawing.Point(122, 209);
            this.txtAccessCode.Name = "txtAccessCode";
            this.txtAccessCode.Size = new System.Drawing.Size(180, 20);
            this.txtAccessCode.TabIndex = 7;
            this.txtAccessCode.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(182, 250);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 8;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtAccessCode);
            this.Controls.Add(this.lblAuthInstructions);
            this.Controls.Add(this.lnkAuthUrl);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.LinkLabel lnkAuthUrl;
        private System.Windows.Forms.Label lblAuthInstructions;
        private System.Windows.Forms.TextBox txtAccessCode;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button button1;
    }
}

