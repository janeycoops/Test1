using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospProto
{
    abstract class MonitoringModule : Component
    {
        private Component m_comp;

        public MonitoringModule()
        {
            m_comp = null;
        }

        // No checks if this has already been set
        public Component AddComponent(Component comp)
        {
            // NB can only be added once
            if (null == m_comp)
            {
                m_comp = comp;
                return this;
            }
            return comp;
        }

        public override string display()
        {
            if (null != m_comp)
            {
                return m_comp.display();
            }
            return "No decoration";
        }

        public override void SendAlert(String alertMess, Alert.LEVEL level)
        {
            if (null != m_comp)
            {
                m_comp.SendAlert(alertMess, level);
            }
        }

        public override void connectNurseStation(BaseNurseStation ns)
        {
            if (null != m_comp)
            {
                m_comp.connectNurseStation(ns);
            }
        }

        public override void disconect()
        {
            if (null != m_comp)
            {
                m_comp.disconect();
            }
        }
    }

    class HeartMonitor : MonitoringModule
    {
        public override String display()
        {
            // create a random heart rate
            int num = FormControlCenter.getRndInt(0, 200);

            // Alarm conditions
            if (num < 5)
            {
                SendAlert("Low heart rate :" + num + " bpm", Alert.LEVEL.INFORMATION);
            }

            return base.display() + "\n\tHeart Rate = " + num;
        }
    }

    class BPMonitor : MonitoringModule
    {
        public override String display()
        {
            // create a random BP
            int top = FormControlCenter.getRndInt(0, 300);
            int bot = FormControlCenter.getRndInt(0, 200);

            if (top > 290 || bot > 190)
            {
                SendAlert("High blood preasure warning " + +top + "\\" + bot, Alert.LEVEL.WARNING);
            }
            return base.display() + "\n\tBP = " + top + "\\" + bot;
        }
    }
}
