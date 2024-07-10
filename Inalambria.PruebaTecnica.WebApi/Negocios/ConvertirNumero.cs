namespace Inalambria.PruebaTecnica.WebApi.Negocios
{
    public class ConvertirNumero
    {
        public string NumeroEnLetras(double param)
        {
            string letra = "";
            if (param >= 0 && param <= 999999999999)
            {
                if (param == 0)
                {
                    letra = "Cero";
                }
                else if (param == 1)
                {
                    letra = "uno";
                }
                else if (param == 2)
                {
                    letra = "dos";
                }
                else if (param == 3)
                {
                    letra = "tres";
                }
                else if (param == 4)
                {
                    letra = "cuatro";
                }
                else if (param == 5)
                {
                    letra = "cinco";
                }
                else if (param == 6)
                {
                    letra = "seis";
                }
                else if (param == 7)
                {
                    letra = "siete";
                }
                else if (param == 8)
                {
                    letra = "ocho";
                }
                else if (param == 9)
                {
                    letra = "nueve";
                }
                else if (param == 10)
                {
                    letra = "diez";
                }
                else if (param == 11)
                {
                    letra = "once";
                }
                else if (param == 12)
                {
                    letra = "doce";
                }
                else if (param == 13)
                {
                    letra = "trece";
                }
                else if (param == 14)
                {
                    letra = "catorce";
                }
                else if (param == 15)
                {
                    letra = "quince";
                }
                else if (param < 20)
                {
                    letra = "dieci" + NumeroEnLetras(param - 10);
                }
                else if (param == 20)
                {
                    letra = "veinte";
                }
                else if (param < 30)
                {
                    letra = "veinti" + NumeroEnLetras(param - 20);
                }
                else if (param == 30)
                {
                    letra = "treinta";
                }
                else if (param == 40)
                {
                    letra = "cuarenta";
                }
                else if (param == 50)
                {
                    letra = "cincuenta";
                }
                else if (param == 60)
                {
                    letra = "Sesenta";
                }
                else if (param == 70)
                {
                    letra = "setenta";
                }
                else if (param == 80)
                {
                    letra = "ochenta";
                }
                else if (param == 90)
                {
                    letra = "noventa";
                }
                else if (param < 100)
                {
                    letra = NumeroEnLetras(Math.Truncate(param / 10) * 10) + " y " + NumeroEnLetras((param % 10));
                }
                else if (param == 100)
                {
                    letra = "cien";
                }
                else if (param < 200)
                {
                    letra = "ciento" + " " + NumeroEnLetras(param - 100);
                }
                else if (param == 200 || param == 300 || param == 400 || param == 600 || param == 800)
                {
                    letra = NumeroEnLetras(param / 100) + "cientos";
                }
                else if (param == 500)
                {
                    letra = "quinientos";
                }
                else if (param == 700)
                {
                    letra = "setecientos";
                }
                else if (param == 900)
                {
                    letra = "novecientos";
                }
                else if (param < 1000)
                {
                    letra = NumeroEnLetras(Math.Truncate(param / 100) * 100) + " " + NumeroEnLetras(param % 100);
                }
                else if (param == 1000)
                {
                    letra = "mil";
                }
                else if (param < 2000)
                {
                    letra = "mil " + NumeroEnLetras((param % 1000));
                }
                else if (param < 1000000)
                {
                    letra = NumeroEnLetras(Math.Truncate(param / 1000)) + " mil";
                    if (Math.Truncate(param % 1000) != 0)
                    {
                        letra = letra + " " + NumeroEnLetras(param % 1000);
                    }
                }
                else if (param == 1000000)
                {
                    letra = "un millon";
                }
                else if (param < 2000000)
                {
                    letra = "un millon " + NumeroEnLetras(Math.Truncate(param % 1000000));
                }
                else if (param < 1000000000000)
                {
                    letra = NumeroEnLetras(Math.Truncate(param / 1000000)) + " millones";
                    if ((param - (Math.Truncate(param / 1000000) * 1000000)) != 0)
                    {
                        letra = letra + " " + NumeroEnLetras(param - (Math.Truncate(param / 1000000) * 1000000));
                    }
                }
            }
            else
            {
                letra = "Valor fuera del rango";
            }
            return letra.ToUpper();
        }
    }
}
