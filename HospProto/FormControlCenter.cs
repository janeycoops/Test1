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
    public partial class FormControlCenter : Form
    {
        private static Random rnd =  new Random();
        private BaseNurseStation m_bns;
        public FormControlCenter()
        {
            InitializeComponent();

            // Intialize the nurse's station
            m_bns = new NurseStation("Nurse Station Zebra");

            // Start up management console  
            ManagementRecordSystem mrs = new ManagementRecordSystem("Big Brother");
            FormMessage fm = new FormMessage(m_bns, mrs, false);
            
            fm.Show();
        }

        private void btnAddBedUnit_Click(object sender, EventArgs e)
        {
            String bedID = "Bed#";
            if (csharpExamples.InputBox("Bed ID", "Enter Bed ID:", ref bedID) == DialogResult.OK)
            {
                FormBedUnit bu = new FormBedUnit(bedID, m_bns);
                bu.Show();
            }
        }

        public static int getRndInt(int min, int max)
        {
            return rnd.Next(min, max);
        }

        private void butPager_Click(object sender, EventArgs e)
        {
            String userName = "Name";
            String pagerNum = "1234";
            if (csharpExamples.InputBox("Pager user name", "Enter Pager user name:", ref userName) == DialogResult.OK)
            {
                if (csharpExamples.InputBox("Pager number", "Enter Pager number:", ref pagerNum) == DialogResult.OK)
                {
                    Pager pager = new Pager(userName, pagerNum);
                    FormMessage mes = new FormMessage(m_bns, pager,true);
                    mes.Show();
                }
            }
        }

        private void butEmail_Click(object sender, EventArgs e)
        {
            String userName = "Name";
            String email = "1234";
            if (csharpExamples.InputBox("E-Mail user name", "Enter username:", ref userName) == DialogResult.OK)
            {
                if (csharpExamples.InputBox("E-Mail Address", "Enter e-mail address:", ref email) == DialogResult.OK)
                {
                    Email emailMessager = new Email(userName, email);
                    FormMessage mes = new FormMessage(m_bns, emailMessager, true);
                    mes.Show();
                }
            }
        }

        private void butPhone_Click(object sender, EventArgs e)
        {
            String userName = "Name";
            String phoneNum = "1234";
            if (csharpExamples.InputBox("Phone user name", "Enter username:", ref userName) == DialogResult.OK)
            {
                if (csharpExamples.InputBox("Phone Number", "Enter phone number:", ref phoneNum) == DialogResult.OK)
                {
                    MobilePhone emailMessager = new MobilePhone(userName, phoneNum);
                    FormMessage mes = new FormMessage(m_bns, emailMessager, true);
                    mes.Show();
                }
            }
        }
    }
}
