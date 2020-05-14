namespace Supercell.Magic.Logic.Data
{
    using Supercell.Magic.Titan.CSV;

    public class LogicAllianceBadgeData : LogicData
    {
        private LogicAllianceBadgeLayerData m_iconLayer0;
        private LogicAllianceBadgeLayerData m_iconLayer1;
        private LogicAllianceBadgeLayerData m_iconLayer2;

        public LogicAllianceBadgeData(CSVRow row, LogicDataTable table) : base(row, table)
        {
            // LogicAllianceBadgeData.
        }

        public override void CreateReferences()
        {
            base.CreateReferences();

            this.m_iconLayer0 = LogicDataTables.GetAllianceBadgeLayerByName(this.GetValue("IconLayer0", 0), this);
            this.m_iconLayer1 = LogicDataTables.GetAllianceBadgeLayerByName(this.GetValue("IconLayer1", 0), this);
            this.m_iconLayer2 = LogicDataTables.GetAllianceBadgeLayerByName(this.GetValue("IconLayer2", 0), this);
        }

        public LogicAllianceBadgeLayerData GetIconLayer0()
        {
            return this.m_iconLayer0;
        }

        public LogicAllianceBadgeLayerData GetIconLayer1()
        {
            return this.m_iconLayer1;
        }

        public LogicAllianceBadgeLayerData GetIconLayer2()
        {
            return this.m_iconLayer2;
        }
    }
}
