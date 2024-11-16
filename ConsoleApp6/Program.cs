using System;
using static System.Console;
using static System.Math;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.String;



class MainClass
{


    static string[] ProgramPets(int i)
    {
        var Jojo = new string[i];
        for (int j = 1; j < i + 1; j++)
        {
            Console.Write("Введите кличку {0} питомца: ", j);
            string ruru = Console.ReadLine();
            ruru.ToArray();
        }
        return Jojo;
    }

    static string[] ProgramColor(int i)
    {
        var Jojo = new string[i];
        for (int j = 1; j < i + 1; j++)
        {
            Console.Write("Введите {0} цвет: ", j);
            string ruru = Console.ReadLine();
            ruru.ToArray();
        }
        return Jojo;
    }

    static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum));
        {
            if (intnum > 0 )
            {
                corrnumber = intnum;
                return false;
            }
        }
        { 
            corrnumber = 0;
            return true;
        }
    }

    public static void Main(string[] args)
    {
        (string name, string name2, string age, string pets, string pets_Lenght, string colors_Lenght) Cortage;

        Console.Write("Введите ваше имя: ");
        Cortage.name = Console.ReadLine();

        Console.Write("Введите вашу фамилию: ");
        Cortage.name2 = Console.ReadLine();

        int intage, intage1, intage2;

        do
        {
            Console.Write("Введите ваш возраст: ");
            Cortage.age = Console.ReadLine();
        }
        while (CheckNum(Cortage.age, out intage));

        
        Console.Write("Есть ли у вас домашнии питомцы (да/нет): ");
        Cortage.pets = Console.ReadLine();

        Cortage.pets_Lenght = "";
        if (Cortage.pets == "да")
        {
            do
            {
                Console.Write("Введите их кол-во: ");
                Cortage.pets_Lenght = Console.ReadLine();
            }
            while (CheckNum(Cortage.pets_Lenght, out intage1));
        }
        ProgramPets(Convert.ToInt32(Cortage.pets_Lenght));

        Cortage.colors_Lenght = "";
        do
        {
            Console.Write("Сколько у вас любимых цветов?: ");
            Cortage.colors_Lenght = Console.ReadLine();
        }
        while (CheckNum(Cortage.colors_Lenght, out intage2));
        ProgramColor(Convert.ToInt32(Cortage.colors_Lenght));
    }
}