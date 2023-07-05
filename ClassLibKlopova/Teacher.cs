using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibKlopova
{
    //Клопова 31 ИС
    //Класс Преподаватель
    public class Teacher
    {
        public string Name { get; set; }//ФИО
        public string Course { get; set; }//преподаваемая дисциплина
        public Teacher(string name, string course)
        {
            Name = name;
            Course = course;
        }
        public void Show()
        {
            Console.WriteLine(
                 $"\tНазвание: {Name}, преподаваемая дисциплина - {Course}");
        }
    }
}
