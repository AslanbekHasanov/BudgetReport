//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System.Collections.Generic;

namespace BudgetReport.Service.Database
{
    internal interface IDatabase
    {
        void Insert(string data);
        void Update(int lineNumber, string data);
        void Delete(int lineNumber);
        List<string> Read();
    }
}
