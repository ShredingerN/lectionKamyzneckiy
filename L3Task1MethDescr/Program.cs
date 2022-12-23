// Вид 1
void Method1() // нет аргументов
{
    Console.WriteLine("Author...");
}
// как вызвать метод

Method1();

//Вид 2
void Method2(string msg) //аргумент принят
{
    Console.WriteLine(msg);
}
Method2("текст сообщения");

void Method21(string msg, int count) //аргумент принят, именноеванные аргументы
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("текст ", 4);
//Method21(msg: "текст ", count: 4);

//Вид3 (обязательно указываем тип данных)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3(); //положен результат метода в переменную
Console.WriteLine(year); // используем результат

//Вид4
string Method4(int count, char c)//возвращаем строку, передаем int и сhar (можно указать string)
{
    int i = 0;
    //указываем результат, сначала он пустой
    string result = "";
    //string result = String.Empty

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
//создаем переменную и кладем рещультат выполнения метода, присваивая переменным значения
string res = Method4(10, 'z'); //в char кавычки одинарные!!!!!
Console.WriteLine(res);

//Вид4
string Method41(int count1, char cd)//возвращаем строку, передаем int и сhar (можно указать string)
{
    //указываем результат, сначала он пустой
    string result = "";
    //string result = String.Empty
    for (int i = 0; i < count1; i++)
    {
        result = result + cd;
    }
    return result;
}
//создаем переменную и кладем рещультат выполнения метода, присваивая переменным значения
string res1 = Method41(10, 'n'); //в char кавычки одинарные!!!!!
Console.WriteLine(res1);