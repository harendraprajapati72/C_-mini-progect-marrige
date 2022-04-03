using System;

namespace MarrigeCheck
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME HERE BY @studyhubtutorial.com Let's Play A game that never play before Haahahaaa.....!\n");
            


            Console.WriteLine("Here we are going to check you are able to marry or not hahahaa.......!");

            Console.WriteLine("Select 1 For Male , 2 for Female");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1: Console.WriteLine("You selected option 1 that is Male , Please enter your age : ");
                    int age= Convert.ToInt32(Console.ReadLine());
                    if (age<21)
                    {
                        Console.WriteLine(" Sorry... You are to Young , not able Marry ");
                    }
                    else if (age>=21 && age<50)
                    {
                        Console.WriteLine(" Chill... You Won the Game, able to Marry Enjoy your Life");
                    }else if (age>=50)
                    {
                        Console.WriteLine("Please go for Bhakti Bhajan Don't think about Marrige");
                    } 
                    break;

                case 2:
                    Console.WriteLine("You selected option 2 that is Female , Please enter your age : ");
                    int Fage = Convert.ToInt32(Console.ReadLine());
                    if (Fage< 19)
                    {
                        Console.WriteLine(" Sorry... You are to Young , not able Marry ");
                    }
                    else if (Fage >= 19 && Fage < 50)
                    {
                        Console.WriteLine(" Chill...  You Won the Game You, able to Marry Enjoy your Life");
                    }
                    else if (Fage >= 50)
                    {
                        Console.WriteLine("Please go for Bhakti Bhajan Don't think about Marrige");
                    }
                    break;
                   

                default:Console.WriteLine("Error 404!...Retry  Please select correct option ");
                    break;

            }

            Console.WriteLine(" \n\n \t\t\t\t\t\t\t\t\t ©2022 All right reserved by @studyhubtutorial.com");
        }
    }
}
