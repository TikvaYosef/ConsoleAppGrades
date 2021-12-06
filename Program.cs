// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;


namespace ConsoleAppGrades
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int[] array = new int[3];
            try
            {
                Console.WriteLine("press 1 to enter or 2 to print data");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Greds123(array);
                        break;

                    case 2:
                        PrintData(array);

                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("value must be number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            


        }





        static void Greds123(int[] array)
        {
            Console.WriteLine("number of student?");
            int numOfStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("name of the teacer");
            string name = Console.ReadLine();
            Console.WriteLine("name of the student");
            string nameS = Console.ReadLine();
            Console.WriteLine("student ID");
            int StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("grades");

            int grade1 = int.Parse(Console.ReadLine());
            int grade2 = int.Parse(Console.ReadLine());
            int grade3 = int.Parse(Console.ReadLine());
            array[0] = grade1;
            array[1] = grade2;
            array[2] = grade3;
            List<string> listOfStr = new List<string>();
            int counter = 0;
           


            List<Teacher> list1 = new List<Teacher>();

            for (int i = 0; i < numOfStudent; i++)
            {
                Teacher teach1 = new Teacher(name, nameS, StudentId, array);
                list1.Add(teach1);
            }


            FileStream sn = new FileStream($@"C:\student\{name}.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(sn))
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    writer.WriteLine($"id : {counter++}  name: {list1[i].studentName}  taz: {list1[i].studentId}  grades : {list1[i].grade[0]} ,{list1[i].grade[1]} ,{list1[i].grade[2]} ,");
                }

            }

            FileStream sl = new FileStream($@"C:\student\{name}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(sl))
            {
                for (int i = 0; i < listOfStr.Count; i++)
                {
                    listOfStr.Add(reader.ReadLine());

                    Console.WriteLine(listOfStr);
                }
               

            }


          





        }

       
        static void PrintData(int[] array)
        {
            int avg =(array[0] + array[1] + array[2])/3;


            FileStream fs = new FileStream($@"C:\student\tikva.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fs))
            {
              Console.WriteLine(reader.ReadLine().Substring(6,15), avg) ;
            }


        }
        
    }
}
