using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrakyaDental
{
    public partial class HastaIslemleri : Form
    {

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        Point lastLocation;
        public HastaIslemleri()
        {
            InitializeComponent();
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Dispose();
        }
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X -lastLocation.X;
                mouseY = MousePosition.Y - lastLocation.Y;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void formLoad(object sender, EventArgs e)
        {
            hastaEkle1.Hide();
            hastaTedavileri1.Hide();
            pbBackToMainScreen.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var anasayfa = new Form1();
            anasayfa.ShowDialog();
            this.Dispose();
        }

        private void pbHastaEkle_Click(object sender, EventArgs e)
        {
            hastaEkle1.Show();
        }

        private void pbHastaDuzelt_Click(object sender, EventArgs e)
        {
            tbDosyaNo.Enabled = true;
            tbHastaAdi.Enabled = true;
            tbHastaCinsiyet.Enabled = true;
            tbHastaDogTar.Enabled = true;
            tbHastaDoktor.Enabled = true;
            tbHastaSoyad.Enabled = true;
            tbHastaTCNO.Enabled = true;
            tbGSM.Enabled = true;
            tbEvTel.Enabled = true;
            tbEmail.Enabled = true;
            tbAdres.Enabled = true;
            btnBitir.Visible = true;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            tbDosyaNo.Enabled = false;
            tbHastaAdi.Enabled = false;
            tbHastaCinsiyet.Enabled = false;
            tbHastaDogTar.Enabled = false;
            tbHastaDoktor.Enabled = false;
            tbHastaSoyad.Enabled = false;
            tbHastaTCNO.Enabled = false;
            tbGSM.Enabled = false;
            tbEvTel.Enabled = false;
            tbEmail.Enabled = false;
            tbAdres.Enabled = false;
            btnBitir.Visible = false;
        }

        private void pbTedavi_Click(object sender, EventArgs e)
        {
            hastaTedavileri1.Show();
        }

        private void HastaIslemler_Load(object sender, EventArgs e)
        {
            hastaEkle1.Hide();
            hastaTedavileri1.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var receteForm = new RecetelerFORM();
            receteForm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var randevuForm = new RandevularFORM();
            randevuForm.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
