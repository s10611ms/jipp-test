using System;

class Program
{
    static void Main()
    {
        // Pierwszy program - rozgrzewka

        // Zadanie 2 - Wczytywanie i wyświetlanie danych
        Console.WriteLine("Pierwszy program - rozgrzewka - Zadanie 2");
        Console.WriteLine("Podaj swoje imię:");
        var name = Console.ReadLine();
        Console.WriteLine("Hello " + name);

        // Zadanie 3 - Znalezienie i naprawienie błędu
        Console.WriteLine("Pierwszy program - rozgrzewka - Zadanie 3");
        int resultFix = 5 + 9;  // Poprawiona wersja (brakujący średnik)
        Console.WriteLine("Wynik: " + resultFix);

        // Operatory

        // Zadanie 1 - Deklaracja zmiennych
        Console.WriteLine("\nOperatory - Zadanie 1");
        int number = 42;
        float money = 99.99f;
        string text = "Cześć!";
        bool isLogged = true;
        char myChar = 'A';
        decimal price = 199.99m;

        Console.WriteLine("Liczba: " + number);
        Console.WriteLine("Kwota: " + money);
        Console.WriteLine("Tekst: " + text);
        Console.WriteLine("Zalogowany: " + isLogged);
        Console.WriteLine("Znak: " + myChar);
        Console.WriteLine("Cena: " + price);

        // Zadanie 2 - Operacja na string i int
        Console.WriteLine("\nOperatory - Zadanie 2");
        string Age = "Age: ";
        int myAge = 21;
        string ageResult = Age + myAge;  // Konkatenacja (łączenie) string + int
        Console.WriteLine(ageResult);

        // Zadanie 3 - Operacje logiczne
        Console.WriteLine("\nOperatory - Zadanie 3");
        bool isTrue = true;
        bool isFalse = false;
        bool isReallyTrue = true;

        bool and = isTrue && isFalse;  // false
        bool or = isTrue || isReallyTrue;  // true
        bool negative = !isFalse;  // true

        Console.WriteLine("AND: " + and);
        Console.WriteLine("OR: " + or);
        Console.WriteLine("NEG: " + negative);

        // Zadanie 4 - Operacje matematyczne
        Console.WriteLine("\nOperatory - Zadanie 4");
        int a = 5, b = 12;

        int add = a + b;
        int sub = a - b;
        int div = a / b;  // Dzielenie całkowite (wynik to 0)
        int mul = a * b;
        int mod = a % b;  // Reszta z dzielenia

        Console.WriteLine("Dodawanie: " + add);
        Console.WriteLine("Odejmowanie: " + sub);
        Console.WriteLine("Dzielenie: " + div);
        Console.WriteLine("Mnożenie: " + mul);
        Console.WriteLine("Modulo: " + mod);

        // Zadanie 5 - Operacje na stringach
        Console.WriteLine("\nOperatory - Zadanie 5");
        string strA = "Ala ";
        string strB = "ma ";
        string strC = "kota.";

        string strResult = strA + strB + strC;
        Console.WriteLine(strResult);

        // Wniosek: Stringi są łączone za pomocą operatora '+', wynik to "Ala ma kota."

        // Instrukcje sterujące i pętle

        // Zadanie 1 - Porównanie dwóch liczb
        Console.WriteLine("\nInstrukcje sterujące i pętle - Zadanie 1");
        int n1 = 10, n2 = 20;
        if (n1 > n2)
            Console.WriteLine($"{n1} jest większe od {n2}");
        else if (n1 < n2)
            Console.WriteLine($"{n1} jest mniejsze od {n2}");
        else
            Console.WriteLine($"{n1} jest równe {n2}");

        // Zadanie 2 - Pętle for i while
        Console.WriteLine("\nInstrukcje sterujące i pętle - Zadanie 2");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("C#");
        }

        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("C#");
            count++;
        }

        // Zadanie 3 - Parzyste i nieparzyste liczby
        Console.WriteLine("\nInstrukcje sterujące i pętle - Zadanie 3");
        int n = 10;
        for (int i = 0; i <= n; i++)
        {
            string parity = (i % 2 == 0) ? "Parzysta" : "Nieparzysta";
            Console.WriteLine($"{i} - {parity}");
        }

        // Zadanie 4 *dodatkowe - Wzór gwiazdek
        Console.WriteLine("\nInstrukcje sterujące i pętle - Zadanie 4 *dodatkowe");
        int stars = 5;
        for (int i = 1; i <= stars; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        // Zadanie 5 *dodatkowe - Ocena egzaminu
        Console.WriteLine("\nInstrukcje sterujące i pętle - Zadanie 5 *dodatkowe");
        int exam = 71; 
        if (exam < 0 || exam > 100)
        {
            Console.WriteLine("Wartość poza zakresem.");
        }
        else if (exam <= 39)
        {
            Console.WriteLine("Ocena Niedostateczna");
        }
        else if (exam <= 54)
        {
            Console.WriteLine("Ocena Dopuszczająca");
        }
        else if (exam <= 69)
        {
            Console.WriteLine("Ocena Dostateczna");
        }
        else if (exam <= 84)
        {
            Console.WriteLine("Ocena Dobra");
        }
        else if (exam <= 98)
        {
            Console.WriteLine("Ocena Bardzo Dobra");
        }
        else
        {
            Console.WriteLine("Ocena Celująca");
        }
    }
}


