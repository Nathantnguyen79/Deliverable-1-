namespace Deliverable_1_
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an interger number between 1 and 100");
            Boolean done = false;
            while (!done)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input >= 1 && input <= 100)
   
                    
                        {
                            Console.WriteLine("Please specify series: Odd or Even");
                            string series = Console.ReadLine();
                            if (series == "Odd")
                                for (int i = 1; i <= input; i = i + 2)
                                    Console.WriteLine(i);
                            else
                                for (int i = 2; i <= input; i = i + 2)
                                    Console.WriteLine(i);
                            done = true;
                        }
                    else
                    {
                        Console.WriteLine("Please enter an interger number between 1 and 100");
                    }
                      
                }
               
                catch
                {
                    Console.WriteLine("Please enter a valid interger number");
                }
            }
            
        }
    }
}