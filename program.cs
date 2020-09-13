using System;
using System.Text;

namespace RealProgram
{
    class Program
    {

    	/*
    	This is an example of code optimisation based on given requirement.
    	The requirement: Print a christmas tree which height is n

    	There are various way to fulfil the requirement, however, it is crucial for a programmer to understand the
    	requirement clearly and provide an solution which are better fit than other to the requirement
    	*/
        static void Main(string[] args)
        {
        	string o = "Optimised";
        	string no = "Not optimised";
        	int n = 6;

        	Console.WriteLine(o);
        	foreach(char e in o ) Console.Write("=");
        	Console.WriteLine("\n\n");
        	Optimised(n);
        	Console.WriteLine("\n\n");

        	Console.WriteLine(no);
        	foreach(char e in no) Console.Write("=");
        	Console.WriteLine("\n\n");
        	Console.WriteLine();
        	NotOptimised(n);

        	Console.WriteLine("\nCheck the source code to see the difference!");
        }

        private static void Optimised(int n)
        {
        	// Use only on loop => O(n)
        	string ast = "*";
        	int total = (n*2)-1;
        	int half = total/2;
        	string template = "";
    		template = template.PadRight(total, ' ');
        	for (int i=n-1; i>=0; i--)
        	{
        		int start = half-(ast.Length/2);
        		StringBuilder dummy = new StringBuilder(template);
        		dummy.Remove(start, ast.Length);
        		dummy.Insert(start, ast);
        		Console.WriteLine(dummy.ToString());
        		ast += "**";
        	}
        }

        private static void NotOptimised(int n)
        {
        	// Use nested loop (2 loop) => O(n^2)
        	int counter = 1;
        	int half = ((n*2)-1)/2;
        	for(int i=0; i<n; i++)
        	{
        		int chalf = counter/2;
        		for(int j=0; j<(n*2)-1; j++)
        		{
        			if (j>=half-chalf&&j<=half+chalf)
        				Console.Write("*");
        			else
        				Console.Write(" ");
        		}
        		counter += 2;
        		Console.WriteLine("");
        	}
        }		
    }
}