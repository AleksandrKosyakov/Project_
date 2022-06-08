using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace Проект_2
{
    public partial class Vmv : Form
    {
        //Переменные для шрифта
        Font myFont1;
        public Vmv()
        {
            InitializeComponent();
            //Присваивание элементам нового шрифта при загрузке формы
            LoadFont();
            label5.Font = myFont1;
        }
        private void LoadFont()
        {
            //Загрузка нового шрифта
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("Ironmonger Black Regular.otf");
            myFont1 = new Font(custom_font.Families[0], 25);
        }
        //Переменные даты начала событий
        int day = 1;
        int month = 9;
        int year = 1939;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PictureBox для закрытия формы
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Кнопка для возвращения на предыдущую форму
            tvV frm2 = new tvV();
            this.Close();
            frm2.Show();
        }
        int a;
        int sch;
        private void button3_Click(object sender, EventArgs e)
        {
            //Перемотка на год с сопровождением диалогового окна
            DialogResult result = MessageBox.Show("Вы точно хотите перематать 1 год?", "Перемотка", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                a = Convert.ToInt32(label6.Text);
                day = 1;
                month = 1;
                year++;
                if (a == 1944)
                    button3.Visible = false;
                sch+=360;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Каждой части текста присвоено значение sch, чтобы они шли по порядку
            if (sch >= 100)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[2];
                reader.Close();
            }
            if (sch >= 200)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[3];
                reader.Close();
            }
            if (sch >= 300)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[4];
                reader.Close();
            }
            if (sch >= 400)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[5];
                reader.Close();
            }
            if (sch >= 500)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[6];
                reader.Close();
            }
            if (sch >= 600)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[7];
                reader.Close();
            }
            if (sch >= 700)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[8];
                reader.Close();
            }
            if (sch >= 800)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[9];
                reader.Close();
            }
            if (sch >= 900)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[10];
                reader.Close();
            }
            if (sch >= 1000)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[11];
                reader.Close();
            }
            if (sch >= 1100)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[12];
                reader.Close();
            }
            if (sch >= 1200)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[13];
                reader.Close();
            }
            if (sch >= 1300)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[14];
                reader.Close();
            }
            if (sch >= 1400)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[15];
                reader.Close();
            }
            if (sch >= 1500)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[16];
                reader.Close();
            }
            if (sch >= 1600)
            {
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[17];
                reader.Close();
            }
            //Переменная на основании которой пишется новый текст
            sch++;
            //Код каждого тика таймера, в котором изменяется день, месяц и год. У каждого месяца разное количество дней, здесь это учитывается
            label6.Text = Convert.ToString(year);
            label4.Text = Convert.ToString(month);
            label1.Text = Convert.ToString(day);
            day = day + 1;
            //Месяца с количеством дней 31
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day == 32)
                {
                    month = month + 1;
                    day = 1;
                }
            }
            //Месяца с количеством дней 30
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day == 31)
                {
                    month = month + 1;
                    day = 1;
                }
            }
            //Отдельный if для февраля, в нём 28 дней
            if (month == 2)
            {
                if (day == 29)
                {
                    month = month + 1;
                    day = 1;
                }
            }
            //Начало нового года
            if (month == 13)
            {
                year++;
                month = 1;
                day = 1;
            }
            //Дата окончания войны
            if (year == 1945 && month == 9 && day == 2)
            {
                timer1.Stop();
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[18];
                reader.Close();

                //Запись в файл, что это событие просмотренно
                FileStream check = new FileStream(@"Просмотренные.txt", FileMode.Append);
                StreamWriter writer = new StreamWriter(check);
                writer.WriteLine("Вторая мировая война - просмотрена");
                writer.Close();
                check.Close();
            }
        }
        string[] s = File.ReadAllLines(@"VMV.txt");
        private void button1_Click(object sender, EventArgs e)
        {
            //При нажатии старт выходит выбор в MessageBox
            DialogResult result = MessageBox.Show("Хотите прочитать предисторию", "Предисторию", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                //Если ответ в дилаоге "ДА", то в textBox вносится информация из txt файла
                FileStream pmv = new FileStream(@"VMV.txt", FileMode.Open);
                pmv.Close();
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[0];
                reader.Close();
                button2.Visible = true;
            }
            else
            {
                //Если ответ в диалоге "НЕТ", то таймер начинает отчёт
                timer1.Start();
                FileStream pmv = new FileStream(@"VMV.txt", FileMode.Open);
                pmv.Close();
                StreamReader reader = new StreamReader(@"VMV.txt");
                textBox1.Text = s[1];
                reader.Close();
                timer++;
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Кнопка будет включена, есть вы решили прочитать предысторию, эта кнопка служит для начала рассказа после предыстории
            textBox1.Clear();
            timer1.Start();
            button2.Visible = false;
            FileStream pmv = new FileStream(@"VMV.txt", FileMode.Open);
            pmv.Close();
            StreamReader reader = new StreamReader(@"VMV.txt");
            textBox1.Text = s[1];
            reader.Close();
            timer++;
        }
        int timer;
        private void button4_Click(object sender, EventArgs e)
        {
            //Кнопка служит для паузы
            if (timer == 0)
            {
                timer1.Start();
                timer++;
            }
            else
            {
                timer1.Stop();
                timer--;
            }
        }

    }
}
