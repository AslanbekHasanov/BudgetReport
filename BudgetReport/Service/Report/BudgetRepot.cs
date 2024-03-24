using BudgetReport.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
