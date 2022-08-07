// Task 1
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }


// int a1 = 1;
// int b1 = 2;
// int c1 = 999;
// int a2 = 8;
// int b2 = 4;
// int c2 = 34;
// int a3 = 49;
// int b3 = 24;
// int c3 = 66;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
// Console.WriteLine(max);

// Task 2

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }
// //              0  1  2  3  4  5  6  7  8
// int[] array = {11,32,56,87,45,34,87,45,23};
// array[0] = 12;
// Console.WriteLine(array[0]);

// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(max);


// Task 3

// int[] array = {1, 12, 31, 4, 15, 18, 16, 17, 18};

// int n = array.Length;
// int find = 18;

// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }
// если одинаковых цифр будет 2 или больше, то он укажет их всех, для того чтобы показало только 1, мы используем break

// Task 4

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    Int16 position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int position = 0;
    int index = 0;
// если мы будем искать индекс числа которого нет в масиве, то его позиция будет равно 0, так как мы поставили position =0
// поэтому вместо position = 0 мы поставим position = -1 и если в консоле нам покажет -1, значит такого элемента нет в массиве.
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array , 4);
Console.WriteLine(pos);