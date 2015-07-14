namespace HospProto
{
    partial class FormMessage
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
            this.chkRegister = new System.Windows.Forms.CheckBox();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkRegister
            // 
            this.chkRegister.AutoSize = true;
            this.chkRegister.Location = new System.Drawing.Point(12, 114);
            this.chkRegister.Name = "chkRegister";
            this.chkRegister.Size = new System.Drawing.Size(164, 17);
            this.chkRegister.TabIndex = 0;
            this.chkRegister.Text = "Register With Nurse\'s Station";
            this.chkRegister.UseVisualStyleBackColor = true;
            this.chkRegister.CheckedChanged += new System.EventHandler(this.chkRegister_CheckedChanged);
            // 
            // txtMessages
            // 
            this.txtMessages.Enabled = false;
            this.txtMessages.Location = new System.Drawing.Point(12, 137);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(277, 267);
            this.txtMessages.TabIndex = 1;
            this.txtMessages.Text = "";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(7, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 26);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "label1";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 457);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.chkRegister);
            this.Name = "FormMessage";
            this.Text = "FormMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRegister;
        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button btnClose;
    }
}