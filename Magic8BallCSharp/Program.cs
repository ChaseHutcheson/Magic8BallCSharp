using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8BallCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.Write("Ask The 8 Ball a Question (Type QUIT to quit): ");
                answer = Console.ReadLine();
                Console.WriteLine(Magic8Ball());
            } while (answer.ToUpper() != "QUIT");
            
        }

        public static string Magic8Ball()
        {
            string answer;

            Random random = new Random();
            int randomNum = random.Next(1, 1);

            switch (randomNum)
            {
                case 1:
                    answer = "It is certain";
                    return answer;
                case 2:
                    answer = "Yes.";
                    return answer;
                case 3:
                    answer = "Absolutely";
                    return answer;
                case 4:
                    answer = "I Foresee It.";
                    return answer;
                case 5:
                    answer = "No.";
                    return answer;
                case 6:
                    answer = "Not at All.";
                    return answer;
                case 7:
                    answer = "No Way Jose";
                    return answer;
                case 8:
                    answer = "Nu Uh";
                    return answer;
                case 9:
                    answer = "Reply Hazy, Try Again.";
                    return answer;
                default:
                    return "Try again";
            }

        }
    }
}
