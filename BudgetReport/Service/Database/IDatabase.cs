using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetReport.Service.Database
{
    internal interface IDatabase
    {
        void Insert(string data);
        void Update(int lineNumber, string data);
        void Delete(int lineNumber);
    }
}
