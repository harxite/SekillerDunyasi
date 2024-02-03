using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen() : base("Dikdortgen") { }
        public override double Alan()
        {
            return Genislik * Yukseklik;
        }

        public override double Cevre()
        {
            return (Genislik + Yukseklik) * 2;
        }

        public override void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Renk);
            g.FillRectangle(firca, X, Y, Genislik, Yukseklik);
        }
    }
}
