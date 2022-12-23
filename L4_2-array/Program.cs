// // Двумерные массивы
// // 1. Строковый массив
// string[,] table = new string[2, 5];
// // обращение к элементу массива - индекс строки - 1, индекс позиции элемента - 2.

// table[1, 2] = "word";
// // обращение цикла по строкам
// for (int rows = 0; rows < 2; rows++)
// {
//     // обращение цикла по колонкам
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"--{table[rows, columns]}--");
//     }
// }
// 2. Числовой массив
int[,] matrix = new int[3, 4];
PrintArray (matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray (matrix);

void PrintArray (int[,] matr)
{
    for (int i = 0; i < 3; i++)
    {
        // обращение цикла по колонкам
        // вместо 3 и 4 можно использовать конструкцию matrix.GetLength(0) и matrix.GetLength(1) соотв.
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matr[i, j]}");
        }
        // Строка разделит массив и выведет его столбцами с троками, а не сплошником.
        Console.WriteLine();
        }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // обращение цикла по колонкам
        // вместо 3 и 4 можно использовать конструкцию matrix.GetLength(0) и matrix.GetLength(1) соотв.
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(1,10);
        }
        
    }
}