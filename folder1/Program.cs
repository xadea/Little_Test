
int[] RandomArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1, 200);
    }
    return array;
}

void Comparation (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 100) 
        {
            if (array[i] > 9) count=count+1;
        } 
       
    }
       Console.WriteLine(count);
}  


 int[] myarray = new int [123];
 RandomArray(myarray);
 // foreach(int i in myarray) Console.Write(i + ", ");
 Console.WriteLine();
 Comparation(myarray);
 
Console.WriteLine();