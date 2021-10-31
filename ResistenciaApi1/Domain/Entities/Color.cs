using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResistenciaApi1.Domain.Interface;

namespace ResistenciaApi1.Domain.Entities
{
    public class Color:ICalculo
    {
        private string _Line1, _Line2, _Line3, _Line4, valor1, valor2, _resultado;

        private int valor = 0;

        public double suma = 0.0, _resultado2 = 0.0, _resultado3 = 0.0, ResultadoMA = 0.0, ResultadoM = 0.0;

        public void Line1(string Line1)

        {

            _Line1 = Line1.ToLower();

            switch (_Line1)
            {

                case "negro":

                    valor1 = "0";

                    break;

                case "cafe":

                    valor1 = "1";

                    break;

                case "rojo":

                    valor1 = "2";

                    break;

                case "naranja":

                    valor1 = "3";

                    break;

                case "amarillo":

                    valor1 = "4";

                    break;

                case "verde":

                    valor1 = "5";

                    break;

                case "azul":

                    valor1 = "6";

                    break;

                case "violeta":

                    valor1 = "7";

                    break;

                case "gris":

                    valor1 = "8";

                    break;

                case "blanco":

                    valor1 = "9";

                    break;
            }
        }
        public void Line2(string Line2)
        {
            _Line2 = Line2.ToLower();

            switch (_Line2)
            {

                case "negro":

                    valor2 = "0";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;

                case "cafe":

                    valor2 = "1";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;

                case "rojo":

                    valor2 = "2";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;

                case "naranja":

                    valor2 = "3";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;

                case "amarillo":

                    valor2 = "4";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;

                case "verde":

                    valor2 = "5";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;

                case "azul":

                    valor2 = "6";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;

                case "violeta":

                    valor2 = "7";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;

                case "gris":

                    valor2 = "8";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;

                case "blanco":

                    valor2 = "9";

                    _resultado = valor1 + valor2;

                    valor = int.Parse(_resultado);

                    break;
            }
        }
        public void Line3(string Line3)
        {
            _Line3 = Line3.ToLower();

            switch (_Line3)
            {

                case "negro":

                    _resultado2 = 1;

                    suma = valor * _resultado2;

                    break;

                case "cafe":

                    _resultado2 = 10;

                    suma = valor * _resultado2;

                    break;

                case "rojo":

                    _resultado2 = 100;

                    suma = valor * _resultado2;

                    break;

                case "naranja":

                    _resultado2 = 1000;

                    suma = valor * _resultado2;

                    break;

                case "amarillo":

                    _resultado2 = 10000;

                    suma = valor * _resultado2;

                    break;

                case "verde":

                    _resultado2 = 100000;

                    suma = valor * _resultado2;

                    break;

                case "azul":

                    _resultado2 = 1000000;

                    suma = valor * _resultado2;

                    break;

                case "violeta":

                    _resultado2 = 10000000;

                    suma = valor * _resultado2;

                    break;

                case "gris":

                    _resultado2 = 100000000;

                    suma = valor * _resultado2;

                    break;

                case "blanco":

                    _resultado2 = 1000000000;

                    suma = valor * _resultado2;

                    break;
            }
        }
        public void Line4(string Line4)
        {
            _Line4 = Line4.ToLower();

            if (_Line4 == "dorado")
            {
                _resultado3 = (suma * 5) / 100;
            }
            if (_Line4 == "plata")
            {
                _resultado3 = suma * 10 / 100;
            }


            ResultadoMA = suma + _resultado3;
            ResultadoM = suma - _resultado3;
        }
        public string Retornardatos()
        {
            return $"el valor es : {suma} y la tolerancia + o - : {_resultado3} Rango Mas: {_resultado3} es: {ResultadoMA} Rango Menos: {_resultado3} es: {ResultadoM}";
        }
    }
}
