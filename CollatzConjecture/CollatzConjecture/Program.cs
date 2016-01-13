using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTheUserInput("Enter a number");
        }

        static void GetTheUserInput(string Message)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(Message);
                    string inPut = Console.ReadLine();
                    int int_Input = int.Parse(inPut);
                    /////////////////////////////////////////////////////////////
                    int steps_evens = 0;
                    int steps_odds = 0;
                    int peakNum_evens = 0;
                    int peakNum_odds = 0;
                    int peak = 0;
                    int StepInPeakodd = 0;
                    int StepInPeakeven = 0;
                    int StepInPeak = 0;
                    //////////////////////////////////////////////////////////////
                    int i = int_Input;
                    int result1 = 0;
                    int x = 1;
                    while (i != 1)
                    {
                        int even_oddTest = i % 2;
                        ///////////////////////////////////////////////////////////////
                        if (even_oddTest == 0)
                        {
                            steps_evens += 1;
                            result1 = i / 2;

                        }

                        else {
                            steps_evens += 1;
                            result1 = (i * 3) + 1;

                        }
                        ///////////////////////////////////////////////////////////////////////////////////
                        if (result1 > peakNum_evens)
                        {
                            peakNum_evens = result1;
                            StepInPeakeven = x;
                        }

                        else if (result1 > peakNum_odds)
                        {
                            peakNum_odds = result1;
                            StepInPeakodd = x;
                        }

                        i = result1;
                        x += 1;
                    }
                    ////////////////////////////////////////////////////////////////
                    if (peakNum_odds > peakNum_evens)
                    {
                        peak = peakNum_odds;
                        StepInPeak = StepInPeakodd;
                    }
                    else {
                        peak = peakNum_evens;
                        StepInPeak = StepInPeakeven;
                    }
                    /////////////////////////////////////////////
                    int stepTotal = steps_evens + steps_odds;
                    Console.WriteLine("It takes " + stepTotal + " steps to reach 1 from " + int_Input + ".");
                    Console.WriteLine("The value reaches its peak of " + peak + " at step " + StepInPeak + ".");
                }

                catch
                {

                    Console.WriteLine("You ntered a non intger value");
                }
            }
        }
    }
}