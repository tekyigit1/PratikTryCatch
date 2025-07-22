using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ask the user to enter a number
            // Kullanıcıdan bir sayı girmesini istiyoruz
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Calculate and print the square of the number
            // Sayının karesini hesaplayıp ekrana yazdırıyoruz
            int square = number * number;
            Console.WriteLine("The square of the number is: " + square);
        }
        catch (FormatException)
        {
            // If the user enters a non-numeric value, show error message
            // Kullanıcı geçersiz (harf/simge) bir giriş yaparsa, hata mesajı gösteriyoruz
            Console.WriteLine("Invalid input! Please enter a number.");
        }
    }
}

