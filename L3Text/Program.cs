// Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.

//Вид 4

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого"
            + "Винценгероде, вы бы взяли приступом согласие"
            + "прусского короля. Вы так красноречивы. Вы дадите мне чаю?";
//Возвращается строка, на входе текст, старый символ, новый символ
string Replace(string text, char oldValue, char newValue)
{
    //Задаем пустую строку для результата
    string result = String.Empty;
    //Получеам длину стоки
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        //text [i] - обращение к символу по порядку
        //ищем совпадение, меняем символ
        if (text[i] == oldValue) result = result + $"{newValue}";
        //нет совпадения - символ прежний
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);