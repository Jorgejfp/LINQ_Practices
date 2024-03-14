using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
LINQ :Language Integrated Query
        A set of powerful features in C# that allow you 
        to query and manipulate data from different data sources
        using SQL-like syntax. 
Types of LINQ
        LINQ to Objects ( collection of objects)
        LINQ to DataSet (Note : Lab2 and Lab3)
        LINQ to XML
        LINQ to SQL
        LINQ to Entities

LINQ Syntax
        1. Query Syntax
        2. Method Syntax [Extension methods and Lamda Expressions]
        3. Mixed Mode Syntax

How to write a LINQ query?
        Step 1: Specify the data source
        Step 2: Write the query
        Step 3: Execute the query
 */

namespace LINQ_To_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[] {1,2,5,6,7,12,12,23,100,23,4,5 };

            // Question 1 : Write a code segment to display all the even numbers from the array
            Console.WriteLine("Question 1 : Write a code segment to display all the even numbers from the array\n");

            foreach (int num in intArr)
            {
                if (num % 2 == 0) { Console.WriteLine(num); }
            }

            // LINQ
            Console.WriteLine("\nLINQ\n");
            var listevenNumbers = from num in intArr
                                  where num % 2 == 0
                                  select num;
            foreach (int num in listevenNumbers) {  Console.WriteLine(num); }

            Console.WriteLine("\n\n");
            var listOddNumbers2 = intArr.Where(num => num % 2==0).ToList ();
            foreach (int num in listOddNumbers2) {  Console.WriteLine(num); }

            //Create and display the list of all the distinct numbers taken from the array
            //LINQ

            Console.WriteLine("\nCreate and display the list of all the distinct numbers taken from the array. LINQ\n");

            var distinctNumbers = intArr.Distinct().ToList();
            foreach (int num in distinctNumbers) {Console.WriteLine(num);}

            Console.ReadKey();
        }
    }
}
