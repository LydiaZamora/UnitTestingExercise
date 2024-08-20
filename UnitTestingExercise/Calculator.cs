using System;
namespace UnitTestingExercise
{
    public class Calculator
    {

        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        //For Example:
        public int AddThree(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        } 
        
        public int SubtractMin(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

       public int MultiplyTwo(int num1, int num2)
        {
            return num1 * num2;
        }

       public int DivideTwo(int num1, int num2)
        {
            return num1 / num2;
        }
       
    }
}
