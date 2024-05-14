using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Random_Numbers_Searching_Sorting
{
    /// <summary>
    /// Class representing a Subtractive Lagged Fibonacci Pseudo Random Number Generator.
    /// 
    /// TODO:  Implement the indicated methods in this class to create a Subtractive LFG 
    ///        where the set of initial k states is generated using Random Bit Generation.
    ///        
    ///        To do this you will have to:
    ///        1. Complete the code marked TODO in InitializeStates()
    ///        2.  Implement the Next() method to generate a random number between min & max using the Subtractive LFG Formula
    ///        
    /// All other parts of the code are implemented and require no addition/modification
    /// </summary>
    internal class LFG
    {

        //Optimal Values for j, k and m for Subtractie LFG
        private int j = 6;
        private int k = 31;
        private double m = Math.Pow(2, 61) - 1;

        //Set of k states from which random numbers are generated
        private long[] states; 


        //Overloaded constructor which sets up the LFG with the required set of k states
        public LFG()
        {
            states = new long[k];
            InitializeStates();
        }

        /// <summary>
        /// Initializes the states array with 64 random long numbers generated using random bit generation
        /// TODO: Complete the parts of the code marked with a TODO comment
        /// </summary>
        private void InitializeStates()
        {
           Random random = new Random();
            // For k states
            for (int i = 0; i < k; i++)
            {
                // Generate 64 random bits and store them in randomBits using C# Random object
                byte[] array = new byte[8];
                random.NextBytes(array);
                long randomLong = BitConverter.ToInt64(array, 0);

                // Store the generated long into the array states at the current index
                states[i] = randomLong;
            }
        }

        /// <summary>
        /// TODO : Generates a random long number between min and max using the Subtractive Lagged Fibonacci Formula
        /// </summary>
        /// <param name="min">long smallest possible random number</param>
        /// <param name="max">long largest possible random number</param>
        /// <returns>long random number between min and max </returns>
        public long Next(long min, long max)
        {
 // Generate a random number using the Subtractive Lagged Fibonacci Formula
            long result = (states[j - 1] - states[k - 1]) % (long)m;
            if (result < 0)
                result += (long)m;

            // Update the states array
            for (int i = k - 1; i > 0; i--)
            {
                states[i] = states[i - 1];
            }
            states[0] = result;

            // Scale the result to be within the specified range
            double scaleFactor = (double)(max - min) / ((long)m - 1);
            long scaledResult = (long)(min + scaleFactor * result);
            return scaledResult;
            
        }


       
    }
}
