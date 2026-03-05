using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunluk_tutma_projesi
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkindaFormu hakkindaFormu = new hakkindaFormu();
            hakkindaFormu.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Programın çalıştığı klasör
            string klasor = Application.StartupPath;

            // Günün tarihini dosya adı yap
            string dosyaAdi = DateTime.Now.ToString("dd-MM-yyyy") + ".txt";

            // Tam dosya yolu
            string dosyaYolu = Path.Combine(klasor, dosyaAdi);


            gunlukYazi.SaveFile(dosyaYolu, RichTextBoxStreamType.PlainText);
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog  acPenceresi=new OpenFileDialog();
            acPenceresi.Filter = "Metin Dosyası (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            DialogResult sonuc = acPenceresi.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                string dosyaYolu = acPenceresi.FileName;
                gunlukYazi.LoadFile(dosyaYolu, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
