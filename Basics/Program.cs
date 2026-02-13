using System;
using System.Diagnostics;
using System.Security.Authentication.ExtendedProtection;
using System.Linq;

namespace Basics
{
    public class Program
    {
        public static void Main()
        {
            // Console.WriteLine("Hey! This is a program template.");

            // Console.Write("What's your name bro: ");
            // String personName = Console.ReadLine();

            // Console.Write("What's your age buddy: ");
            // int personAge = Convert.ToInt32(Console.ReadLine());
            
            // Console.Write("What is it that interest you? ");
            // String personInterest = Console.ReadLine();

            // if(personAge <= 18)
            // {
            //     Console.WriteLine("You are not old enough to submit this form!");
            // }
            // else
            // {
            //     Console.WriteLine("Your form has been submitted successfully!! ");
            // }

                // string myName = "Shivam";
                // Console.WriteLine($"What is your name?: {myName}");
                    // // Console.WriteLine("What is your name?:" + myName);
                    // int x = 5;
                    // int y = 8;
                    // Console.WriteLine("The maximum value between x & y is: " + Math.Max(x,y));
                    // Console.WriteLine("The minimum value among the x & y is: " + Math.Min(x,y));
                    // Console.WriteLine("The absolute value of x is: " + Math.Abs(-3.5));
                    // Console.WriteLine("The sqrt of 97 is :" + Math.Sqrt(97));
                    // Console.WriteLine("The rounded off figure of the number 39.668 is: " + Math.Round(39.668));


                    //TO TAKE INPUT FROM THE USER AS INT DATA TYPE AND FIND ITS SQRT//

                    // Console.Write("Enter the number you would like to find the root for: ");
                    // int userRoot = Convert.ToInt32(Console.ReadLine());
                    // Console.WriteLine("The sqrt of the give number is :" + Math.Sqrt(userRoot));

                    //TO FIND THE LENGTH OF A STRING

                    // String Username = "myUsernameisofmanycharacters";
                    // Console.WriteLine("The length of this string is :" + Username.Length);
                    // Console.WriteLine("Text converted to uppercase: "+ Username.ToUpper());
                    // Console.WriteLine("Text changed to Lowercase text: " + Username.ToLower());
                        //STRING CONCATENATION
                    //     Console.WriteLine("Enter your firstname: ");
                    // String firstName = Convert.ToString(Console.ReadLine());
                    // Console.WriteLine("Enter your lastname: ");
                    // String lastName = Convert.ToString(Console.ReadLine());
                    // // // String nName = firstName +" " + lastName;
                    // // String nName = String.Concat(firstName,lastName);
                    // // Console.WriteLine("The name of the person responsible is :" + nName);
                    // String nName = $"The name is : {firstName} {lastName}";
                    // Console.WriteLine(nName);
                    
            //         int makeOverAge = 18;
            //         Console.WriteLine("Enter Your Age: ");
            //         int myAge = Convert.ToInt32 (Console.ReadLine());

            // if (myAge >= makeOverAge)
            // {
            //     Console.WriteLine("You are old enough to makeover!!");
            // }
            // else
            // {
            //     Console.WriteLine("You are too young for this buddy!, Enjoy your life now.");
            // }

            //SWITCH CASE, BREAK, DEFAULT , USE CASES...
            //     Console.WriteLine("Choose your hobbie: 1.Reading, 2. Eating, 3. Trekking, 4. Swimming");
            //     int myHobbie = Convert.ToInt32(Console.ReadLine());

            // switch (myHobbie)
            // {
            //     case 1:
            //     Console.WriteLine("Ohh you love reading, I think you should read \"The invisible Man\" as well.");
            //     break;

            //     case 2:
            //     Console.WriteLine("Wow!, you love to eat, have you ever tried Samosas...");
            //     break;

            //     case 3:
            //     Console.WriteLine("Ohk!, you go on trekking, Mount Everest, Duhh!!");
            //     break;

            //     case 4:
            //     Console.WriteLine("Yes, even I love swimming but I can't swimm, Lol!");
            //     break;

            //     default:
            //     Console.WriteLine("You made an out of order choice, plz check the options and re-enter the available choices.");
            //     break;
            //         int i = 5;
            // // while (i < 8)
            // // {
            // //     Console.WriteLine(i);
            // //     i++;
            // // }
            // do
            // {
            //     Console.WriteLine(i);
            //         i++;
            // } while(i<2);

            //     for(int i = 2; i <= 30; i = i+2)
            // {
            //     Console.WriteLine(i); 
                
            // }
            // PRINTING ALL EVEN NUMBERS BW 1 TO 100.
            // for(int i = 1; i<=100; i++)
            // {
            //     if(i%2 == 0)
            //     {
            //        Console.WriteLine(i);
            //     }
            //     else
            //     {
            //         Console.WriteLine("This is an Odd number");
            //     }
                


            // }
            //  for (int i = 19; i<=190; i=i+19)
            // {
               
            //         Console.WriteLine(i);
                
                
            // }
            // PRINT THE TABLE OF N WHERE N WILL BE THE USER INPUT.

            // Console.WriteLine("Enter your desired number to print the table: ");
            // int myNum = Convert.ToInt32(Console.ReadLine());

            // for (int i = myNum; i<=myNum*10; i = i + myNum)
            // {
            //     Console.WriteLine(i);
            // }
            //to print the table in typical format;
            // for (int i = 1; i<= 10; i++)
            // {
            //     Console.WriteLine($"{myNum} x {i} = {myNum * i}");
            // }   

            //PRINT THE AP SERIES 4,7,10,13,16,......N

            // int firstTerm = 4;
            // int secondTerm = 7;
            // Console.WriteLine("Enter a number n: ");
            // int numberOfTerms = Convert.ToInt32(Console.ReadLine());
            // int diffD = secondTerm - firstTerm;

            // int lastTerm = (3 * numberOfTerms) + 1;

            // for(int i = 4; i<= lastTerm; i = i + diffD)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("Enter a number n: ");
            //     int n = Convert.ToInt32(Console.ReadLine());
            //     int a = 4;
            //     for(int i = 1; i <= n; i++)
            // {
                
            //     if(i == 4)
            //     {
            //         break;
            //     }
            //     Console.WriteLine(a);
            //     a = a + 3;
            // }

                // int[] myNum = {1,2,5,6,4,5};

            //     // Console.WriteLine($"{myNum[3]} + {myNum[4]}"); 

            //         string[] cars;
            //         cars  = new string[5]
            //      {"volvo", "Hyundai", "Honda", "BMW", "Punch"};
            //     //     Console.WriteLine(cars[4]);
            //     //     cars[4] = "NanoCar";
            //     //     Console.WriteLine("but my favorite car is: " + cars[4]);
            //     //         Console.WriteLine("The length of this array is:" + cars.Length);

            // //         for(int i = 0; i<cars.Length; i++)
            // // {
            // //     Console.WriteLine(cars[i]);
            // // }

            // Array.Sort(cars);
            // foreach(string i in cars)
            // {
            // //     Console.WriteLine(i);
            // // }

            // int[] myNum = {4,5,6,3,5,4,5};
            // Array.Sort(myNum);
            // foreach(int i in myNum)
            // {
            //     Console.WriteLine(i);
                

            // }
            //     Console.WriteLine("the length of this array is: " + myNum.Length);
            //     Console.WriteLine(myNum.Min());
            //     Console.WriteLine(myNum.Max());
            //     Console.WriteLine("The sum of this array is: " + myNum.Sum());

            int[,] myMatrix;
            myMatrix = new int[,]
            { {1,5,3,} , {5,3,5} };
            Console.WriteLine(myMatrix[0,1]);
            }
        }
    }
