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
    public partial class End : Form
    {
        Start start = new Start();
        bool activity_form = true;

        public End(Start start, Game game)
        {
            game.Close();   // Завершуємо гру
            this.start = start;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Фіксуємо розміри форми, щоб не можна було змінювати розміри форми під час працювання форми
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start.Visible = true;
            activity_form = false;
            this.Close();
        }

        private void End_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (activity_form)
            {
                start.Close();
            }
        }
    }
}
