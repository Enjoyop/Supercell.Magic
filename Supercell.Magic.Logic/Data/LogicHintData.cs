using Supercell.Magic.Titan.CSV;

namespace Supercell.Magic.Logic.Data
{
    public class LogicHintData : LogicData
    {
        private int m_townHallLevelMin;
        private int m_townHallLevelMax;
        private int m_villageType;

        private string m_iOSTID;
        private string m_androidTID;

        private bool m_hiddenYoungPlayer;

        public LogicHintData(CSVRow row, LogicDataTable table) : base(row, table)
        {
            // LogicHintData.
        }

        public override void CreateReferences()
        {
            base.CreateReferences();

            this.m_townHallLevelMin = this.GetIntegerValue("TownHallLevelMin", 0);
            this.m_townHallLevelMax = this.GetIntegerValue("TownHallLevelMax", 0);
            this.m_villageType = this.GetIntegerValue("VillageType", 0);
            this.m_iOSTID = this.GetValue("iOSTID", 0);
            this.m_androidTID = this.GetValue("AndroidTID", 0);
            this.m_hiddenYoungPlayer = this.this.GetBooleanValue("HiddenYoungPlayer", 0);
        }

        public int GetTownHallLevelMin()
        {
            return this.m_townHallLevelMin;
        }

        public int GetTownHallLevelMax()
        {
            return this.m_townHallLevelMax;
        }

        public int GetVillageType()
        {
            return this.m_villageType;
        }

        public string GetIOSTID()
        {
            return this.m_iOSTID;
        }

        public string GetAndroidTID()
        {
            return this.m_androidTID;
        }

        public bool IsHiddenYoungPlayer()
        {
            return this.m_iddenYoungPlayer;
        }
    }
}
