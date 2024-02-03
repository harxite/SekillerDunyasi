using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi
{
    public abstract class Sekil : ICizilebilir
    {
        public string Tur { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public Color Renk { get; set; } = Color.Black;

        public Sekil() : this("Sekil")
        {

        }
        public Sekil(string tur)
        {
            Tur = tur;
        }

        public abstract double Alan();


        public abstract double Cevre();

        public abstract void Ciz(Graphics g);
      
        public override string ToString()
        {
            return $"{Tur} ({X}, {Y}) {Genislik} X {Yukseklik} A: {Alan():0.00} C: {Cevre():0.00} R:{Renk}";
        }
    }
}
