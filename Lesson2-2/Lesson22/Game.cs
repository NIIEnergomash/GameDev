using System;
using System.Windows.Forms;
using System.Drawing;

namespace Lesson22
{
    /// <summary>
    /// Основной класс для создания и настройки основных объектов игры
    /// </summary>
    static class Game
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;

        //public static BaseObject[] _objs;
        public static PlanetPoint[] _planets;
        //public static Star[] _stars;

        public static Bullet _bullet;
        //public static Star[] _stars;
        public static int Width { get; set; }
        public static int Height { get; set; }
        static Game()
        {

        }
        /// <summary>
        /// Функция инициализации игрового поля
        /// </summary>
        /// <param name="form"></param>
        public static void Init(Form form)
        {
            Graphics g;
            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            Load();

            Timer timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Функция на момент срабатывания прерывания таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }
        /// <summary>
        /// Функция прорисовки объектов на игровом поле
        /// </summary>
        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black);
            foreach (PlanetPoint planet in _planets)
            {
                planet.Draw();
            }
            _bullet.Draw();
            Buffer.Render();
        }

        /// <summary>
        /// Функция обновления объектов на игровом поле
        /// </summary>
        public static void Update()
        {
            foreach (PlanetPoint planet in _planets)
            {
                planet.Update();
                if (planet.Collision(_bullet))
                {
                    System.Media.SystemSounds.Hand.Play();

                    // в случае пересечения объектов, они прорисовываются в разных углах
                    planet.PosSet(new Point(Game.Width, 0));
                    _bullet.PosSet(new Point(0, 0));

                }


            }
            _bullet.Update();
        }
        /// <summary>
        /// Функция определения объектов на игровом поле
        /// </summary>
        public static void Load()
        {
            _planets = new PlanetPoint[30];
            for (int i = 0; i < _planets.Length; i++)
            {
                _planets[i] = new PlanetPoint(new Point(600, i * 20), new Point(10 - i, 10 - i), new Size(10, 10));
            }
            _bullet = new Bullet(new Point(600, 20), new Point(15, 15), new Size(5, 5));


        }
    }

    interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
    }

    /// <summary>
    /// Базовый абстрактный класс BaseObject
    /// </summary>
    abstract class BaseObject : ICollision
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;
        public BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }
        public abstract void Draw();
        public abstract void Update();

        /// <summary>
        /// Функция внесения изменения в значения координат
        /// </summary>
        /// <param name="tPos"></param>
        public virtual void PosSet(Point tPos)
        {
            Pos = tPos;
        }

        public bool Collision(ICollision o) => o.Rect.IntersectsWith(this.Rect);
        public Rectangle Rect => new Rectangle(Pos, Size);
    }
    /// <summary>
    /// Класс для созданий объектов планет-точек, созданный на основе абстрактного класс BaseObject
    /// </summary>
    class PlanetPoint : BaseObject
    {
        public PlanetPoint(Point pos, Point dir, Size size) : base(pos, dir, size)
        {

        }
        /// <summary>
        /// Переопределение функции Draw для класса PlanetPoint
        /// </summary>
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawEllipse(Pens.White, Pos.X, Pos.Y, Size.Width, Size.Height);
        }
        /// <summary>
        /// Функция обновления значений координат для класса PlanetPoint
        /// </summary>
        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;

        }
    }
    /// <summary>
    /// Класс для создания пули
    /// </summary>
    class Bullet : BaseObject
    {
        public Bullet(Point pos, Point dir, Size size) : base(pos, dir, size)
        {

        }
        /// <summary>
        /// Переопределение функции Draw для класса Billet
        /// </summary>
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawEllipse(Pens.White, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        /// <summary>
        /// Функция обновления значений координат для класса Bullet
        /// </summary>
        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
        }
    }
}
    