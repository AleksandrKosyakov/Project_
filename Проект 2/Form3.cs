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
    public partial class nV : Form
    {
        //Переменные для шрифта
        Font myFont1;
        Font myFont2;
        Font myFont3;
        public nV()
        {
            InitializeComponent();
            //Присваивание элементам нового шрифта при загрузке формы
            LoadFont();
            label1.Font = myFont1;
            label3.Font = myFont2;
            btn_pmv.Font = myFont3;
            btn_nc.Font = myFont3;
            btn_back.Font = myFont3;
        }
        private void LoadFont()
        {
            //Загрузка нового шрифта
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("ofont.ru_Beton Cyr.ttf");
            myFont2 = new Font(custom_font.Families[0], 22);
            myFont3 = new Font(custom_font.Families[0], 20); 
            PrivateFontCollection custom_font1 = new PrivateFontCollection();
            custom_font1.AddFontFile("Ironmonger Black Regular.otf");
            myFont1 = new Font(custom_font1.Families[0], 25);
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            //Кнопка для возвращения на предыдущую форму
            Main frm1 = new Main();
            frm1.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PictureBox для закрытия формы
            Main frm1 = new Main();
            frm1.Show();
            this.Close();
        }
    }
}
