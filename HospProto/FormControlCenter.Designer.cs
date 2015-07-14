namespace HospProto
{
    partial class FormControlCenter
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
            this.btnAddBedUnit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butPhone = new System.Windows.Forms.Button();
            this.butEmail = new System.Windows.Forms.Button();
            this.butPager = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBedUnit
            // 
            this.btnAddBedUnit.Location = new System.Drawing.Point(182, 12);
            this.btnAddBedUnit.Name = "btnAddBedUnit";
            this.btnAddBedUnit.Size = new System.Drawing.Size(75, 23);
            this.btnAddBedUnit.TabIndex = 0;
            this.btnAddBedUnit.Text = "Add Bed Unit";
            this.btnAddBedUnit.UseVisualStyleBackColor = true;
            this.btnAddBedUnit.Click += new System.EventHandler(this.btnAddBedUnit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butPhone);
            this.groupBox1.Controls.Add(this.butEmail);
            this.groupBox1.Controls.Add(this.butPager);
            this.groupBox1.Location = new System.Drawing.Point(11, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitors";
            // 
            // butPhone
            // 
            this.butPhone.Location = new System.Drawing.Point(171, 18);
            this.butPhone.Name = "butPhone";
            this.butPhone.Size = new System.Drawing.Size(75, 23);
            this.butPhone.TabIndex = 2;
            this.butPhone.Text = "new mobile";
            this.butPhone.UseVisualStyleBackColor = true;
            this.butPhone.Click += new System.EventHandler(this.butPhone_Click);
            // 
            // butEmail
            // 
            this.butEmail.Location = new System.Drawing.Point(89, 19);
            this.butEmail.Name = "butEmail";
            this.butEmail.Size = new System.Drawing.Size(75, 23);
            this.butEmail.TabIndex = 1;
            this.butEmail.Text = "new email";
            this.butEmail.UseVisualStyleBackColor = true;
            this.butEmail.Click += new System.EventHandler(this.butEmail_Click);
            // 
            // butPager
            // 
            this.butPager.Location = new System.Drawing.Point(7, 20);
            this.butPager.Name = "butPager";
            this.butPager.Size = new System.Drawing.Size(75, 23);
            this.butPager.TabIndex = 0;
            this.butPager.Text = "new pager";
            this.butPager.UseVisualStyleBackColor = true;
            this.butPager.Click += new System.EventHandler(this.butPager_Click);
            // 
            // FormControlCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddBedUnit);
            this.Name = "FormControlCenter";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBedUnit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butPhone;
        private System.Windows.Forms.Button butEmail;
        private System.Windows.Forms.Button butPager;
    }
}

