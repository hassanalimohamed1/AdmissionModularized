using System;

namespace AdmissionModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            int testscore;
            string inputString;
            Console.Write("Enter grade point average :");
            inputString = Console.ReadLine();
            gpa = Convert.ToDouble(inputString);
            Console.Write("Enter test score: ");
            inputString = Console.ReadLine();
            testscore = Convert.ToInt32(inputString);
            Console.WriteLine($"{AdmissionStatus(gpa, testscore)}");

        }

        private static string AdmissionStatus(double gpa, int testscore) {
            const double MINGPA = 3.0;
            const int ADMIN1 = 60, ADMIN2 = 80;

            if (gpa >= MINGPA)
            {
                if (testscore >= ADMIN1)
                {
                    return("Accept");
              
                }
                else
                {
                    return ("Reject");
                }
            }

            else
            {

                if (testscore >= ADMIN2)
                {
                    return ("Accept");
                }
                else
                {
                    return ("Reject");
                }

            }

        }
    }
}
