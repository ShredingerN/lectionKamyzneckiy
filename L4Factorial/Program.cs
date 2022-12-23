//Пишем метод для факториала
double Factorial (int n)
{
    if(n==1) return 1;
    else return n*Factorial(n-1);
}

// // в скобках сразу указали значение n
// Console.WriteLine(Factorial(5));
// int - ограничен, получим переполнение типа данных
for (int i = 1; i < 40; i++)
{
    // Console.WriteLine(Factorial(i));
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
    
