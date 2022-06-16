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
    public partial class Main : Form
    {
        // Создание переменных для нового шрифта.
        Font myFont1;
        Font myFont2;
        Font myFont3;
        Font myFont4;
        public Main()
        {
            InitializeComponent();
            //Присваивание элементам нового шрифта при загрузке формы
            LoadFont();
            label1.Font = myFont4;
            label3.Font = myFont2;
            btn_tvc.Font = myFont3;
            btn_nc.Font = myFont3;

            

            
        }
        private void LoadFont()
        {
            // Создание нового шрифта.
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("ofont.ru_Beton Cyr.ttf"); 
            myFont1 = new Font(custom_font.Families[0], 25);
            myFont2 = new Font(custom_font.Families[0], 22);
            myFont3 = new Font(custom_font.Families[0], 20);
            PrivateFontCollection custom_font1 = new PrivateFontCollection();
            custom_font1.AddFontFile("Ironmonger Black Regular.otf");
            myFont4 = new Font(custom_font1.Families[0], 25);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Открытие "страницы" с 20 веком и закрытие основного меню.
            tvV frm2 = new tvV();
            frm2.Show();
            this.Hide();
        }

        private void btn_nc_Click(object sender, EventArgs e)
        {
            // Открытие "страницы" с 19 веком и закрытие основного меню.
            nV frm3 = new nV();
            frm3.Show();
            this.Hide();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PictureBox для закрытия формы
            tvV frm2 = new tvV();
            frm2.Close();
            this.Close();
        }
    }
}
