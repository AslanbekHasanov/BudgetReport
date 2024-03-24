//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System.Collections.Generic;

namespace BudgetReport.Service.Report
{
    internal interface IReport
    {
        List<string> Open(string date);
        void Save(string data);
    }
}
