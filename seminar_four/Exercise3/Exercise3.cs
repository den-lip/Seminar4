Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
Console.Write("Введите любое число (A): ");
int enterNumber = Convert.ToInt32(Console.ReadLine());

 int[] array = new int[enterNumber];
 for (int i = 0; i < enterNumber; i++)
  {
     array[i] = new Random().Next(enterNumber+1);
     Console.Write(array[i] + "; ");
  }
Console.WriteLine();