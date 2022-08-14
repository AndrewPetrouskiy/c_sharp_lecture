// view 1

void Method()
{
    Console.WriteLine("i'm an author!");
}
// Method();



//  view 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("The text of message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("The text of message", 4);

// view 3

int Method3()
{
    return DateTime.Now.Year;
}

// int year = Method3();
// System.Console.WriteLine(year);




//  view 4

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

// string res = Method4(10 , "a");
// Console.WriteLine(res);


// view 4.2

string Method41(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

// string res = Method41(10 , "b");
// Console.WriteLine(res);


//  next task 1

// for (int i = 1; i <= 10; i++)
// {
//     for(int j = 1; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i *j}");
//     }
//     System.Console.WriteLine();
// }


// next task 2

string text = "Любил я вас, но в чем смылс, когда вы далеко от нас. пара пара пам!!!!";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}



// string newText = Replace(text , ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();
// string newText1 = Replace(newText , 'к', 'К');
// Console.WriteLine(newText1);

// Console.WriteLine();
// string newText2 = Replace(newText1 , 'с', 'С');
// Console.WriteLine(newText2);


// next task 3

// int[] arr = { 1, 3, 6, 3, 4, 5, 6, 9, 7, 8, 3, 1, 4, 6 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }


// void SelectionSort(int[] array)
// {

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temperary = array[i]; 
//         array[i] = array[minPosition];
//         array[minPosition] = temperary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);


// next task 3 solution 3


int[] arr = { 1, 3, 6, 3, 4, 5, 6, 9, 7, 8, 3, 1, 4, 6 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temperary = array[i]; 
        array[i] = array[maxPosition];
        array[maxPosition] = temperary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);