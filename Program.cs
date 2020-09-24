using System;

namespace _22_09_20__student_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prog = { 5, 4, 5, 3, 4 };
            int[] adm = { 4, 3, 4, 3, 4, 5 };
            int[] dis = { 2, 3, 2, 3, 1, 3, 2 };
            Student first = new Student();
            Student second = new Student("Ivan", "Ivanovich", "Ivanenko", "15-B", 18, prog.Length, adm.Length, dis.Length);
            second.AddMark(prog, 0);
            second.AddMark(adm, 1);
            second.AddMark(dis, 2);
            Console.WriteLine(first.ShowInfo());            
            Console.WriteLine(second.ShowInfo());
            Console.ReadKey();
        }
        
    }
}
