using System;
using System.Diagnostics.Contracts;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp2
{
    public partial class Game : Form
    {
        int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };  // ������ ��� ���� ��� �������� ����
        int[,] two_arr = new int[8, 8]; // �������� ������, ��� �������� ���� 
        bool activity_form = true;  // ������ ����� ����
        int para = 0;   // ����� ��� ���������� ��������� ������� ���
        Button btn1 = null;
        Button btn2 = null;

        Start start_form = new Start();


        public Game(Start start_form)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Գ����� ������ �����, ��� �� ����� ���� �������� ������ ����� �� ��� ���������� �����
            InitializeComponent();
            this.start_form = start_form;
        }

        public void Start() // �������� ������� �����. ���� �������� ������� � ��� �������
        {
            Random random = new Random();
            for (int u = 0; u < 8; u++) // � ���� ���� �������� ������� ������, ��� ��� ������ � �����
            {
                for (int i = data.Length - 1; i >= 1; i--)
                {
                    int j = random.Next(i + 1);
                    int temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                }
                for (int i = 0; i < data.Length; i++)
                {
                    two_arr[u, i] = data[i];
                }
            }
        }

        private void Click(int number, object sender)
        {
            if ((Button)sender != btn1) // �������� �� �������� ���������� ���� � ��� ���� ������
            {
                Button clickedButton = (Button)sender;
                if (btn1 == null)   // ���� ����� ������ �����, �� �������� ����� � ������� 
                {
                    btn1 = clickedButton;
                    btn1.Text = number.ToString();
                    btn1.BackColor = Color.AliceBlue;
                    return; // �������� �� �������
                }
                btn2 = clickedButton;   // ���� ����� ������ �� ��� ����, �� �������� �� ������ �������
                btn2.Text = number.ToString();
                btn2.BackColor = Color.AliceBlue;
                if (btn1.Text == btn2.Text) // ���������� �� ������ ������, ���� ����� ���������, �� �� ������ ����
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn1 = null;
                    btn2 = null;
                    para++; 
                    if (para == 32) // ���� �������� �� ����, �� ��������� ���
                    {
                        activity_form = false;
                        End end_form = new End(start_form, this);
                        end_form.Show();
                        this.Close();
                    }
                }
                else
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();    // ��������� ������(��� ����, ��� ����� ���� �����'����� ������)
                    timer.Interval = 1000;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
            }
            
        }

        private void Timer_Tick(object sender, EventArgs e) // ������ ����������, ������� �������, �� �� ��������� ��� �����
        {
            btn1.Text = "";
            btn1.BackColor = Color.White;
            btn2.Text = "";
            btn2.BackColor = Color.White;
            btn1 = null;
            btn2 = null;
            ((System.Windows.Forms.Timer)sender).Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Click(two_arr[0, 0], sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Click(two_arr[0, 1], sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Click(two_arr[0, 2], sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Click(two_arr[0, 3], sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Click(two_arr[0, 4], sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Click(two_arr[0, 5], sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Click(two_arr[0, 6], sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Click(two_arr[0, 7], sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Click(two_arr[1, 0], sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Click(two_arr[1, 1], sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Click(two_arr[1, 2], sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Click(two_arr[1, 3], sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Click(two_arr[1, 4], sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Click(two_arr[1, 5], sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Click(two_arr[1, 6], sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Click(two_arr[1, 7], sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Click(two_arr[2, 0], sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Click(two_arr[2, 1], sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Click(two_arr[2, 2], sender);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Click(two_arr[2, 3], sender);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Click(two_arr[2, 4], sender);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Click(two_arr[2, 5], sender);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Click(two_arr[2, 6], sender);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Click(two_arr[2, 7], sender);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Click(two_arr[3, 0], sender);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Click(two_arr[3, 1], sender);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Click(two_arr[3, 2], sender);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Click(two_arr[3, 3], sender);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Click(two_arr[3, 4], sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Click(two_arr[3, 5], sender);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Click(two_arr[3, 6], sender);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Click(two_arr[3, 7], sender);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Click(two_arr[4, 0], sender);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Click(two_arr[4, 1], sender);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Click(two_arr[4, 2], sender);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Click(two_arr[4, 3], sender);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Click(two_arr[4, 4], sender);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Click(two_arr[4, 5], sender);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Click(two_arr[4, 6], sender);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Click(two_arr[4, 7], sender);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Click(two_arr[5, 0], sender);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Click(two_arr[5, 1], sender);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Click(two_arr[5, 2], sender);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Click(two_arr[5, 3], sender);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Click(two_arr[5, 4], sender);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Click(two_arr[5, 5], sender);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Click(two_arr[5, 6], sender);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Click(two_arr[5, 7], sender);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Click(two_arr[6, 0], sender);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Click(two_arr[6, 1], sender);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Click(two_arr[6, 2], sender);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Click(two_arr[6, 3], sender);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Click(two_arr[6, 4], sender);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Click(two_arr[6, 5], sender);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Click(two_arr[6, 6], sender);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Click(two_arr[6, 7], sender);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Click(two_arr[7, 0], sender);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Click(two_arr[7, 1], sender);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Click(two_arr[7, 2], sender);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Click(two_arr[7, 3], sender);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Click(two_arr[7, 4], sender);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Click(two_arr[7, 5], sender);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Click(two_arr[7, 6], sender);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Click(two_arr[7, 7], sender);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)    // ������� ��� �������� ����� 
        {
            if (activity_form)
            {
                start_form.Close(); // ������� �������� �����(�� ������� ��� ����, ��� ���� �� ��� ������ ������ � Windows, ���� �� �������, ������� �������)
            }
        }
    }
}