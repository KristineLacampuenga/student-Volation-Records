using System;

namespace StudentViolationRecordsManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to Student Violation Records Management System");
            Console.WriteLine();
            Console.WriteLine("Student Information");

            string studentnumber = "2020-00410-BN-0";
            string studentname = "Kristine B. Lacapuenga";
            string studentemail = "Kristinelacampuenga@gmail.com";
            string studentaddress = "Baranggay Soro-Soro Binan City Laguna";
            int age = 19;
            string studentusername = "kristine Lacampuenga";
            string password = "kristine";
            string studentcourse = "DICT";
            string studentyearlevel = "First year";

            for (int c = 0; c < 3; c++)
            {

                Console.WriteLine();
                Console.Write("Enter Username:");
                string usernameInput = Console.ReadLine();

                Console.WriteLine();
                Console.Write("Enter Password:");
                string passwordInput = Console.ReadLine();


                if (usernameInput == studentusername && passwordInput == password)
                {
                    Console.WriteLine();
                    Console.WriteLine("Student Number:" + studentnumber);
                    Console.WriteLine("Student Name:" + studentname);
                    Console.WriteLine("Student Email:" + studentemail);
                    Console.WriteLine("Student Address:" + studentaddress);
                    Console.WriteLine("Student Age:" + age);
                    Console.WriteLine("Student course:" + studentcourse);
                    Console.WriteLine("Student Yearlevel:" + studentyearlevel);
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input");
                }
            }
            for (int v = 0; v < 3; v++)
            {

            Console.WriteLine();
            Console.WriteLine("Violated Classroom Rules");

            string name = "kristine B. Lacampuenga";

            string rule1 = " Noise when the teacher is talking";
            string rule2 = " Noise when classmates are talking.";
            string rule3 = " Didn't Respect and listen to thier classmates.";
            string rule4 = " Always Late";

            Console.WriteLine();
            Console.Write("Enter Full Name:");
            string codeInput = Console.ReadLine();

            if (codeInput == name)
            {
                Console.WriteLine();
                Console.WriteLine("Violated Rules:" + rule1);
                Console.WriteLine("Violated Rules:" + rule2);
                Console.WriteLine("Violated Rules:" + rule3);
                Console.WriteLine("Violated Rules:" + rule4);
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input");
            }
        }


        }


    }
}

