﻿namespace LineComparison_Day8
{

    public class Program
    {

        /// <summary>
        /// Welcome Message for this program & used for running other classes related to LineComputation namespace
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Line Comparison Computation Program");
            CompareLineLength compareLineLength = new CompareLineLength(0);
            compareLineLength.MesuretheLength();

        }

    }
}