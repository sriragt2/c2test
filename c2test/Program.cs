using System;

namespace c2test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade did you get in the class");

            try
            {
                string input = Console.ReadLine();
                int score_input = int.Parse(input);

                string grade = Grade_Score(score_input);
                Console.WriteLine("You scored " + grade);
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Enter a valid score");
                Console.ReadKey(true);
            }
        }

        private static string Grade_Score(int get_score_input)
        {
            if (get_score_input>=95)
            {
                return "A+";

            }
            else if((get_score_input>=90)&&(get_score_input<95))
            {
                return "A";

            }
            else if((get_score_input>=87)&&(get_score_input<90))
            {
                return "A-";
            }
            else if((get_score_input>=84)&&(get_score_input<87))
            {
                return "B+";
            }
            else if((get_score_input>=80)&&(get_score_input<84))
            {
                return "B";
            }
            else if((get_score_input>=77)&&(get_score_input<80))
            {
                return "B-";
            }
            else if ((get_score_input >= 74) && (get_score_input < 77))
            {
                return "C+";
            }
            else if ((get_score_input >= 70) && (get_score_input < 74))
            {
                return "C";
            }
            else if ((get_score_input >= 67) && (get_score_input < 70))
            {
                return "C-";
            }
            else if ((get_score_input >= 63) && (get_score_input < 67))
            {
                return "D+";
            }
            else if ((get_score_input >= 60) && (get_score_input < 63))
            {
                return "D";
            }
            else 
            {
                return "F";
            }
        }
    }
}
