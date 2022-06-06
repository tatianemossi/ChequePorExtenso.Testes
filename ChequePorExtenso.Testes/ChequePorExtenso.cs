using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChequePorExtenso.Testes
{
    [TestClass]
    public class ChequePorExtenso 
    {
        private ConversorCardinalParaExtenso _conversor;

        public ChequePorExtenso()
        {
            _conversor = new ConversorCardinalParaExtenso();
        }

        [TestMethod]
        [DataRow(1, "um real")]
        [DataRow(2, "dois reais")]
        [DataRow(3, "três reais")]
        [DataRow(4, "quatro reais")]
        [DataRow(5, "cinco reais")]
        [DataRow(6, "seis reais")]
        [DataRow(7, "sete reais")]
        [DataRow(8, "oito reais")]
        [DataRow(9, "nove reais")]
        [DataRow(10, "dez reais")]
        [DataRow(11, "onze reais")]
        [DataRow(12, "doze reais")]
        [DataRow(13, "treze reais")]
        [DataRow(14, "quatorze reais")]
        [DataRow(15, "quinze reais")]
        [DataRow(16, "dezesseis reais")]
        [DataRow(17, "dezessete reais")]
        [DataRow(18, "dezoito reais")]
        [DataRow(19, "dezenove reais")]
        [DataRow(20, "vinte reais")]
        [DataRow(30, "trinta reais")]
        [DataRow(40, "quarenta reais")]
        [DataRow(50, "cinquenta reais")]
        [DataRow(60, "sessenta reais")]
        [DataRow(70, "setenta reais")]
        [DataRow(80, "oitenta reais")]
        [DataRow(90, "noventa reais")]
        [DataRow(100, "cem reais")]
        [DataRow(200, "duzentos reais")]
        [DataRow(300, "trezentos reais")]
        [DataRow(400, "quatrocentos reais")]
        [DataRow(500, "quinhentos reais")]
        [DataRow(600, "seiscentos reais")]
        [DataRow(700, "setecentos reais")]
        [DataRow(800, "oitocentos reais")]
        [DataRow(900, "novecentos reais")]
        [DataRow(1000, "mil reais")]
        [DataRow(2000, "dois mil reais")]
        [DataRow(3000, "três mil reais")]
        [DataRow(4000, "quatro mil reais")]
        [DataRow(5000, "cinco mil reais")]
        [DataRow(6000, "seis mil reais")]
        [DataRow(7000, "sete mil reais")]
        [DataRow(8000, "oito mil reais")]
        [DataRow(9000, "nove mil reais")]
        [DataRow(10000, "dez mil reais")]
        [DataRow(100000, "cem mil reais")]
        [DataRow(1000000, "1 milhão de reais")]
        [DataRow(1000000000, "1 bilhão de reais")]
        public void Deve_retornar_numero_por_extenso_quando_receber_um_numero_cardinal(int numeroCardinal, string resultadoEsperado)
        {
            //action
            var numeroConvertido = _conversor.ConverterNumeroCardinalParaExtenso(numeroCardinal);

            //assert
            Assert.AreEqual(resultadoEsperado, numeroConvertido);
        }
    }
}
