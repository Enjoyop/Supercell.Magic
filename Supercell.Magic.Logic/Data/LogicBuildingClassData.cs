namespace Supercell.Magic.Logic.Data
{
    using Supercell.Magic.Titan.CSV;

    public class LogicBuildingClassData : LogicData
    {
        private bool m_townHall2Class;
        private bool m_townHallClass;
        private bool m_wallClass;
        private bool m_workerClass;
        private bool m_canBuy;
        private bool m_shopCategoryResource;
        private bool m_shopCategoryArmy;
        private bool m_shopCategoryDefense;
        private bool m_npc;
        
        private LogicBuildingClassData m_parentClass;

        public LogicBuildingClassData(CSVRow row, LogicDataTable table) : base(row, table)
        {
            // LogicBuildingClassData.
        }

        public override void CreateReferences()
        {
            base.CreateReferences();

            this.m_canBuy = this.GetBooleanValue("CanBuy", 0);
            this.m_shopCategoryResource = this.GetBooleanValue("ShopCategoryResource", 0);
            this.m_shopCategoryArmy = this.GetBooleanValue("ShopCategoryArmy", 0);
            this.m_shopCategoryDefense = this.GetBooleanValue("ShopCategoryDefense", 0);
            this.m_npc = this.GetBooleanValue("Npc", 0);
            this.m_parentClass = LogicDataTables.GetBuildingClassByName(this.GetValue("ParentClass", 0), this);

            this.m_workerClass = string.Equals("Worker", this.GetName());

            if (!this.m_workerClass)
            {
                this.m_workerClass = string.Equals("Worker2", this.GetName());
            }

            this.m_townHallClass = string.Equals("Town Hall", this.GetName());
            this.m_townHall2Class = string.Equals("Town Hall2", this.GetName());
            this.m_wallClass = string.Equals("Wall", this.GetName());
        }

        public bool IsWorker()
        {
            return this.m_workerClass;
        }

        public bool IsTownHall()
        {
            return this.m_townHallClass;
        }

        public bool IsTownHall2()
        {
            return this.m_townHall2Class;
        }

        public bool IsWall()
        {
            return this.m_wallClass;
        }

        public bool CanBuy()
        {
            return this.m_canBuy;
        }
        
        public LogicBuildingClassData GetParentClass()
        {
            return this.m_parentClass;
        }
    }
}
