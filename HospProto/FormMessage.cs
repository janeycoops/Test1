using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospProto
{
    public interface messagerUIHook
    {
        void addMessage(String message);
    }

    public partial class FormMessage : Form, messagerUIHook
    {
        private BaseNurseStation m_bns;
        private BaseMessageSystem m_bms;

        public FormMessage(BaseNurseStation bns, BaseMessageSystem bms, Boolean selectable)
        {
            InitializeComponent();

            m_bns = bns;
            m_bms = bms;
            m_bms.addHook(this);
            txtName.Text = m_bms.title;
            this.Text = m_bms.name;  
          
            if (!selectable)
            {
                chkRegister.Checked = true;
                chkRegister.Enabled = false;
            }
        }

        private void chkRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegister.Checked)
            {
                m_bns.Attach(m_bms);
            }
            else
            {
                m_bns.Detach(m_bms);
            }
        }

        public void addMessage(String message)
        {
            txtMessages.Text += "\n" + message;
            txtMessages.Select(txtMessages.Text.Length, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            m_bns.Detach(m_bms);
            this.Close();
        }
    }
}
