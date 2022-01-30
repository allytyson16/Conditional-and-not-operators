using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
//Conditional and not operators
//(condition)?true:false
				int x = 2;
				int y = 8;
				
				int biggestNumber = x > y ? x : y;
				Console.WriteLine(biggestNumber);
		
				int testScore = 3;
				Console.WriteLine((testScore >= 70)? "Pass" : "Fail");
		
				//bool myBool = true;
				//if(myBool)
		
				int myInt = 3;
				if(!(myInt > 6))
				{
					Console.WriteLine("That is lower than expected");

				}
				else
				{
					Console.WriteLine("That is right");
				}        }
    }
}
