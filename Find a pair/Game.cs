using System;
using System.Diagnostics.Contracts;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Find_a_pair
{
    public partial class Game : Form
    {
        string temporaryText;
        string currentDirectory = Directory.GetCurrentDirectory();
        string[] arrLocationImage = new string[] { "Resources\\1.jpg", "Resources\\2.jpg", "Resources\\3.jpg", "Resources\\4.jpg", "Resources\\5.jpg", "Resources\\6.jpg", "Resources\\7.jpg", "Resources\\8.jpg" };
        int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };  // Массив для того щоб змішувати його
        int[,] twoArr = new int[8, 8]; // Головний массив, щоб зберігати данні 
        bool activityForm = true;  // Проміжні логічні змінні
        int pair = 0;   // Змінна дял збереження знайдених кількості пар
        Button btn1 = null;
        Button btn2 = null;

        Start startForm = new Start();


        public Game(Start start_form)
        {
            InitializeComponent();
            this.startForm = start_form;
        }

        public void Start() // Стартова функція форми. Змішує елементи массиву в цій функції
        {
            currentDirectory = currentDirectory.Substring(0, currentDirectory.Length - 24);
            for (int i = 0; i < arrLocationImage.Length; i++)
            {
                temporaryText = currentDirectory;
                temporaryText += arrLocationImage[i];
                arrLocationImage[i] = temporaryText;
            }
            Random random = new Random();
            for (int i = 0; i < 8; i++) // В циклі змішує елементи массиву місцями, щоб був рандом в парах
            {
                for (int j = data.Length - 1; j >= 1; j--)
                {
                    int temp1 = random.Next(j + 1);
                    int temp2 = data[temp1];
                    data[temp1] = data[j];
                    data[j] = temp2;
                }
                for (int j = 0; j < data.Length; j++)
                {
                    twoArr[i, j] = data[j];
                }
            }
        }

        private void Click(int number, object sender)
        {
            Button clickedButton = (Button)sender;
            if (btn1 == null)   // Якщо перша кнопка пуста, то показуємо текст і красимо 
            {
                btn1 = clickedButton;
                btn1.Image = Image.FromFile(arrLocationImage[number - 1]);
                btn1.Tag = number.ToString();
                btn1.BackColor = Color.AliceBlue;

                return; // Виходимо із функції
            }

            if (btn2 == null)
            {
                btn2 = clickedButton;   // Якщо перша кнопка має вже данні, то працюємо із другою кнопкою
                btn2.Image = Image.FromFile(arrLocationImage[number - 1]);
                btn2.Tag = number.ToString();
                btn2.BackColor = Color.AliceBlue;
            }
            else
            {
                return;
            }

            if (btn1.Tag == btn2.Tag) // Перевіряємо на рівність кнопки, якщо текст однаковий, то ми рахуємо пару
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn1 = null;
                btn2 = null;
                pair++;
                if (pair == 32) // Якщо знайдемо всі пари, то завершуємо гру
                {
                    activityForm = false;
                    End end_form = new End(startForm, this);
                    end_form.Show();
                    this.Close();
                }
            }
            else
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();    // Створюємо таймер(для того, щоб можна було запам'ятати кнопки)
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }

        }

        private void Timer_Tick(object sender, EventArgs e) // Таймер закінчиться, спрацює функція, де ми повертаємо все назад
        {
            btn1.Tag = "";
            btn1.BackColor = Color.White;
            btn1.Image = null;
            btn2.Tag = "";
            btn2.BackColor = Color.White;
            btn2.Image = null;
            btn1 = null;
            btn2 = null;
            ((System.Windows.Forms.Timer)sender).Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Click(twoArr[0, 0], sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Click(twoArr[0, 1], sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Click(twoArr[0, 2], sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Click(twoArr[0, 3], sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Click(twoArr[0, 4], sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Click(twoArr[0, 5], sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Click(twoArr[0, 6], sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Click(twoArr[0, 7], sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Click(twoArr[1, 0], sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Click(twoArr[1, 1], sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Click(twoArr[1, 2], sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Click(twoArr[1, 3], sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Click(twoArr[1, 4], sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Click(twoArr[1, 5], sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Click(twoArr[1, 6], sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Click(twoArr[1, 7], sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Click(twoArr[2, 0], sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Click(twoArr[2, 1], sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Click(twoArr[2, 2], sender);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Click(twoArr[2, 3], sender);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Click(twoArr[2, 4], sender);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Click(twoArr[2, 5], sender);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Click(twoArr[2, 6], sender);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Click(twoArr[2, 7], sender);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Click(twoArr[3, 0], sender);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Click(twoArr[3, 1], sender);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Click(twoArr[3, 2], sender);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Click(twoArr[3, 3], sender);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Click(twoArr[3, 4], sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Click(twoArr[3, 5], sender);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Click(twoArr[3, 6], sender);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Click(twoArr[3, 7], sender);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Click(twoArr[4, 0], sender);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Click(twoArr[4, 1], sender);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Click(twoArr[4, 2], sender);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Click(twoArr[4, 3], sender);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Click(twoArr[4, 4], sender);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Click(twoArr[4, 5], sender);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Click(twoArr[4, 6], sender);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Click(twoArr[4, 7], sender);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Click(twoArr[5, 0], sender);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Click(twoArr[5, 1], sender);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Click(twoArr[5, 2], sender);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Click(twoArr[5, 3], sender);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Click(twoArr[5, 4], sender);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Click(twoArr[5, 5], sender);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Click(twoArr[5, 6], sender);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Click(twoArr[5, 7], sender);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Click(twoArr[6, 0], sender);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Click(twoArr[6, 1], sender);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Click(twoArr[6, 2], sender);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Click(twoArr[6, 3], sender);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Click(twoArr[6, 4], sender);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Click(twoArr[6, 5], sender);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Click(twoArr[6, 6], sender);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Click(twoArr[6, 7], sender);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Click(twoArr[7, 0], sender);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Click(twoArr[7, 1], sender);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Click(twoArr[7, 2], sender);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Click(twoArr[7, 3], sender);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Click(twoArr[7, 4], sender);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Click(twoArr[7, 5], sender);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Click(twoArr[7, 6], sender);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Click(twoArr[7, 7], sender);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)    // Функція при закриття форми 
        {
            if (activityForm)
            {
                startForm.Close(); // Закриває стартову форми(це потрібно для того, щоб потім не був зайвий процес в Windows, якщо не закрити, полетят помилки)
            }
        }
    }
}
