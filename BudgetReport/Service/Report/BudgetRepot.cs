//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using BudgetReport.Service.Database;

namespace BudgetReport.Service.Report
{
    internal class BudgetRepot : IReport
    {
        private IDatabase database;
        public BudgetRepot()
        {
            this.database = new MySql();
        }
        public void Open(string date)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
