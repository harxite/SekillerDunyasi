using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace SekillerDunyasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<ICizilebilir> cizilebilirler = new List<ICizilebilir>();
        Random rnd = new Random();
        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            #region Cizim ornegi
            // ornek dikdortgen cizimi
            //e.Graphics.FillRectangle(Brushes.Red, 100, 100, 300, 200);
            // ornek elips cizimi
            //e.Graphics.FillEllipse(Brushes.Green, 150, 150, 200, 200);
            // kendi fircamizla cizelim
            // yari saydam bir renk
            //Brush firca = new SolidBrush(Color.FromArgb(128, 31, 69, 165));
            //e.Graphics.FillRectangle(firca, 170, 170, 300, 100);
            #endregion

            foreach (var cizilebilir in cizilebilirler)
                cizilebilir.Ciz(e.Graphics);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sekil s;

            switch (cboTur.SelectedItem?.ToString())
            {
                case "Dikdortgen":
                    s = new Dikdortgen();
                    break;
                case "Elips":
                    s = new Elips();
                    break;
                default:
                    MessageBox.Show("Lutfen bir sekil seciniz");
                    return;
            }
            s.X = (int)nudX.Value;
            s.Y = (int)nudY.Value;
            s.Genislik = (int)nudGenislik.Value;
            s.Yukseklik = (int)nudYukseklik.Value;
            s.Renk = pboRenk.BackColor;
            cizilebilirler.Add(s);
            CizilebilirleriListele();
            lstSekiller.SelectedItem = s;
        }

        private void CizilebilirleriListele()
        {
            lstSekiller.Items.Clear();
            foreach (ICizilebilir cizilebilir in cizilebilirler)
            {
                lstSekiller.Items.Add(cizilebilir);
            }
            pnlCizim.Refresh();
        }

        private void pboRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pboRenk.BackColor = colorDialog1.Color;
        }

        private void btnRastgeleEkle_Click(object sender, EventArgs e)
        {
            int mx = (int)pnlCizim.Width;   // max X
            int my = (int)pnlCizim.Height;  // max Y
            int mw = (int)pnlCizim.Width; // max width
            int mh = (int)pnlCizim.Height; // max height
            int sc = (int)cboTur.Items.Count; // shapes count
            int mc = 256; // max color
            int x, y;
            nudX.Value = x = rnd.Next(mx);
            nudY.Value = y = rnd.Next(my);
            nudGenislik.Value = rnd.Next(mw - x);
            nudYukseklik.Value = rnd.Next(mh - y);
            pboRenk.BackColor = Color.FromArgb(rnd.Next(mc), rnd.Next(mc), rnd.Next(mc), rnd.Next(mc));
            cboTur.SelectedIndex = rnd.Next(sc);
            btnEkle.PerformClick();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cizilebilirler.Clear();
            CizilebilirleriListele();
        }

        private void SeciliSekiliTasi(int yeniIndeks)
        {
            if (lstSekiller.SelectedItem == null || yeniIndeks < 0 || yeniIndeks >= cizilebilirler.Count)
                return;
            ICizilebilir seciliSekil = (ICizilebilir)lstSekiller.SelectedItem;
            cizilebilirler.Remove(seciliSekil);
            cizilebilirler.Insert(yeniIndeks, seciliSekil);
            CizilebilirleriListele();
            lstSekiller.SelectedIndex = yeniIndeks;
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            SeciliSekiliTasi(sid - 1);
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            SeciliSekiliTasi(sid + 1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            if (sid == -1) return;
            cizilebilirler.RemoveAt(sid);
            CizilebilirleriListele();
            lstSekiller.SelectedIndex = Math.Min(sid, lstSekiller.Items.Count - 1);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pnlCizim.Width, pnlCizim.Height);
            pnlCizim.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            bmp.Save(masaustuYolu + @"\deneme.png", ImageFormat.Png);
        }

        private void btnMetinEkle_Click(object sender, EventArgs e)
        {
            Yazi yazi = new Yazi((int)nudX.Value, (int)nudY.Value, txtMetin.Text, pboRenk.BackColor);
            cizilebilirler.Add(yazi);
            CizilebilirleriListele();
        }
    }
}