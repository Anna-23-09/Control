string[] Array = {"Москва", "Уфа", "Спб",  "22",  "Красноярск"};
void ShowArray(string[] array)

{
    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " ");
    Console.WriteLine();

}
string[] NotMoreThanThreeSignes(string[] arr)
{
    int size = arr.Length;
    string[] new_arr = new string [arr.Length];
      
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= 3)
            {
            new_arr[i] = arr[i];
            }
        
    }
    return new_arr;
}

ShowArray(Array);
string[] new_arr = NotMoreThanThreeSignes(Array);
ShowArray(new_arr);





