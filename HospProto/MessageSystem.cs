using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospProto
{
    abstract public class BaseMessageSystem
    {        
        abstract public void sendMessage(Alert alert);

        // This is just for the protype UI
        protected String m_title;
        public String title { get { return m_title; } }
        protected String m_instanceName;
        public String name { get { return m_instanceName; } }
        protected messagerUIHook m_ui;
        public void addHook(messagerUIHook ui)
        {
            m_ui = ui;
        }
    }

    public class Pager : BaseMessageSystem
    {
        private String m_pagerNum;

        public Pager(String name, String num)
        {
            m_title = "I am a\nPAGER";
            m_instanceName = name;
            m_pagerNum = num;
        }

        override public void sendMessage(Alert alert)
        {
            String message = "PAGEING " + m_pagerNum + "\n" + alert.message + "\n LEVEL : " + alert.level;
            if (null != m_ui)
                m_ui.addMessage(message);
        }
    }

    public class Email : BaseMessageSystem
    {
        private String m_emailAdd;

        public Email(String name, String email)
        {
            m_title = "I am an\nEMAIL ACCOUNT";
            m_instanceName = name;
            m_emailAdd = email;
        }

        override public void sendMessage(Alert alert)
        {
            String message = "MAIL TO:" + m_emailAdd + "\n" + alert.message + "\n LEVEL : " + alert.level;
            if (null != m_ui)
                m_ui.addMessage(message);
        }
    }

    public class MobilePhone : BaseMessageSystem
    {
        private String m_phoneNum;

        public MobilePhone(String name, String phoneNum)
        {
            m_title = "I am a\nMOBILE PHONE";
            m_instanceName = name;
            m_phoneNum = phoneNum;
        }

        override public void sendMessage(Alert alert)
        {
            String message = "SMS TO:" + m_phoneNum + "\n" + alert.message + "\n LEVEL : " + alert.level;
            if (null != m_ui)
                m_ui.addMessage(message);
        }
    }

    public class ManagementRecordSystem : BaseMessageSystem
    {
        public ManagementRecordSystem(String name)
        {
            m_title = "I am the\nMANAGEMENT\nRECORDING SYSTEM";
            m_instanceName = name;
        }

        override public void sendMessage(Alert alert)
        {
            String message = "ALERT RECIEVED:" + "\n" + alert.message + "\n LEVEL : " + alert.level;
            if (null != m_ui)
                m_ui.addMessage(message);
        }
    }
}
