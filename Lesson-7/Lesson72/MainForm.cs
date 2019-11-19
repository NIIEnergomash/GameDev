using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson72
{
    public partial class MainForm : Form
    {
        // Переменная для хранения загаданного компьютером значения
        static int ChoosenNumber;
        // Переменная для хранения вводимого пользователем значения
        int EnteredValue;
        //переменная для подсчета попыток
        int iCount;
        Random RND = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnRand_Click(object sender, EventArgs e)
        {
            // генерируем случайное число в диапазоне от 0 до 100
            ChoosenNumber = RND.Next(0, 100);

            // открываем невидимые поля и инициализируем строки сообщений
            lblChoosen.Visible = true;
            tbEnterValue.Enabled = true;
            lblResult.Text = "";
            iCount = 0;
        }

        private void TbEnterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                EnteredValue = int.Parse(tbEnterValue.Text);
                if (EnteredValue== ChoosenNumber)
                {
                    lblResult.Text = "Уррааа! Вы угадали";
                }
                else
                {
                    if (EnteredValue<ChoosenNumber)
                    {
                        lblResult.Text = "Введенное число меньше загаданного";
                    }
                    else
                    {
                        lblResult.Text = "Введенное число бошьше загаданного";
                    }
                }
                tbEnterValue.Text = "";
                //lblResult.Text = tbEnterValue.Text;
            }
        }
    }
}
