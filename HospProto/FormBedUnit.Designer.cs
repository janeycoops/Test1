namespace HospProto
{
    partial class FormBedUnit
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
            this.chkHeart = new System.Windows.Forms.CheckBox();
            this.chkBloodPresure = new System.Windows.Forms.CheckBox();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkAlarm = new System.Windows.Forms.CheckBox();
            this.chkConnect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkHeart
            // 
            this.chkHeart.AutoSize = true;
            this.chkHeart.Location = new System.Drawing.Point(12, 32);
            this.chkHeart.Name = "chkHeart";
            this.chkHeart.Size = new System.Drawing.Size(78, 17);
            this.chkHeart.TabIndex = 0;
            this.chkHeart.Text = "Heart Rate";
            this.chkHeart.UseVisualStyleBackColor = true;
            this.chkHeart.CheckedChanged += new System.EventHandler(this.chkHeart_CheckedChanged);
            // 
            // chkBloodPresure
            // 
            this.chkBloodPresure.AutoSize = true;
            this.chkBloodPresure.Location = new System.Drawing.Point(12, 55);
            this.chkBloodPresure.Name = "chkBloodPresure";
            this.chkBloodPresure.Size = new System.Drawing.Size(92, 17);
            this.chkBloodPresure.TabIndex = 1;
            this.chkBloodPresure.Text = "Blood Presure";
            this.chkBloodPresure.UseVisualStyleBackColor = true;
            this.chkBloodPresure.CheckedChanged += new System.EventHandler(this.chkBloodPresure_CheckedChanged);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(32, 78);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(229, 148);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkAlarm
            // 
            this.chkAlarm.AutoSize = true;
            this.chkAlarm.Enabled = false;
            this.chkAlarm.Location = new System.Drawing.Point(13, 237);
            this.chkAlarm.Name = "chkAlarm";
            this.chkAlarm.Size = new System.Drawing.Size(52, 17);
            this.chkAlarm.TabIndex = 3;
            this.chkAlarm.Text = "Alarm";
            this.chkAlarm.UseVisualStyleBackColor = true;
            this.chkAlarm.CheckedChanged += new System.EventHandler(this.chkAlarm_CheckedChanged);
            // 
            // chkConnect
            // 
            this.chkConnect.AutoSize = true;
            this.chkConnect.Location = new System.Drawing.Point(12, 9);
            this.chkConnect.Name = "chkConnect";
            this.chkConnect.Size = new System.Drawing.Size(152, 17);
            this.chkConnect.TabIndex = 4;
            this.chkConnect.Text = "Connect to Nurse\'s Station";
            this.chkConnect.UseVisualStyleBackColor = true;
            this.chkConnect.CheckedChanged += new System.EventHandler(this.chkConnect_CheckedChanged);
            // 
            // FormBedUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.chkConnect);
            this.Controls.Add(this.chkAlarm);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.chkBloodPresure);
            this.Controls.Add(this.chkHeart);
            this.Name = "FormBedUnit";
            this.Text = "FormBedUnit1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkHeart;
        private System.Windows.Forms.CheckBox chkBloodPresure;
        private System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkAlarm;
        private System.Windows.Forms.CheckBox chkConnect;
    }
}