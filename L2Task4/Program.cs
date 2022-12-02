//void - метод не возвращает ничего
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        //обращаемся к аргументу collection, и кладем туда целое случайное число
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

//метод, который будет печатать массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
//Определяем новый массив, указываем сколько будет элементов [..]
//new int - дословно "создай новый массив с 10-ю элементами". По умалчанию массив будет заполнен нулями
int[] array = new int[10];

//заполняем массив
FillArray(array);
//печатаем массив
PrintArray(array);
