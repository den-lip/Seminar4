﻿int Prompt (string message)
{
   Console.Write (message); 
   string readInput = Console.ReadLine (); 
   int result = int.Parse (readInput); 
   return result; 
}
int Power(int powerBase, int exponent)
{
   int power = 1;
   for (int i = 0; i < exponent; i++)
   {
       power *= powerBase;
   }
   return power;
}

bool ValidateExponent (int exponent)
{
   if (exponent < 0)
   {
       Console.WriteLine("Показатель не должен быть меньше нуля!");
       return false;
   }
return true;
}
int powerBase = Prompt ("Bведите основание: ");
int exponent = Prompt ("Введите показатель: ");
if (ValidateExponent (exponent))
{
   System.Console.WriteLine ("Число " + powerBase +  " в  степени " + exponent + " paвно" + Power (powerBase, exponent));
}