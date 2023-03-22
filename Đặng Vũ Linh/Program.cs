using Đặng_Vũ_Linh;

class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        Console.WriteLine("====================");
        Console.WriteLine("1.Input IF");
        Console.WriteLine("2.Sorting Student by average");
        Console.WriteLine("3.Display all student list");
        Console.WriteLine("4.Search student by Name");
        Console.WriteLine("5.Delete Student by ID");
        Console.WriteLine("6.Exit program");
        Console.WriteLine("====================");
        Console.Write("Nhap lua chon: ");
        int key = Convert.ToInt32(Console.ReadLine());
        switch (key)
        {
            case 1: Console.WriteLine("1.Input IF");
                student.NhapThongTin();
                break;
            case 6: Console.WriteLine("Thoat chuong trinh");
                break;
        }

    }
}
