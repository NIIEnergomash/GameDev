/*
 * Усов Андрей
 */
using System;

struct Complex
{
    // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
    public double im;
    public double re;

    public Complex Plus(Complex x2)
    {
        Complex x3;
        x3.im = x2.im + this.im;
        x3.re = x2.re + this.re;
        return x3;
    }

    /// <summary>
    /// Функция, реализующая расчет разности двух комплексных чисел
    /// </summary>
    /// <param name="x2"></param>
    /// <returns></returns>
    public Complex Minus(Complex x2)
    {
        Complex x3;
        x3.im = this.im - x2.im;
        x3.re = this.re - x2.re;
        return x3;
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }
       
}

class Program
{
    static void Main(string[] args)
    {
        Complex complex1;
        complex1.re = 1;
        complex1.im = 1;

        Complex complex2;
        complex2.re = 2;
        complex2.im = 2;

        Complex result = complex1.Plus(complex2);

        // проверка функции разности двух комплексных чисел
        result = complex2.Minus(complex1);
        Console.WriteLine(result.ToString());
        Console.ReadLine();
    }
}
