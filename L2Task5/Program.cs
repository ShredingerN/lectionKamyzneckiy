//Адаптируем решение задачи с нахождением позиции нужного элемента в массиве
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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    //int position = 0;
    //как обходить ситуацию, если в массиве нет элемента:
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
//Определяем новый массив, указываем сколько будет элементов [..]
//new int - дословно "создай новый массив с 10-ю элементами". По умалчанию массив будет заполнен нулями
int[] array = new int[10];

//заполняем массив
FillArray(array);
//искуственно добавляем несколько 3, чтобы оценить работу оператора break
array[4] = 3;
array[6] = 3;
//печатаем массив
PrintArray(array);
Console.WriteLine();
//здесь указан элемент массива, и мы ищем на какой он позиции (индекс)
int pos = IndexOf(array, 333);
Console.WriteLine(pos);
