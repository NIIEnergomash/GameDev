/*
 * Усов Андрей
 * 2. Переделать виртуальный метод Update в BaseObject в абстрактный и реализовать его в наследниках.
 * 3. Сделать так, чтобы при столкновении пули с астероидом они регенерировались в разных концах экрана.
 */

using System;


using System.Windows.Forms;

namespace Lesson22
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;
            Game.Init(form);
            form.Show();
            Game.Draw();
            Application.Run(form);
        }
    }
}
