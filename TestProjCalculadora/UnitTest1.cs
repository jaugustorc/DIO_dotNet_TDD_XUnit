using ProjCalculadora;

namespace TestProjCalculadora
{
    public class UnitTest1
    {
        /// <summary>
        /// Teste de soma de dois valores
        /// </summary>
        /// <param name="num1">valor 1</param>
        /// <param name="num2">valor 2</param>
        /// <param name="result">resultado esperado</param>
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(4, 53, 57)]
        public void TestSomar(int num1, int num2, int result)
        {
            Calculadora calc = new();

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(result, resultado);
        }
        /// <summary>
        /// Teste de subtrai de dois valores
        /// </summary>
        /// <param name="num1">valor 1</param>
        /// <param name="num2">valor 2</param>
        /// <param name="result">resultado esperado</param>
        [Theory]
        
        [InlineData(2, 1, 1)]
        [InlineData(53, 4, 49)]
        public void TestSubtrai(int num1, int num2, int result)
        {
            Calculadora calc = new();

            int resultado = calc.Subtrair(num1, num2);

            Assert.Equal(result, resultado);
        }
        /// <summary>
        /// Teste de multiplicação de dois valores
        /// </summary>
        /// <param name="num1">valor 1</param>
        /// <param name="num2">valor 2</param>
        /// <param name="result">resultado esperado</param>
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(4, 23, 92)]
        public void TestMultiplicar(int num1, int num2, int result)
        {
            Calculadora calc = new();

            int resultado = calc.Multiplicar(num1, num2);

            Assert.Equal(result, resultado);
        }
        /// <summary>
        /// Teste de divisão de dois valores
        /// </summary>
        /// <param name="num1">valor 1</param>
        /// <param name="num2">valor 2</param>
        /// <param name="result">resultado esperado</param>
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(4, 4, 1)]
        public void TestDiv(int num1, int num2, int result)
        {
            Calculadora calc = new();

            int resultado = calc.Dividir(num1, num2);

            Assert.Equal(result, resultado);
        }
        /// <summary>
        /// Testa divisão por zero
        /// </summary>
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new();

            Assert.Throws<DivideByZeroException>(()=>calc.Dividir(3,0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new();

            calc.Somar(1, 2);
            calc.Somar(1, 2);
            calc.Somar(1, 2);
            calc.Somar(1, 2);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}