using System;
using System.Collections.Generic;

namespace ChequePorExtenso
{
    public class ConversorCardinalParaExtenso
    {
        private Dictionary<int, string> _dicionarioNumeros;

        public ConversorCardinalParaExtenso()
        {
            _dicionarioNumeros = new Dictionary<int, string>
            {
                [1] = "um",
                [2] = "dois",
                [3] = "três",
                [4] = "quatro",
                [5] = "cinco",
                [6] = "seis",
                [7] = "sete",
                [8] = "oito",
                [9] = "nove",
                [10] = "dez",
                [11] = "onze",
                [12] = "doze",
                [13] = "treze",
                [14] = "quatorze",
                [15] = "quinze",
                [16] = "dezesseis",
                [17] = "dezessete",
                [18] = "dezoito",
                [19] = "dezenove",
                [20] = "vinte",
                [30] = "trinta",
                [40] = "quarenta",
                [50] = "cinquenta",
                [60] = "sessenta",
                [70] = "setenta",
                [80] = "oitenta",
                [90] = "noventa",
                [100] = "cem",
                [200] = "duzentos",
                [300] = "trezentos",
                [400] = "quatrocentos",
                [500] = "quinhentos",
                [600] = "seiscentos",
                [700] = "setecentos",
                [800] = "oitocentos",
                [900] = "novecentos",
                [1000] = "mil",
                [2000] = "dois mil",
                [3000] = "três mil",
                [4000] = "quatro mil",
                [5000] = "cinco mil",
                [6000] = "seis mil",
                [7000] = "sete mil",
                [8000] = "oito mil",
                [9000] = "nove mil",
                [10000] = "dez mil",
                [100000] = "cem mil",
                [1000000] = "1 milhão",
                [1000000000] = "1 bilhão"
            };
        }

        public string ConverterNumeroCardinalParaExtenso(int numeroCardinal)
        {
            if (numeroCardinal == 1)
                return $"{_dicionarioNumeros[numeroCardinal]} real";

            else if(numeroCardinal == 1000000 || numeroCardinal == 1000000000)
                return $"{_dicionarioNumeros[numeroCardinal]} de reais";

            else
                return $"{_dicionarioNumeros[numeroCardinal]} reais";

        }
    }
}
