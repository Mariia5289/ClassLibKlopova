using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibKlopova;
namespace AppKlopova

{
    public class Program
    {//Клопова 31ИС
        static void Main(string[] args)
        {
            College college = new College("Колледж экономических международных связей", "г. Москва, 5-я ул. Ямского Поля, 23А");
            college.Teachers.Add(new Teacher("Нестеров Иван Викторович", "Банковское дело"));
            college.Teachers.Add(new Teacher("Костин Дмитрий Вячеславович", "Документационное обеспечение управления и архивоведение"));
            college.Teachers.Add(new Teacher("Щербакова Алиса Львовна", "Логистика"));
            college.Teachers.Add(new Teacher("Судакова Елена Фёдоровна", "Экономика"));
            college.ShowAll();
            Console.ReadKey();
        }
    }
}
