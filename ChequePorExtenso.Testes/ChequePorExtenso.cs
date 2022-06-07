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
        [DataRow(101, "cento e um reais")]
        [DataRow(119, "cento e dezenove reais")]
        [DataRow(131, "cento e trinta e um reais")]
        [DataRow(178, "cento e setenta e oito reais")]
        [DataRow(182, "cento e oitenta e dois reais")]
        [DataRow(199, "cento e noventa e nove reais")]
        [DataRow(200, "duzentos reais")]
        [DataRow(203, "duzentos e três reais")]
        [DataRow(214, "duzentos e quatorze reais")]
        [DataRow(222, "duzentos e vinte e dois reais")]
        [DataRow(300, "trezentos reais")]
        [DataRow(303, "trezentos e três reais")]
        [DataRow(314, "trezentos e quatorze reais")]
        [DataRow(322, "trezentos e vinte e dois reais")]
        [DataRow(400, "quatrocentos reais")]
        [DataRow(431, "quatrocentos e trinta e um reais")]
        [DataRow(487, "quatrocentos e oitenta e sete reais")]
        [DataRow(500, "quinhentos reais")]
        [DataRow(506, "quinhentos e seis reais")]
        [DataRow(506, "quinhentos e seis reais")]
        [DataRow(506, "quinhentos e seis reais")]
        [DataRow(549, "quinhentos e quarenta e nove reais")]
        [DataRow(600, "seiscentos reais")]
        [DataRow(612, "seiscentos e doze reais")]
        [DataRow(630, "seiscentos e trinta reais")]
        [DataRow(612, "seiscentos e doze reais")]
        [DataRow(700, "setecentos reais")]
        [DataRow(717, "setecentos e dezessete reais")]
        [DataRow(710, "setecentos e dez reais")]
        [DataRow(800, "oitocentos reais")]
        [DataRow(823, "oitocentos e vinte e três reais")]
        [DataRow(856, "oitocentos e cinquenta e seis reais")]
        [DataRow(900, "novecentos reais")]
        [DataRow(915, "novecentos e quinze reais")]
        [DataRow(957, "novecentos e cinquenta e sete reais")]
        [DataRow(1000, "mil reais")]
        [DataRow(1001, "mil e um reais")]
        [DataRow(1056, "mil e cinquenta e seis reais")]
        [DataRow(1321, "mil trezentos e vinte e um reais")]
        [DataRow(2000, "dois mil reais")]
        [DataRow(2021, "dois mil e vinte e um reais")]
        [DataRow(2783, "dois mil setecentos e oitenta e três reais")]
        [DataRow(3000, "três mil reais")]
        [DataRow(3003, "três mil e três reais")]
        [DataRow(3561, "três mil quinhentos e sessenta e um reais")]
        [DataRow(4000, "quatro mil reais")]
        [DataRow(4014, "quatro mil e quatorze reais")]
        [DataRow(4314, "quatro mil trezentos e quatorze reais")]
        [DataRow(5000, "cinco mil reais")]
        [DataRow(5009, "cinco mil e nove reais")]
        [DataRow(5555, "cinco mil quinhentos e cinquenta e cinco reais")]
        [DataRow(6000, "seis mil reais")]
        [DataRow(6005, "seis mil e cinco reais")]
        [DataRow(6214, "seis mil duzentos e quatorze reais")]
        [DataRow(7000, "sete mil reais")]
        [DataRow(7010, "sete mil e dez reais")]
        [DataRow(8000, "oito mil reais")]
        [DataRow(8019, "oito mil e dezenove reais")]
        [DataRow(9000, "nove mil reais")]
        [DataRow(9001, "nove mil e um reais")]
        [DataRow(9016, "nove mil e dezesseis reais")]
        //[DataRow(10000, "dez mil reais")]
        //[DataRow(100000, "cem mil reais")]
        //[DataRow(1000000, "1 milhão de reais")]
        //[DataRow(1000000000, "1 bilhão de reais")]
        public void Deve_retornar_por_extenso_quando_receber_cardinal_de_1_a_20(int numeroCardinal, string resultadoEsperado)
        {
            //action
            var numeroConvertido = _conversor.ConverterNumeroCardinalParaExtenso(numeroCardinal);

            //assert
            Assert.AreEqual(resultadoEsperado, numeroConvertido);
        }
    }
}
