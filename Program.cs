// Из имеющегося массива строк , формирует массив из строк длина которых составляет 3 и менее знака

   class Program
   {
    public static void Main()
    {
      
        Console.WriteLine("Введите строку №1");
        string? str1 = Console.ReadLine();
        Console.WriteLine("Введите строку №2");
        string? str2 = Console.ReadLine();
        Console.WriteLine("Введите строку №3");
        string? str3 = Console.ReadLine();
        Console.WriteLine("Введите строку №4");
        string? str4 = Console.ReadLine();
        CountString(str1);
        CountString(str2);
        CountString(str3);
        CountString(str4);
    }
    public static void CountString(string? strin)
    {
        if(strin.Length<=3)
        {
            Console.Write("{strin}");
        }
    }
   } 