using System;
using System.Collections.Generic;

namespace ChequePorExtenso
{
    public class ConversorCardinalParaExtenso
    {
        private Dictionary<int, string> _dicionarioNumeros;

        public ConversorCardinalParaExtenso()
        {
            _dicionarioNumeros = DicionarioNumeros.CarregarDicionario();
        }

        public string ConverterNumeroCardinalParaExtenso(int numeroCardinal)
        {
            var tamanhoNumero = numeroCardinal.ToString().Length;
            var numeroExtenso = "";

            switch (tamanhoNumero)
            {
                case 1:
                    numeroExtenso = ConverterUnidadesParaExtenso(numeroCardinal);
                    break;
                case 2:
                    numeroExtenso = ConverterDezenasParaExtenso(numeroCardinal);
                    break;
                case 3:
                    numeroExtenso = ConverterCentenasParaExtenso(numeroCardinal);
                    break;
                case 4:
                    numeroExtenso = ConverterMilharesParaExtenso(numeroCardinal);
                    break;

                default:
                    break;
            };

            if (numeroCardinal == 1)
                return $"{numeroExtenso} real";
            else
                return $"{numeroExtenso} reais";
        }

        public string ConverterUnidadesParaExtenso(int numeroCardinal)
        {
            return _dicionarioNumeros[numeroCardinal];
        }

        public string ConverterDezenasParaExtenso(int numeroCardinal)
        {
            if (numeroCardinal > 19)
            {
                var dezena = numeroCardinal.ToString().ToCharArray()[0];
                var unidade = numeroCardinal.ToString().ToCharArray()[1];

                int chaveNumero = Convert.ToInt32($"{dezena}0");

                if (unidade == '0')
                    return _dicionarioNumeros[chaveNumero];
                else
                {
                    var unidadeExtenso = ConverterUnidadesParaExtenso(Convert.ToInt32(unidade.ToString()));
                    return $"{_dicionarioNumeros[chaveNumero]} e {unidadeExtenso}";
                }
            }
            else
                return $"{_dicionarioNumeros[numeroCardinal]}";
        }

        public string ConverterCentenasParaExtenso(int numeroCardinal)
        {
            if (numeroCardinal == 100)
                return "cem";

            else
            {
                var centena = numeroCardinal.ToString().ToCharArray()[0];
                var dezena = numeroCardinal.ToString().ToCharArray()[1];
                var unidade = numeroCardinal.ToString().ToCharArray()[2];

                int chaveNumero = Convert.ToInt32($"{centena}00");

                if (dezena == '0' && unidade == '0')
                    return _dicionarioNumeros[chaveNumero];

                else if (dezena == '0')
                {
                    var unidadeExtenso = ConverterUnidadesParaExtenso(Convert.ToInt32(unidade.ToString()));
                    return $"{_dicionarioNumeros[chaveNumero]} e {unidadeExtenso}";
                }

                var dezenaExtenso = ConverterDezenasParaExtenso(Convert.ToInt32($"{dezena}{unidade}"));
                return $"{_dicionarioNumeros[chaveNumero]} e {dezenaExtenso}";
            }
        }

        public string ConverterMilharesParaExtenso(int numeroCardinal)
        {
            var milhar = numeroCardinal.ToString().ToCharArray()[0];
            var centena = numeroCardinal.ToString().ToCharArray()[1];
            var dezena = numeroCardinal.ToString().ToCharArray()[2];
            var unidade = numeroCardinal.ToString().ToCharArray()[3];

            int chaveNumero = Convert.ToInt32($"{milhar}000");

            if (centena == '0' && dezena == '0' && unidade == '0')
                return _dicionarioNumeros[chaveNumero];

            else if (centena == '0')
            {
                var dezenaExtenso = ConverterDezenasParaExtenso(Convert.ToInt32($"{dezena}{unidade}"));
                return $"{_dicionarioNumeros[chaveNumero]} e {dezenaExtenso}";
            }

            var centenaExtenso = ConverterCentenasParaExtenso(Convert.ToInt32($"{centena}{dezena}{unidade}"));
            return $"{_dicionarioNumeros[chaveNumero]} {centenaExtenso}";
        }
    }
}
