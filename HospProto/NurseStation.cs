using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospProto
{
    public class BaseNurseStation
    {
        private List<BaseMessageSystem> m_observers = new List<BaseMessageSystem>();

        public void Attach(BaseMessageSystem observer)
        {
            m_observers.Add(observer);
        }

        public void Detach(BaseMessageSystem observer)
        {
            m_observers.Remove(observer);
        }

        public void Notify(Alert alert)
        {
            foreach (BaseMessageSystem o in m_observers)
            {
                o.sendMessage(alert);
            }
        }
    }

    class NurseStation : BaseNurseStation
    {
        private String m_stationID;

        public NurseStation(String id)
        {
            m_stationID = id;
        }

        public void alert(Alert alert)
        {
            Notify(alert);
        }
    }
}
