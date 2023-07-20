{
    int[] array = { 1, 2, 3, 4, 5 };

    Console.WriteLine("Исходный массив: {0}", GetArrayString(array));

    int[] productArray = new int[array.Length / 2];

    for (int i = 0; i < array.Length / 2; i++)
    {
        productArray[i] = array[i] * array[array.Length - 1 - i];
    }

    Console.WriteLine("Массив произведений пар чисел: {0}", GetArrayString(productArray));
}

static string GetArrayString(int[] array)
{
    return "[" + string.Join(" ", array) + "]";
}