using Supercell.Magic.Titan.CSV;

﻿namespace Supercell.Magic.Logic.Data
{
    public class LogicClientGlobals : LogicDataTable
    {
        private int row16;
        private int row17;
        private int row18;
        private int row19;
        private int row27;
        private int row28;

        private string row1;
        private string row2;
        private string row3;
        private string row4;
        private string row5;
        private string row6;
        private string row7;
        private string row8;
        private string row9;
        private string row10;
        private string row11;
        private string row14;
        private string row15;

        private bool row20;
        private bool row21;
        private bool row25;
        private bool row26;

        private bool m_pepperEnabled;
        private bool m_powerSaveModeLessEndTurnMessages;

        public LogicClientGlobals(CSVTable table, LogicDataType index) : base(table, index)
        {
        }

        public override void CreateReferences()
        {
            base.CreateReferences();

            this.row1 = this.GetStrValue("GAME_FACEBOOK_URL");
            this.row2 = this.GetStrValue("GAME_WEIBO_URL");
            this.row3 = this.GetStrValue("GAME_APPBANK_URL");
            this.row4 = this.GetStrValue("GAME_EXTERNAL_URL");
            this.row5 = this.GetStrValue("GAME_TWITTER_URL");
            this.row6 = this.GetStrValue("GAME_TWITTER_URL_JP");
            this.row7 = this.GetStrValue("TOS_URL");
            this.row8 = this.GetStrValue("PRIVACY_POLICY_URL_JP");
            this.row9 = this.GetStrValue("TOS_URL_JP");
            this.row10 = this.GetStrValue("PRIVACY_POLICY_URL_KR");
            this.row11 = this.GetStrValue("TOS_URL_KR");
            this.row14 = this.GetStrValue("HELPCENTER_CONTACT");
            this.row15 = this.GetStrValue("PRIVACY_POLICY_URL");
            this.row16 = this.GetIntValue("APP_RATE_XP_LEVEL");
            this.row17 = 3600 * this.GetIntValue("COME_BACK_NOTIFICATION_DELAY_HOURS_SMALL");
            this.row18 = 3600 * this.GetIntValue("COME_BACK_NOTIFICATION_DELAY_HOURS_MEDIUM");
            this.row19 = 3600 * this.GetIntValue("COME_BACK_NOTIFICATION_DELAY_HOURS_LARGE");
            this.row20 = this.GetBoolValue("GAMECENTER_REAUTHORIZE");
            this.row21 = this.GetBoolValue("BILLING_PACK_NAMES_FROM_CSV");
            this.row25 = this.GetBoolValue("DROID_SANS_FALLBACK_ON_LOW_MEM_DEVICES");
            this.row26 = this.GetBoolValue("GOOGLE_SERVICE_ACHIEVEMENTS_BUTTON");
            this.row27 = this.GetIntValue("ASH_CNT");
            this.row28 = this.GetIntValue("ASH_CNT_LOW");
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

        private string GetStrValue(string name)
        {
            return this.GetGlobalData(name).GetTextValue();
        }

        public string GameFacebookUrl()
        {
            return this.row1;
        }

        public string GameWeiboUrl()
        {
            return this.row2;
        }

        public string GameAppbankUrl()
        {
            return this.row3;
        }

        public string GameExternalUrl()
        {
            return this.row4;
        }

        public string GameTwitterUrl()
        {
            return this.row5;
        }

        public string GameTwitterUrlJp()
        {
            return this.row6;
        }

        public string TosUrl()
        {
            return this.row7;
        }

        public string PrivacyPolicyUrlJp()
        {
            return this.row8;
        }

        public string TosUrlJp()
        {
            return this.row9;
        }

        public string PrivacyPolicyUrlKr()
        {
            return this.row10;
        }

        public string TosUrlKr()
        {
            return this.row11;
        }

        public string HelpcenterContact()
        {
            return this.row14;
        }

        public string PrivacyPolicyUrl()
        {
            return this.row15;
        }

        public int AppRateXpLevel()
        {
            return this.row16;
        }

        public int ComeBackNotificationDelayHoursSmall()
        {
            return this.row17;
        }

        public int ComeBackNotificationDelayHoursMedium()
        {
            return this.row18;
        }

        public int ComeBackNotificationDelayHoursLarge()
        {
            return this.row19;
        }

        public bool GamecenterReauthorize()
        {
            return this.row20;
        }

        public bool BillingPackNamesFromCsv()
        {
            return this.row21;
        }

        public bool DroidSansFallbackOnLowMemDevices()
        {
            return this.row25;
        }

        public bool GoogleServiceAchievementsButton()
        {
            return this.row26;
        }

        public int AshCount()
        {
            return this.row27;
        }

        public int AshCountLow()
        {
            return this.row28;
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
