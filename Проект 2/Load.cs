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

namespace Проект_2
{
    public partial class Load : Form
    {
        Font myFont1;
        public Load()
        {
            InitializeComponent();
            LoadFont();
            label1.Font = myFont1;
            timer1.Start();
            text();
        }
        private void LoadFont()
        {
            // Создание нового шрифта.
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("Ironmonger Black Regular.otf");
            myFont1 = new Font(custom_font.Families[0], 25);
        }
        private void text()
        {
            Random rndT = new Random();
            int txt = rndT.Next(1, 12);
            switch (txt)
            {
                case 1: label2.Text = "Адольф Гитлер:"; label3.Text = "«Мы не имели ни малейшего понятия о том, насколько гигантской была подготовка противника!»"; break;
                case 2: label2.Text = "Адольф Гитлер:"; label3.Text = "«Великие лжецы - это и великие волшебники.»"; break;
                case 3: label2.Text = "Владимир Ленин:"; label3.Text = "«Первая мировая война - это лучший подарок революции.»"; break;
                case 4: label2.Text = "Уинстон Черчилль:"; label3.Text = "«Англии был предложен выбор между войной и бесчестием. Она выбрала бесчестие и получит войну.»"; break;
                case 5: label2.Text = "Иосиф Сталин:"; label3.Text = "«Отстаивать каждую пядь Советской земли, драться до последней капли крови!»"; break;
                case 6: label2.Text = "Бенито Муссолини:"; label3.Text = "«Унизительно сидеть сложа руки, когда другие пишут историю. И неважно, кто победит.»"; break;
                case 7: label2.Text = "Французский антивоенный лозунг:"; label3.Text = "«Зачем умирать за Данциг?»"; break;
                case 8: label2.Text = "Альберт Эйнштейн:"; label3.Text = "«Пока существуют суверенные государства, обладающие мощными армиями, война неизбежна.»"; break;
                case 9: label2.Text = "Уинстон Черчилль:"; label3.Text = "«Успех - это умение двигаться от одной неудачи к другой, не теряя энтузиазма.»"; break;
                case 10: label2.Text = "Эрвин Роммель:"; label3.Text = "«В схватке один на один побеждает тот, у кого на один патрон больше.»"; break;
                case 11: label2.Text = "Невилл Чемберлен:"; label3.Text = "«Я уверен, что мы обеспечили прочный мир.»"; break;
                case 12: label2.Text = "Георгий Жуков:"; label3.Text = "«Подходя к минному полю, наша пехота проводит атаку так, как будто этого поля нет.»"; break;
            }
        }
        Random rnd = new Random();
        int a;
        int i;
        int b;
        private void timer1_Tick(object sender, EventArgs e)
        {
            b = progressBar1.Value;
            i++;
            if (i < 4)
            {
                a = rnd.Next(1, 20);
                progressBar1.Value += a;
            }
            else
                if (i == 4) 
                {
                progressBar1.Value += 100 - b;
                }
        }
    }
}
