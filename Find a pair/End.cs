using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_a_pair
{
    public partial class End : Form
    {
        Start start = new Start();
        bool activityForm = true;

        public End(Start start, Game game)
        {
            game.Close();   // Завершуємо гру
            this.start = start;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start.Visible = true;
            activityForm = false;
            this.Close();
        }

        private void End_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (activityForm)
            {
                start.Close();
            }
        }
    }
}
