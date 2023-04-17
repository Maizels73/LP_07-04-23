// See https://aka.ms/new-console-template for more information
Console.WriteLine ("INPUT number");
int num1 = Convert.ToInt32(Console.ReadLine());
int num_start = num1 * -1;
  for (int i = num_start; i < num1 +1; i++)
    {
        Console.Write ($"{i} "); 
    }
