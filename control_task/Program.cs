// // void Print(string[] arr)
// // {
// //     int size = arr.Length;

// //     for (int i = 0; i < size; i++)
// //     {
// //         Console.Write($"{arr[i]} ");
// //     }
// //     Console.WriteLine();
// // }

// // string[] FillArray(int size)
// // {   
// //     string[] arr = new string[size];

// //     for (int i = 0; i < size; i++)
// //     {
// //         arr[i] = new Random().Next();        
// //     }    
// //     return arr;
// // }

// // void  NewArray (string[] arr)
// // {
    
// //     if (x.Length <= 3).ToArray
// // }

// string Arr(string x)
// {
//     string result = x;
// }

// string[] array = {$"Москва", "Спб", "Красноярск", "Уфа", "22"};
// {
//     string[] arr = new string [size];
//     for (int i = 0; i < size; i++)
//     {
//         string x;
//         arr[0] = x;
//         if (x.Length <= 3)
//             return x;
//     }
// }

// Console.WriteLine(new string[arr]);


// // var resultArr = existArr.Where(x=>x.Length < 4).ToArray();

// // {
// //     string x;
// //     if (x.Length <= 3)
// //     return x;
// //     else i
// // }

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

string [] ShortNums (string[] arr)
{
    int size = arr.Length;
    int num_size = arr.Length[];
    string[] new_arr = new string[];

    for (int i = 0; i < size; i++)
        // new_arr[i] = arr[i] * arr[size - i - 1];
    {
        int num_size = arr.Length;
        if (new_arr[num_size] <= 3)
            // new_arr[num_size -1] = arr[flex_size - 1];

        return new_arr;
    }
}

int[] arr_1 = MassNums(5);
Print(arr_1);
int[] new_arr_1 = ShortNums(arr_1);
Print(new_arr_1);