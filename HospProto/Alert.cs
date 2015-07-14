using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospProto
{
    public class Alert
    {
        private String m_mess;
        public String message { get { return m_mess; } }
        /// <summary>
        /// Enum
        /// </summary>
        public enum LEVEL
        {
            INFORMATION,
            WARNING,
            ALARM,
            CRITICAL,
        }
        private LEVEL m_level;
        public LEVEL level { get {return m_level; } }


        public Alert(String message, LEVEL level)
        {
            m_mess = message;
            m_level = level;
        }
    }
}
