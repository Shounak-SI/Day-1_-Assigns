using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Day1_Assigns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            /*Console.WriteLine("Enter the length !");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[n];

            for (int i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = n-1;  i >=0; i-- ) {
                Console.WriteLine(num[i]);
            }*/


            //2
            /*Console.WriteLine("Enter the length !");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[n];

            int sum =0;

            for (int i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());

                sum = sum + num[i];
            }

            Console.WriteLine(sum);*/


            //3
            /*int[] n = new int []{ 1, 2, 3 };

            int[] n2 = new int[n.Length] ;

            for (int i = 0 ; i < n.Length ; i++ )
            {
                n2[i] = n[i];
            }


            for (int i = 0 ;i < n2.Length ; i++ )
            {
                Console.WriteLine(n2[i] );
            }*/

            //4
            /*int i, pos, n;
            int[] arr1 = new int[50];



            Console.Write("\n\nDelete an element at desired position from an array :\n");
            Console.Write("---------------------------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            *//* Stored values into the array*//*
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nInput the position where to delete: ");
            pos = Convert.ToInt32(Console.ReadLine());
            *//*---- locate the position of i in the array -------*//*
            i = 0;
            while (i != pos - 1)
                i++;
            *//*---- the position of i in the array will be replaced by the 
                   value of its right *//*
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");
        }*/

            //5
            /*Console.Write("\nenter number of students :\n");

            int[] n = new int[Convert.ToInt32(Console.ReadLine())];
            Console.Write("---------------------------------------------------------\n");

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("marks of student", n[i] = Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }

            int max=0;
            for (int i = 0; i < n.Length; i++)
            {
                
                    if (max < n[i])
                {
                    max = n[i];
                }
            }
            
            Console.WriteLine(max);
            int sum = 0;
            for (int i = 0;i < n.Length; i++)
            {
                sum += n[i];   
            }

            int avg = sum/ n.Length;

            Console.WriteLine(avg);


        }*/


            ///STRINGS
            ///Write a program that counts the number of occurrences of a particular character in a line of
            //text.
            //1
            /*String s = Console.ReadLine();

            int count = 0;

            char c= Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < s.Length; i++){
                if (s[i].Equals(c)) 
                {
                    count++;
                }

                
                

            }
            Console.WriteLine(count);*/


            //2Write a program that reads a string and rewrite it in alphabetical order. For example the
            // word STRING should be written as GINRST.

            /*String s = Console.ReadLine();

            
            char[] c = new char[s.Length];
            
            for (int i = 0; i < s.Length; i++)
            {
                c[i] = s[i];
            }


            for (int i = 0;i < c.Length; i++)
            {
                Console.Write(c[i]);
            }

            foreach (char a in s)
            {

            }
            Console.ReadKey();*/

            //3 Write a program in C# Sharp to extract a substring from a given string

            /* String s = Console.ReadLine();

             char[] delimiters = {','};

             String[] s2 = s.Split(delimiters);

             foreach (string item in s2)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine(s2);*/


            //4 Write a program in C# Sharp to search the position of a substring within a string


            /*String s = Console.ReadLine();

            Console.WriteLine(s.IndexOf((Convert.ToChar(Console.ReadLine()))));*/


            //5 Write a C# Sharp program to compare two substrings that only differ in case. The first
            // comparison ignores case and the second comparison considers case

            /*String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();

            Console.WriteLine(s1.Equals(s2));

            Console.WriteLine(s1.ToLower().Equals(s2.ToLower()));*/

            //CONTROL STRUCTURES
            //6 Write a program named CheckCredit that prompts users to enter a purchase price for an
            /*item.If the value entered is greater than a credit limit of $10,000, display an error message;
            otherwise, display Approved.*/

            /*
                        Console.WriteLine("ENter amount");
                        int price = Convert.ToInt32(Console.ReadLine());

                        if (price > 10000) {

                            Console.WriteLine("Error");
                        }
                        else
                        {
                            Console.WriteLine("Have a good day");
                        }*/


            //7 Write an application that continuously prompts a user for a series of daily high
            /*temperatures until the user enters a sentinel value(A value to denote end of input ). Valid
            temperatures range from 20 through 130 Fahrenheit.When the user enters a valid
temperature, add it to a total; when the user enters an invalid temperature, display an error
message.Before the program ends, display the number of temperatures entered and the
average temperature.*/

            Console.WriteLine("enter temp");
            double temp = Convert.ToDouble(Console.ReadLine());

            double total=0;

            while (temp>0)
            {
                
                while ((temp >= 20 || temp < 130))
                    {
                    total += temp;
                     Console.WriteLine(total);


                }
            }

                Console.WriteLine("error");
            













        }
    }
}