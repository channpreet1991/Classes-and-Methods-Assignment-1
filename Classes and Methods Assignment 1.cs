using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
  public class Class1{
    //takes an int, doubles it and returns the result
    public int method_one(int value){
      return value + value;
    }
    
    //takes a decimal, square it and returns the result
    public Decimal method_one(Decimal value){
      return value * value;
    }
    
    //takes a string, coverst it to int, triples it and returns the result
    public int method_one(string value){
      int result = 0;
      try 
      {
        int x = Convert.ToInt32(value);
        result = 3 * x;
      }
      catch (FormatException) {
        Console.WriteLine("Input string is invalid.");
      }
      
      return result;
    }
  }
  
	public class Program
	{
		public static void Main(string[] args)
		{
		  Class1 c1 = new Class1();
		  int first = c1.method_one(4);
			Console.WriteLine("method_one method with integer 4 = " + first);
			
			Class1 c2 = new Class1();
		  Decimal second = c2.method_one(4m);
			Console.WriteLine("method_one method with decimal 4m = " + second);
			
			Class1 c3 = new Class1();
		  int third = c3.method_one("4");
			Console.WriteLine("method_one method with string 4 = " + third);
			
		}
	}
	
}