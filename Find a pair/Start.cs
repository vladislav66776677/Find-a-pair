using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Start : Form
    {
        public Start()  
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Фіксуємо розміри форми, щоб не можна було змінювати розміри форми під час працювання форми
            InitializeComponent();  
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            Game form = new Game(this);   // Створення форми основної гри, де ми в параметр конструктора Game передаємо посилання на форму Start(на самого себе)
            form.Show();    // Показуємо форму гри
            form.Start();   // Запускаємо стартову функцію(вона відпрацює після конструктора форми гри)
            this.Visible = false;   // Скриваємо форму Start(не закриваємо, тому-що тоді вся гра закриється через те, що вона основна)
        }
    }
}
