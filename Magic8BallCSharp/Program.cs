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
        }

        public Magic8Ball()
        {
            Random random = new Random();

            switch (random)
            {
                case 1:
                    string answer = "It is certain";
                    return answer;
                    break;
            }

        }
    }
}
