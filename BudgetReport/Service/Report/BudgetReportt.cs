//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System.Collections.Generic;
using BudgetReport.Service.Database;

namespace BudgetReport.Service.Report
{
    internal class BudgetReportt : IReport
    {
        private IDatabase database;
        public BudgetReportt()
        {
            this.database = new MySql();
        }
        public List<string> Open(string date)
        {
            return this.database.Read();
        }

        public void Save(string data)
        {
            this.database.Insert(data);
        }
    }
}
