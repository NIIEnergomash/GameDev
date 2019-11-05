/*
 * Усов Андрей
 * 
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
 */
using System;

class Complex
{
    // Поля приватные.
    private double im;
    // По умолчанию элементы приватные, поэтому private можно не писать.
    double re;

    // Конструктор без параметров.
    public Complex()
    {
        im = 0;
        re = 0;
    }

    // Конструктор, в котором задаем поля.    
    // Специально создадим параметр re, совпадающий с именем поля в классе.
    public Complex(double _im, double re)
    {
        // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
        im = _im;
        // Чтобы показать, что к полю нашего класса присваивается параметр,
        // используется ключевое слово this
        // Поле параметр
        this.re = re;
    }
    public Complex Plus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }

    // функция расчета разности двух комплексных чисел
    public Complex Minus(Complex x2)
    {
        Complex x3 = new Complex(); ;
        x3.im = this.im - x2.im;
        x3.re = this.re - x2.re;
        return x3;
    }


    // функция расчета произведения двух комплексных чисел
    public Complex Sub(Complex x2)
    {
        Complex x3 = new Complex(); ;
        x3.im = this.re*x2.im + this.im*x2.re;
        x3.re = this.re*x2.re-this.im*x2.im;
        return x3;
    }


    // Свойства - это механизм доступа к данным класса.
    public double Im
    {
        get { return im; }
        set
        {
            // Для примера ограничимся только положительными числами.
            if (value >= 0) im = value;
        }
    }
    // Специальный метод, который возвращает строковое представление данных.
    public string ToString()
    {
        return re + "+" + im + "i";
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Описали ссылку на объект.
        Complex complex1;
        // Создали объект и сохранили ссылку на него в complex1.
        complex1 = new Complex(1, 1);
        // Описали объект и создали его.
        Complex complex2 = new Complex(2, 2);
        // Создали ссылку на объект.
        Complex result;
        // Производим проверку работы функции Minus
        result = complex2.Minus(complex1);
        Console.WriteLine(result.ToString());

        result = complex1.Sub(complex2);
        Console.WriteLine(result.ToString());

        Console.ReadLine();
    }
}
