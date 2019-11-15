/*
 * Усов Андрей
 * Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
 * типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 
 * и функцией a* sin(x).
 */

using System;
// Описываем делегат. В делегате описывается сигнатура методов, на
// которые он сможет ссылаться в дальнейшем (хранить в себе)
public delegate double Fun(double x, double a);

class Program
{
    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
    public static void Table(Fun F, double x, double b, double a)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc(double x, double a)
    {
        return a* x * x * x;
    }
    /// <summary>
    /// Метод для передачи его в качестве параметра в Table для расчета фукнции a*sin(x)
    /// </summary>
    /// <param name="x"></param>
    /// <param name="a"></param>
    /// <returns></returns>
    public static double MySin(double x, double a)
    {
        return a * Math.Sin(x);
    }

    static void Main()
    {
        // Создаем новый делегат и передаем ссылку на него в метод Table
        Console.WriteLine("Таблица функции MyFunc:");
        // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
        //Table(new Fun(MyFunc), -2, 2, 1);
        Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
        // Упрощение(c C# 2.0).Делегат создается автоматически.            
        Table(MyFunc, -2, 2, 2);
        Console.WriteLine("Таблица функции a*Sin:");
        Table(MySin, -2, 2, 2);      // Можно передавать уже созданные методы
        Console.WriteLine("Таблица функции a*x^2:");
        // Упрощение(с C# 2.0). Использование анонимного метода
        Table(delegate (double x, double a) { return a * x * x; }, 0, 3, 2);
        Console.ReadLine();
    }
}
