void Task2()
{
Console.WriteLine("Введите первое число:");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number_b = Convert.ToInt32(Console.ReadLine());

if (number_a < number_b)
{
     Console.WriteLine("Второе число больше первого");
}
else
{
     Console.WriteLine("первое число больше второго");
}
}


void Task4()
{
 Console.WriteLine("Введите первое число:");
 int number_a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число:");
 int number_b = Convert.ToInt32(Console.ReadLine());  
 Console.WriteLine("Введите третье число:");
 int number_c = Convert.ToInt32(Console.ReadLine());

 int max = number_a;

 if (number_a > max) max = number_a;

 if (number_b > max) max = number_b;
       
 if (number_c > max) max = number_c;
                       
 Console.Write("max = ");
 Console.WriteLine(max);
        
}
