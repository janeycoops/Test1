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
    public interface BedUnitAlarmHook
    {
        void setUIAlarm();
    }

    public partial class FormBedUnit : Form, BedUnitAlarmHook
    {
        private Component m_bu;
        private HeartMonitor m_hm;
        private Boolean m_heartRate;
        private BPMonitor m_bpm;
        private Boolean m_bloodPresure;
        private BaseNurseStation m_bns;

        public FormBedUnit(String bedID, BaseNurseStation bns)
        {
            InitializeComponent();

            this.Text = bedID;

            // Create Bedside unit and decorators
            m_bu = new BedsideUnit(bedID);
            m_bns = bns;
            m_hm = new HeartMonitor();
            m_heartRate = false;
            m_bpm = new BPMonitor();
            m_bloodPresure = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txtDisplay.Clear();
            this.txtDisplay.Text = m_bu.display();
        }

        private void chkHeart_CheckedChanged(object sender, EventArgs e)
        {

            if (!m_heartRate)
            {
                // One way only removal of decorators is probabblly beyond the scope.
                chkHeart.Enabled = false;
                m_bu = m_hm.AddComponent(m_bu);
            }
            m_heartRate = !m_heartRate;
        }

        private void chkBloodPresure_CheckedChanged(object sender, EventArgs e)
        {
            if (!m_bloodPresure)
            {
                // One way only removal of decorators is probabblly beyond the scope.
                chkBloodPresure.Enabled = false;
                m_bu = m_bpm.AddComponent(m_bu);
            }
            m_bloodPresure = !m_bloodPresure;
        }

        public void setUIAlarm()
        {
            chkAlarm.Checked = true;
            chkAlarm.Enabled = false;
        }

        private void chkAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlarm.Checked == false)
            {
                chkAlarm.Enabled = false;                
            }
        }

        private void chkConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConnect.Checked)
            {
                m_bu.connectNurseStation(m_bns);
            }
            else
            {
                m_bu.disconect();
            }
        }
    }
}
