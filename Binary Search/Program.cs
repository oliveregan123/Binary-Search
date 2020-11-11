using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n;
            int[] x = new int[] { 1, 3, 6, 7, 10, 16, 19, 300, 302 };
            Console.WriteLine("what number are you looking for?");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 10)
            {
                Console.WriteLine("Your number is 10");
            }
            else
            {
                if (n < 10)
                {
                    if (n == 3)
                    {
                        Console.WriteLine("Your number is 3");
                    }
                    else
                    {
                        if (n < 3)
                        {
                            Console.WriteLine("Your number is 1");
                        }
                        if (n > 3)
                        {
                            if (n == 6)
                            {
                                Console.WriteLine("Your number is 6");
                            }
                            else
                            {
                                Console.WriteLine("Your number is 7");
                            }
                        }
                    }
                }
                else
                {
                    if (n == 19)
                    {
                        Console.WriteLine("Your number is 19");
                    }
                    else
                    {
                        if (n < 19)
                        {
                            Console.WriteLine("Your number is 16");
                        }
                        else
                        {
                            if (n == 300)
                            {
                                Console.WriteLine("Your number is 300");
                            }
                            else
                            {
                                Console.WriteLine("Your number is 302");
                            }
                        }
                    }
                }
            }

        }
    }
}

                    
                
            
        
    
