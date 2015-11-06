// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;

namespace Model
{
	public class People
	{
		delegate double ProgressDelegate(double param1,double param2);

		public People ()
		{
		}

		public void showForEach(){
			double [,] hillHeight = {{1,2,3,4},{2,3,4,5},{3,4,5,6}};
			foreach(double height in hillHeight){
				Console.WriteLine("{0}",height);
			}

		}

		public void operatorString(){
			string myString = "A String";
			char[] mychars = myString.ToCharArray();
			foreach(char character in mychars){
				Console.WriteLine("{0}",character);
			}
			
		}

		public int maxValue(int [] intArray,out int maxIndex){
			int maxVal = intArray[0];
			maxIndex = 0;
			for(int i = 1;i<intArray.Length;i++){
				if (intArray[i] > maxVal){
					maxVal = intArray[i];
					maxIndex = i;
				}
			}
			return maxVal;
		}

		static double Multiply(double param1,double param2){
			return param1*param2;
		}

		static double Divide(double param1, double param2){
			return param1/param2;
		}
		public void delegateTest(){
			ProgressDelegate progress;
			Console.WriteLine("Enter 2 numbers separated with a comma:");
			string input = Console.ReadLine();
			int commaPos = input.IndexOf(',');

			double param1 = Convert.ToDouble(input.Substring(0,commaPos));
			double param2 = Convert.ToDouble(input.Substring(commaPos+1,input.Length - commaPos-1));

			Console.Write("Enter M to multiply or D to divide:");
			input = Console.ReadLine();
			if( input == "M"){
				progress = new ProgressDelegate(Multiply);
			}else{
				progress = new ProgressDelegate(Divide);
			}
			Console.WriteLine("Result: {0}",progress(param1,param2));
			Console.ReadKey();
		}
	}
}

