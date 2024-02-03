using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi
{
    public class Elips : Sekil
    {
        public double Yaricap1 { get { return Genislik / 2d; } }
        public double Yaricap2 => Yukseklik / 2d;  // Yukaridakiyle ayni islem (alternatif)
        public Elips() : base("Elips") { }
        public override double Alan()
        {
            return Math.PI * Yaricap1 * Yaricap2;
        }

        public override double Cevre()
        {
            double a = Yaricap1, b = Yaricap2;
            return Math.PI * Math.Sqrt(2 * (a * a + b * b));
        }

        public override void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Renk);
            g.FillEllipse(firca, X, Y, Genislik, Yukseklik);
        }
    }
}
