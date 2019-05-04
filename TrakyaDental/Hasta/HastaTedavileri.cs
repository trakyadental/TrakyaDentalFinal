using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrakyaDental.Hasta
{
    public partial class HastaTedavileri : UserControl
    {
        public HastaTedavileri()
        {
            InitializeComponent();
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string tedavi = listTedaviler.SelectedItem.ToString();
            //string disler[] = checkedListBox1.SelectedItems.ToString();
            List<String> disler = new List<string>();
            foreach (string dis in checkedListBox1.CheckedItems) {
                disler.Add(dis);
                listEklenecekler.Items.Add(dis.ToUpper() +" , "+ tedavi.ToUpper());
            }
        }
    }
}
