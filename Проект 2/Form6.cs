using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Проект_2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //PictureBox для закрытия формы
            this.Close();
        }
        int min;
        int sec;
        int sch;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Код для отчёта таймера
            label3.Text = Convert.ToString(min);
            label4.Text = Convert.ToString(sec);
            sec++;
            if (sec==60)
            {
                min++;
                sec = 0;
            }
            //Каждой части текста присвоено значение sch, чтобы они шли по порядку
            sch++;
            if (sch>=0)
            {
                textBox1.Text = "В сентябре 1930 года в Германии были проведены парламентские выборы. С начала Великой депрессии прошел почти год. Нацисты получили 18 процентов голосов. Это неприятно удивило некоторых немцев, особенно тех, которые понимали, что нацистская партия — экстремистское, маргинальное движение.";
                pictureBox1.ImageLocation = "G-1.png";
            }
            if (sch>=100)
            {
                textBox1.Text = "Адольф Гитлер и нацисты привлекали последователей обещаниями сделать Германию сильной. Нацисты обещали: преодолеть экономический кризис и дать людям работу; вернуть Германии статус великой страны на европейском и даже мировом уровне; вернуть территории, утраченные Германией после Первой мировой войны; сформировать сильное и авторитетное правительство; бъединить всех этнических немцев.";
                pictureBox1.ImageLocation = "G-2.jpg";
            }
            if (sch>=200)
            {
                textBox1.Text = "Нацисты играли на страхах, надеждах и предрассудках людей. Также они нашли «козлов отпущения». Все проблемы Германии нацисты приписывали евреям и коммунистам. На этом ложном утверждении строилась антисемитская и расистская идеология нацистов.";
            }
            if (sch>=300)
            {
                label2.Text = "Как Гитлер пришел к власти в 1933 году?";
                textBox1.Text = "В начале 1930-х годов популярность нацистской партии  среди  избирателей продолжала расти. На парламентских выборах в июле 1932 года нацисты получили 37 процентов голосов. Это наибольший результат среди политических партий. В ноябре 1932 года количество голосов, отданных за нацистскую партию, снизилось до 33-х процентов. Однако, это был все еще  лучший результат среди  всех партий.";
                pictureBox1.ImageLocation = "G-3.png";
            }
            if (sch>=400)
            {
                textBox1.Text = "Властям Германии приходилось считаться с партией, достигшей такого электорального успеха. Но Гитлер и нацисты отказывались сотрудничать с другими партиями. Гитлер потребовал для себя пост канцлера. Сначала президент Германии Пауль фон Гинденбург отказал ему в этом. Однако, 30 января 1933 года он пошел навстречу Гитлеру и назначил его канцлером Германии.";
                pictureBox1.ImageLocation = "G-4.jpg";
            }
            if (sch >= 500)
            {
                textBox1.Text = "Гитлер получил пост в результате договоренности. Несколько политиков-консерваторов убедили президента Гинденбурга пойти на этот шаг. Они хотели воспользоваться популярностью нацистской партии для своих целей. Эти люди ошибочно полагали, что смогут контролировать Гитлера.";
            }
            if (sch >= 600)
            {
                textBox1.Text = "В январе 1933 года Гитлер еще не был диктатором. Когда он вступил в должность канцлера, демократическая конституция Германии все еще действовала. Впоследствии, манипулируя демократической политической системой, Гитлер изменил Германию. Вместе с другими нацистскими лидерами Гитлер, пользуясь существующими законами, уничтожил немецкую демократию и построил диктатуру.";
            }
            if (sch >= 700)
            {
                textBox1.Text = "В августе 1934 года умер президент Гинденбург. Гитлер провозгласил себя фюрером (лидером) Германии. С этого момента он стал диктатором.";
                pictureBox1.ImageLocation = "G-5.jpg";
                timer1.Stop();
                FileStream check = new FileStream(@"Просмотренные.txt", FileMode.Append);

                //Запись в файл, что это событие просмотренно
                StreamWriter writer = new StreamWriter(check);
                writer.WriteLine("Восхождение Гитлера к власти - просмотренно");
                writer.Close();
                check.Close();
            }
        }
        int timer;
        private void button1_Click(object sender, EventArgs e)
        {
            //Кнопка отвечает за старт
            timer1.Start();
            timer++;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Кнопка для возвращения на предыдущую форму
            tvV frm2 = new tvV();
            this.Close();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Кнопка отвечает за паузу
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы точно хотите перематать к концу?", "Перемотка", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (res == DialogResult.Yes)
            {
                sch += 700;
            }
        }
    }
}
