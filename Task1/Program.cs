#region Imtahan Qiymetlerinin daxil olunmasi
//Console.WriteLine("Imtahan qiymetinizi daxil edin");
//int number = int.Parse(Console.ReadLine());
//if (number >= 91 && number <= 100)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:A");
//}
//else if (number >= 81 && number <= 90)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:B");
//}
//else if (number >= 71 && number <= 80)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:C");
//}
//else if (number >= 61 && number <= 70)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:D");
//}
//else if (number >= 51 && number <= 60)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:E");
//}
//else if (number < 51 && number >= 0)
//{
//    Console.WriteLine("Imtahandan Kesildiniz");
//}
//else if ( number < 0 || number > 100)
//{ 
//    Console.WriteLine("Imtahan qiymetinizi yeniden daxil edin");
//}
#endregion
#region Positive and Negative
//int[] arr = { 2, 3, -9, 8, -10, 12, 35, -20 };
//int p = 0;
//int f = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > 0)
//    {
//        p++;
//    }
//    else
//    {
//        f++;
//    }
//}
//Console.WriteLine(p + ":Positive");
//Console.WriteLine(f + ":Negative");
#endregion
#region En boyuk ededin tapilmasi
int[] arr = { 1, 4, 7, 23, 45, 9876, -17, 236 };
int biggest = arr[0];
for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] > biggest) 
	{
		biggest= arr[i];
	}
}
Console.WriteLine(biggest);
#endregion 