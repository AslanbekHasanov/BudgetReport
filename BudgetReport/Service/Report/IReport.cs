using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetReport.Service.Report
{
    internal interface IReport
    {
        void Open(string date);
        void Save();
    }
}
