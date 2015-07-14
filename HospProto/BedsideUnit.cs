using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospProto
{
    abstract class Component
    {
        abstract public String display();
        abstract public void SendAlert(String alertMess, Alert.LEVEL level);

        abstract public void connectNurseStation(BaseNurseStation bns);
        abstract public void disconect();
    }

    class BedsideUnit : Component
    {
        private String m_bedID;
        public String bed { get { return m_bedID; } }
        private Boolean m_alarm;
        public Boolean alarm { get { return m_alarm; } }
        public void clearAlarm() { m_alarm = false; }

        private BaseNurseStation m_ns;

        public BedsideUnit(String bedID)
        {
            m_bedID = bedID;
            m_ns = null;
            m_alarm = false;
        }

        public override String display()
        {
            return "BED: " + m_bedID;  
        }

        public override void connectNurseStation(BaseNurseStation ns) { m_ns = ns; }

        public override void disconect() { m_ns = null; }

        public override void SendAlert(String alertMess, Alert.LEVEL level)
        {
            if (null != m_ns)
            {
                Alert alert = new Alert("From Bed Unit " + m_bedID + "\n" + alertMess, level);
                m_ns.Notify(alert);
            }
            m_alarm = true;
        }
    }
}
