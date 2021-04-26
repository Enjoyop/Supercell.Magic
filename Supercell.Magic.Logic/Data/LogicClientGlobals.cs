using Supercell.Magic.Titan.CSV;

﻿namespace Supercell.Magic.Logic.Data
{
    public class LogicClientGlobals : LogicDataTable
    {
        private bool m_shareTagsEnabled;
        private bool m_pepperEnabled;
        private bool m_powerSaveModeLessEndTurnMessages;

        private int m_shareDisableIosMin;
        private int m_shareDisableIosMax;
        
        private string m_GameFacebookUrl;
        private string m_GameWeiboUrl;
        private string m_GameAppbankUrl;
        private string m_GameExternalUrl
        private string m_GameTwitterUrl;
        private string m_GameTwitterUrlJp;

        public LogicClientGlobals(CSVTable table, LogicDataType index) : base(table, index)
        {
        }

        public override void CreateReferences()
        {
            base.CreateReferences();
  
            this.m_shareTagsEnabled = this.GetBoolValue("SHARE_TAGS_ENABLED");
            this.m_shareDisableIosMin = this.GetIntValue("SHARE_DISABLED_IOS_MIN");
            this.m_shareDisableIosMax = this.GetIntValue("SHARE_DISABLED_IOS_MAX");
            this.m_GameFacebookUrl = this.GetValue("GAME_FACEBOOK_URL");
            this.m_GameWeiboUrl = this.GetValue("GAME_WEIBO_URL");
            this.m_GameAppbankUrl = this.GetValue("GAME_APPBANK_URL");
            this.m_GameExternalUrl = this.GetValue("GAME_EXTERNAL_URL");
            this.m_GameTwitterUrl = this.GetValue("GAME_TWITTER_URL");
            this.m_GameTwitterUrlJp = this.GetValue("GAME_TWITTER_URL_JP");

            this.m_pepperEnabled = this.GetBoolValue("USE_PEPPER_CRYPTO");
            this.m_powerSaveModeLessEndTurnMessages = this.GetBoolValue("POWER_SAVE_MODE_LESS_ENDTURN_MESSAGES");
        }

        private LogicGlobalData GetGlobalData(string name)
        {
            return LogicDataTables.GetClientGlobalByName(name, null);
        }

        private bool GetBoolValue(string name)
        {
            return this.GetGlobalData(name).GetBooleanValue();
        }

        private int GetIntValue(string name)
        {
            return this.GetGlobalData(name).GetNumberValue();
        }

        private string GetValue(string name)
        {
            return this.GetGlobalData(name).GetTextValue();
        }

        public bool PepperEnabled()
        {
            return this.m_pepperEnabled;
        }

        public bool PowerSaveModeLessEndTurnMessages()
        {
            return this.m_powerSaveModeLessEndTurnMessages;
        }
    }
}
