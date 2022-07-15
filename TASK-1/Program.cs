int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    for(int j = 0; j < size; j++) 
    {
       Console.Write($"Input {j + 1} element: "); 
       newArray[j] = Convert.ToInt32(Console.ReadLine()); 
    }
    Console.WriteLine();  
     return newArray; 
}
int Sumelements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)

        if(array[i]>0) sum++;
    return sum;
}
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
 
Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateArray(size);
ShowArray(array);
int SumEL = Sumelements(array);
Console.WriteLine("Positive sum is " + SumEL);
