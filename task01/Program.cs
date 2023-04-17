Console.WriteLine ("INPUT NUM1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("INPUT NUM1");
int num2 = Convert.ToInt32(Console.ReadLine());
int num2_sq = num2 * num2;
if (num1 == num2_sq) { 
    Console.WriteLine ($"{num2} * {num2} = {num1}"); 
    }
    else {
    Console.WriteLine ($"{num2} * {num2} <>{num1}");     
    }
