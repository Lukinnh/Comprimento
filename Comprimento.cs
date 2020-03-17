using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprimento
{
    class Comprimento
    {
        private double quilometro;
        private double metro;
        private double centimetro;
        private double milimetro;
        private double micrometro;
        private double nanometro;
        private double milha;
        private double jarda;
        private double pe;
        private double polegada;
        private double milhanautica;


        private double Quilometro
        {
            get { return quilometro; }
            set
            {
                quilometro = value;
                metro = value * 1000;
                centimetro = value * 100000;
                milimetro = value * 1000000;
                micrometro = value * 1000000000;
                nanometro = value * 1000000000000;
                milha = value / 1.609;
                jarda = value * 1094;
                pe = value * 3281;
                polegada = value * 39370;
                milhanautica = value / 1.852;
            }
        }

        private double Metro
        {
            get { return metro; }
            set
            {
                quilometro = value / 100;
                metro = value;
                centimetro = value * 1000;
                milimetro = value * 100000;
                micrometro = value * 1000000;
                nanometro = value * 1000000000;
                milha = value / 1609;
                jarda = value * 1.094;
                pe = value * 3.281;
                polegada = value * 39.37;
                milhanautica = value / 1852;
            }

        }


        private double Centimetro
        {
            get { return centimetro; }
            set
            {
                quilometro = value / 1000;
                metro = value / 100;
                centimetro = value * 100;
                milimetro = value * 10000;
                micrometro = value * 10000;
                nanometro = value * 10000000;
                milha = value / 160934;
                jarda = value * 91.44;
                pe = value * 30.48;
                polegada = value * 2.54;
                milhanautica = value / 185200;
            }
        }


        private double Milimetro
        {
            get { return milimetro; }
            set
            {
                quilometro = value / 1000000;
                metro = value / 1000;
                centimetro = value / 10;
                milimetro = value;
                micrometro = value * 1000;
                nanometro = value * 1000000;
                milha = value / 1.609;
                jarda = value * 914;
                pe = value * 305;
                polegada = value * 25.4;
                milhanautica = value / 1.852;
            }
        }


        private double Micrometro
        {
            get { return micrometro; }
            set
            {
                quilometro = value / 1000000000;
                metro = value / 1000000;
                centimetro = value / 10000;
                milimetro = value / 1000;
                micrometro = value;
                nanometro = value * 1000;
                milha = value / 1.6099999999;
                jarda = value * 914400;
                pe = value * 304800;
                polegada = value * 25400;
                milhanautica = value / 1852132121200;
            }
        }


        private double Nanometro
        {
            get { return nanometro; }
            set
            {
                quilometro = value / 1000000000000;
                metro = value / 1000000000;
                centimetro = value / 10000000;
                milimetro = value / 999994;
                micrometro = value / 1000;
                nanometro = value;
                milha = value / 1609666666;
                jarda = value * 914444444444;
                pe = value * 3.04800;
                polegada = value / 2.5400;
                milhanautica = value / 1.852;
            }
        }



        private double Milha
        {
            get { return milha; }
            set
            {
                quilometro = value * 1.609;
                metro = value * 1609;
                centimetro = value * 160935;
                milimetro = value * 1.609;
                micrometro = value * 1.609999999;
                nanometro = value * 1.6099999999999;
                milha = value;
                jarda = value * 1760;
                pe = value * 5280;
                polegada = value * 63360;
                milhanautica = value / 1.151;
            }
        }


        private double Jarda
        {
            get { return jarda; }
            set
            {
                quilometro = value / 1094;
                metro = value / 1.094;
                centimetro = value * 91.441;
                milimetro = value * 914;
                micrometro = value * 914405;
                nanometro = value * 9.1444444444;
                milha = value / 1760;
                jarda = value;
                pe = value * 3;
                polegada = value * 36;
                milhanautica = value / 2025;
            }
        }



        private double Pe
        {
            get { return pe; }
            set
            {
                quilometro = value / 3281;
                metro = value / 3.281;
                centimetro = value * 30.48;
                milimetro = value * 305;
                micrometro = value * 304802;
                nanometro = value * 304888888888;
                milha = value / 5280;
                jarda = value / 3;
                pe = value;
                polegada = value * 12;
                milhanautica = value / 6076;
            }
        }


        private double Polegada
        {
            get { return polegada; }
            set
            {
                quilometro = value / 39370;
                metro = value / 39.37;
                centimetro = value * 2.54;
                milimetro = value * 25.4;
                micrometro = value * 25400;
                nanometro = value * 254000000000;
                milha = value / 63360;
                jarda = value / 36;
                pe = value / 12;
                polegada = value;
                milhanautica = value / 72913;
            }
        }


        private double Milhanautica
        {
            get { return milhanautica; }
            set
            {
                quilometro = value * 1.852;
                metro = value * 1852;
                centimetro = value * 185201;
                milimetro = value * 1852000000;
                micrometro = value * 1852000000000;
                nanometro = value * 1852000000000000;
                milha = value * 1.151;
                jarda = value * 2020;
                pe = value * 6076;
                polegada = 72914 * value;
                milhanautica = value;
            }
        }

    }
}