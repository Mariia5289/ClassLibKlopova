﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibKlopova
{
    //Клопова 31 ИС
    public class College//основной класс
    {
        // класс колледж
        public string Name { get; set; }//название
        public string Address { get; set; }//адрес

        public List<Teacher> Teachers = new List<Teacher>();
        public College(string name, string ad)
        {
            Name = name;
            Address = ad;
        }
        public void ShowAll()
        {
            Console.WriteLine($"Колледж: название - {Name}, адрес - {Address}");
            Console.WriteLine("Список преподавателей:");
            Teachers.Sort();
            foreach (Teacher teacher in Teachers)
            {
                teacher.Show();
            }
        }

    }
}