using System;
using System.IO;
using WindowsFormsApp1.NewFolder1;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.NewFolder1
{
    class TCatalog
    {
        string nameCatalog;
        string dateCreation;
        int numLaptops;
        static TLaptop[] laptops; 
        public TCatalog(string path)
        {
            try
            {              
                StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8);
                string company, model;
                int ram, memory, price, yearIssue;
                nameCatalog = sr.ReadLine();
                dateCreation = sr.ReadLine();
                numLaptops = int.Parse(sr.ReadLine());
                sr.ReadLine();
                laptops = new TLaptop[numLaptops];
                for (int i = 0; i < numLaptops; i++)
                {
                    company = sr.ReadLine();
                    model = sr.ReadLine();
                    ram = int.Parse(sr.ReadLine());
                    memory = int.Parse(sr.ReadLine());
                    price = int.Parse(sr.ReadLine());
                    yearIssue = int.Parse(sr.ReadLine());
                    laptops[i] = new TLaptop(company, model, ram, memory, price, yearIssue);
                    sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Вывод ноутбуков отсортированных по возрастанию цены
        public string ShowCatalog()
        {
            string s = $"Каталог: {nameCatalog}" + Environment.NewLine;
            s += $"Дата создания: {dateCreation}" + Environment.NewLine;
            s += $"Количество ноутбуков: {numLaptops}" + Environment.NewLine;
            s += Environment.NewLine;
            for (int i = 1; i < laptops.Length; i++)
            {
                for (int j = 0; j < laptops.Length - i; j++)
                {
                    if (laptops[j].Price() > laptops[j + 1].Price())
                    { (laptops[j], laptops[j + 1]) = (laptops[j + 1], laptops[j]); }
                }
            }
            for (int i = 0; i < laptops.Length; i++)
            {
                s += laptops[i].ShowLaptop();
            }
            return s;
        }

        //Вывод ноутбука с самым большим объеом памяти
        public static string ShowBestMemory()
        {
            int memory = 0;
            TLaptop[] best = new TLaptop[1];
            for (int i = 0; i < laptops.Length; i++)
            {
                if (memory < laptops[i].Memory()) { memory = laptops[i].Memory(); best[0] = laptops[i]; }
            }
            string s = $"Ноутбук с большим объемом памяти:" + Environment.NewLine;
            s += Environment.NewLine + $"{best[0].ShowLaptop()}";
            return s;
        }
        //Вывод ноутбука с самым большим объемом ОЗУ
        public static string ShowBestRam()
        {
            int ram = 0;
            TLaptop[] best = new TLaptop[1];
            for (int i = 0; i < laptops.Length; i++)
            {
                if (ram < laptops[i].Ram()) { ram = laptops[i].Ram(); best[0] = laptops[i]; }
            }
            string s = $"Ноутбук с большим объемом ОЗУ:" + Environment.NewLine;
            s += Environment.NewLine + $"{best[0].ShowLaptop()}";
            return s;
        }
        //Вывод ноутбука с самым актульным годом выпуска
        public static string ShowBestYear()
        {
            int bYear = 0;
            TLaptop[] best = new TLaptop[1];
            for (int i = 0; i < laptops.Length; i++)
            {
                if (bYear < laptops[i].Year()) { bYear = laptops[i].Year(); best[0] = laptops[i]; }
            }
            string s = $"Ноутбук с самым актуальным годом выпуска:" + Environment.NewLine;
            s += Environment.NewLine + $"{best[0].ShowLaptop()}";
            return s;
        }
        

        //Количество ноутбуков каждой марки
        public string NumCompany()
        {
            int n = 0;
            for (int i = 0; i < laptops.Length; i++)
            {
                for (int j = i + 1; j < laptops.Length; j++)
                {
                    if (laptops[j].Company() == laptops[i].Company())
                    {
                        n++;
                        break;
                    }
                }
            }
            n = laptops.Length - n;

            string[] a = new string[n + 1];
            int[] b = new int[n + 1];
            a[0] = laptops[0].Company();
            if (n == 1)
            {
                b[0] = laptops.Length;
            }
            else
            {
                int k = 1;
                for (int i = 0; i < n; i++)
                {
                    b[i] = 1;
                    a[i + 1] = "";
                    for (int j = k; j < laptops.Length; j++)
                    {
                        if (laptops[j].Company() == a[i]) { b[i]++; k++; }
                        else { if (a[i + 1] == "") { a[i + 1] = laptops[j].Company(); b[i + 1] = 1; k++; } }
                    }
                }
            }
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += $"В каталоге {b[i]} ноутбуков марки {a[i]}" + Environment.NewLine;
            }
            return result;
        }
    }
}