using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đặng_Vũ_Linh
{
    public class Student
    {
        string id, name, gender, class1;
        int age;
        double mark1, mark2, mark3;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Class
        {
            get { return class1; }
            set { class1 = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Mark1
        {
            get { return mark1; }
            set { mark1 = value; }
        }
        public double Mark2
        {
            get { return mark2; }
            set { mark2 = value; }
        }
        public double Mark3
        {
            get { return mark3; }
            set { mark3 = value; }
        }
        public double Mark_AVG()
        {
            return (Mark1 + Mark2 + Mark3) / 3;
        }
        public void NhapThongTin()
        {
           Student tt = new Student();
            Console.Write("Nhap Id:");
            tt.Id = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Ten:");
            tt.Name = Console.ReadLine();
            Console.Write("Nhap Tuoi:");
            tt.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Class:");
            tt.Class = Console.ReadLine();
            Console.Write("Nhap Mark1:");
            tt.Mark1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Mark2:");
            tt.Mark2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Mark3:");
            tt.Mark3 = Convert.ToDouble(Console.ReadLine());
        }
        public void TimKiem()
        {
            Console.WriteLine("Nhap ten tim kiem:");
            string TimKiem = Console.ReadLine();
            foreach(TimKiem )

        }
    }
}
