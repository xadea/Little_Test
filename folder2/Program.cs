//Найдите произведение пар чисел в одномерном массиве.//
// Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

int[] RandomArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}

void Product (int[] array)
{
    int[] product = new int [array.Length/2];
    for(int i = 0; i < array.Length/2; i++)
    {
        int prod = array[i]*array[array.Length-1-i];
        product[i] = prod;
    }  
    foreach (int i in product) Console.Write(i + " ");
}

 int[] myarray = new int [10];
 RandomArray(myarray);
 foreach(int i in myarray) Console.Write(i + ", ");
 Console.WriteLine();
 Product(myarray);
 
Console.WriteLine();
