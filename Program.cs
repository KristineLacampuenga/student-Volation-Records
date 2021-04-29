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

            int c = 0;
            for (; c < 3; c++)
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
                if (c == 2)
                {
                    Environment.Exit(0);
                }
            }
            //int v = 0;
            //for (; v < 3; v++)
        {

                //Console.WriteLine();
                //Console.WriteLine("Violated School Rules:");

                //string name = "kristine B. Lacampuenga";

                //string rule1 = " Cheating";
                //string rule2 = " Disrespect for Authority";
                //string rule3 = " Classroom Distruption";
                //string rule4 = " Always Late";

                //Console.WriteLine();
                //Console.Write("Enter Full Name:");
                //string codeInput = Console.ReadLine();

                //if (codeInput == name)
                //{
                //    Console.WriteLine();
                //    Console.WriteLine("Violated Rules:" + rule1);
                //    Console.WriteLine("Violated Rules:" + rule2);
                //    Console.WriteLine("Violated Rules:" + rule3);
                //    Console.WriteLine("Violated Rules:" + rule4);
                //    break;
                //}
                //else
                //{
                //    Console.WriteLine();
                //    Console.WriteLine("Invalid Input");
                //}
                //if (v == 2)
                //{
                //    Environment.Exit(0);
                //}
                Console.WriteLine();
                Console.WriteLine("Violated School Rules:");
                var violatedRules = new[] { " Cheating", " Disrespect for Authority", " Classroom Distruption", " Always Late" };

                foreach (var violated in violatedRules)
                {
                    Console.WriteLine($"Violated Rules: {violated}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Notes*");
            Console.WriteLine("Student actions on or off campus that allegedly violate university behavioral standards," +
                " the Code, or federal, state, and local laws, may subject the student to concurrent jurisdiction of," +
                " and the imposition of a sanction by, both the university and civil authorities." +
                " The university may enforce its own regulations and student violations of the Code regardless of any" +
                " proceedings instituted by authorities or may proceed with campus disciplinary hearings without waiting " +
                "for results of off-campus criminal proceedings fear of violating student constitutional rights, " +
                "particularly the right of self-incrimination. ");
            Console.WriteLine();
            Console.WriteLine("Student Also violated the school Rules:");
            Console.WriteLine();
            String[,] students =
            {
                {"Perez", "Gonsales", "Mendez", "Cruz" },
                {"Cheating and Alcoholic Deverages", "Disrespect for Authority and Verbal abuse", "Illigal used of Telephone", "Alcoholic Beverages"}

            };
            for (int titleIndex = 0; titleIndex < students.GetLength(0) - 1; titleIndex++)
            {
                for (int violationIndex = 0; violationIndex < students.GetLength(1); violationIndex++)
                {
                    Console.WriteLine($"{students[titleIndex, violationIndex]}" +$": {students[titleIndex + 1, violationIndex]}");
                }
            }
              
        }

    }
}


