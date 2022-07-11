using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.NewFolder1
{
    class TLaptop
    {
        private string company; 
        string model; 
        int ram; 
        int memory; 
        int price; 
        int yearIssue; 
        public TLaptop(string company,string model, int ram, int memory, int price,int yearIssue)
        {
            this.company = company;
            this.model = model;
            this.ram = ram;
            this.memory = memory;
            this.price = price;
            this.yearIssue = yearIssue;
        }
        public int Price()
        {
            return price;
        }
        public int Ram()
        {
            return ram;
        }
        public int Memory()
        {
            return memory;
        }
        public int Year()
        {
            return yearIssue;
        }
        public string Company()
        {
            return company;
        }
        public string ShowLaptop()
        {
            string s = $"Компания: {company}" + Environment.NewLine;
            s += $"Модель: {model}" + Environment.NewLine;
            s += $"ОЗУ: {ram}" + Environment.NewLine;
            s += $"Память: {memory}" + Environment.NewLine;
            s += $"Цена: {price}" + Environment.NewLine;
            s += $"Год выпуска: {yearIssue}" + Environment.NewLine;
            s += Environment.NewLine;
            return s; 
        }
    }
}
