using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibKlopova
{
    //Клопова 31 ИС
    //Класс Преподаватель
    public class Teacher : IComparable<Teacher>
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
        public int CompareTo(Teacher? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
