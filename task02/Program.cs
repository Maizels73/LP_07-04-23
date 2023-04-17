// Написать программу, выдающую дни недели по номеру
Console.WriteLine ("INPUT NUM_day");
int num1 = Convert.ToInt32(Console.ReadLine());
if ((num1 < 1) || (num1 >7)) {  
    Console.WriteLine ($"ERROR DAY number"); 
    }
    else {
        switch (num1) {
    case 1:
    Console.WriteLine ($"Monday"); 
    break;
    case 2:
    Console.WriteLine ($"Tuesday"); 
    break;
    case 3:
    Console.WriteLine ($"Wednesday"); 
    break;
    case 4:
    Console.WriteLine ($"Thursday"); 
    break;
    case 5:
    Console.WriteLine ($"Friday"); 
    break;
    case 6:
    Console.WriteLine ($"Saturday"); 
    break;
    case 7:
    Console.WriteLine ($"Sunday"); 
    break;

        }
    }