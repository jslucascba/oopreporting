using System;

namespace oopprojectsec1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StudentFile myDataHandler = new StudentFile("students.txt");
            Student[] myStudents = myDataHandler.GetAllStudents();
            StudentReports reports = new StudentReports(myStudents);
            Utility myUtility = new Utility(myStudents);
            myUtility.Sort();

            Menu menu = new Menu();
            menu.MainMenu();

            menu.ReportMenu();

            // Console.WriteLine(" After sort -------------------------");

            // reports.PrintAllStudents();

            // string searchVal = "Makayla Townsend";

            // int found = myUtility.Search(searchVal);
            // if(found != -1)
            // {
            //     Console.WriteLine("What should credit hour be");
            //     int updatedHours = int.Parse(Console.ReadLine());
            //     myStudents[found].SetCreditHours(updatedHours); 
            // }

            // myDataHandler.Save(myStudents);

            //reports.ExcessGpa();

            //reports.HoursByYear();
        }
    }
}
