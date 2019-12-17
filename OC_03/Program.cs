using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_03
{

    class program
    {

        static bool ReadInteger(out int n)
        {

            string input = System.Console.ReadLine();

            n = 0;

            try
            {

                n = Convert.ToInt32(input);

                return true;

            }

            catch (System.Exception ex)
            {

                System.Console.WriteLine("Error in the input format\n\n");

                return false;

            }

        }



        static bool IsLeapYear(int year)
        {

            if ((year % 2) == 0)
            {

                if ((year % 100) == 0)
                {

                    if ((year % 400) == 0)

                        return true;

                    else

                        return false;

                }

                else

                    return true;

            }

            return false;

        }



        static void Main(string[] args)
        {

            int begyear, endyear;

            System.Console.WriteLine("Program to check and print leap years");



            System.Console.Write("Enter Begin Year: ");

            ReadInteger(out begyear);

            System.Console.Write("Enter End Year: ");

            ReadInteger(out endyear);



            System.Console.Write("List of Leap Years Between: {0} and {1}\n", begyear, endyear);
          

            for (int i = begyear; i < endyear; i++)
            {

                if (IsLeapYear(i))

                    System.Console.WriteLine(i);
               
            }

        }

    }



}