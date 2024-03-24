//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace BudgetReport.Service.Report
{
    internal interface IReport
    {
        void Open(string date);
        void Save();
    }
}
