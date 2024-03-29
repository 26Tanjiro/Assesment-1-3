using System;
using System.Linq;

namespace No ;

public static class Program
{
	public static void Main()
	{

	         
	  int t;
string u1;
Console.Write("Jake Joshua B. Peñalosa");
Console.Write("\n");
Console.Write("BSCpE1-1");
Console.Write("\n");
Console.Write("------------------------------------------------");
Console.WriteLine("\n             ***Time Converter**");
Console.Write("------------------------------------------------");
Console.Write("\n");
Console.Write(" Enter the Time : ");
t = int.Parse(Console.ReadLine());
Console.Write("\n");
Console.Write("**Please choose the following selection** ");
Console.Write(" [Seconds to Minutes] = sem");
Console.Write(" [Minutes to Hours] = mih");
Console.Write(" [Hours to Days] = hod");
Console.Write(" [Days to Months] = dam");
Console.WriteLine("\n");
Console.Write("Enter the unit of time to be converted: ");
u1 = Console.ReadLine();
Console.WriteLine("\n");
Console.Write("------------------------------------------------");
Console.WriteLine("Converted Time : ");
 
if (u1.Equals("sem", StringComparison.OrdinalIgnoreCase)) 
 {
    double sm= t/60;
 Console.Write(sm+", minutes.");
 }  
else if (u1.Equals("mih",StringComparison.OrdinalIgnoreCase))
 {
   double mh= t/60;
 Console.Write(mh+", hours.");  
 }
else if(u1.Equals("hod",StringComparison.OrdinalIgnoreCase))
 {
   double mh= t/24;
 Console.Write(mh+", days.");    	 
 }
else if(u1.Equals("dam",StringComparison.OrdinalIgnoreCase))
 {
   double dm= t/30.4;
 Console.Write(dm+", months.");  
 }
   }  
} 