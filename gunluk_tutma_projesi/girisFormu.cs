using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunluk_tutma_projesi
{
    public partial class girisFormu : Form
    {
        public girisFormu()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sifre=txtSifre.Text;
            if(sifre=="12345")
            {
                anaForm anaForm = new anaForm();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre Girdiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
