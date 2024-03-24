﻿//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace BudgetReport.Service.Database
{
    internal class MySql : IDatabase
    {
        string path = "../../../Assets/mysql.txt";
        List<string> lines;
        public MySql()
        {
            this.CheckExist();
            lines = new List<string>();
        }
        public void Delete(int lineNumber)
        {
            this.Read();
            lines.RemoveAt(lineNumber - 1);
            this.Write();
        }

        public void Insert(string data)
        {
            File.AppendAllText(path, data + "\n");
        }

        public void Update(int lineNumber, string newData)
        {
            this.Read();
            lines[lineNumber - 1] = newData;
            this.Write();
        }

        void CheckExist() 
        {
            if(!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
        void Read()
        {
            this.lines = File.ReadLines(path).ToList();
        }
        void Write()
        {
            File.WriteAllLines(path, lines);
        }
        public int Count()
        {
            return lines.Count; 
        }
    }
}
