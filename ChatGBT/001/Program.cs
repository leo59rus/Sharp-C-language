//запрос мой
//Write me code in C# to fill a two-dimensional array with natural random numbers


// Create a two-dimensional array
int[,] array = new int[12,12];

// Create a Random object
Random random = new Random();

// Fill the array with random numbers
for (int i = 0; i < 12; i++)
{

   for (int j = 0; j < 12; j++)
   {
      array[i, j] = random.Next(1, 10);
       Console.Write(array[i,j] +  " ");
   }
   Console.WriteLine();
}
