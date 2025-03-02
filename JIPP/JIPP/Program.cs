using System;

class Program
{
    static void Main()
    {
        // Zadanie 2 - Wczytywanie i wyświetlanie danych
        Console.WriteLine("Podaj swoje imię:");
        var name = Console.ReadLine();
        Console.WriteLine("Hello " + name);

        // Zadanie 3 - Znalezienie i naprawienie błędu
        int resultFix = 5 + 9;  // Poprawiona wersja (brakujący średnik)
        Console.WriteLine("Wynik: " + resultFix);

        // Zadanie 1 - Deklaracja zmiennych
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
        string myAge = "Age: ";
        int wifeAge = 18;
        string ageResult = myAge + wifeAge;  // Konkatenacja (łączenie) string + int
        Console.WriteLine(ageResult);

        // Zadanie 3 - Operacje logiczne
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
        string strA = "Ala ";
        string strB = "ma ";
        string strC = "kota.";

        string strResult = strA + strB + strC;
        Console.WriteLine(strResult);

        // Wniosek: Stringi są łączone za pomocą operatora '+', wynik to "Ala ma kota."
    }
}
