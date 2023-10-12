using calculadora;

namespace calculadoraTests;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 2, 5)]
    public void TesteSomar(int val1, int val2, int resultadoEsperado)
    {
        Calculadora calc = new Calculadora();
        
        int resultado = calc.somar(val1, val2);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(5, 1, 4)]
    [InlineData(3, 2, 1)]
    public void TesteSubtrair(int val1, int val2, int resultadoEsperado)
    {
        Calculadora calc = new Calculadora();
        
        int resultado = calc.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(3, 2, 6)]
    public void TesteMultiplicar(int val1, int val2, int resultadoEsperado)
    {
        Calculadora calc = new Calculadora();
        
        int resultado = calc.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(6, 2, 3)]
    public void TesteDividir(int val1, int val2, int resultadoEsperado)
    {
        Calculadora calc = new Calculadora();
        
        int resultado = calc.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void TesteDividirPorZero()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(5, 0)
        );
    }

    [Fact]
    public void TesteHistorico()
    {
        Calculadora calc = new Calculadora();

        calc.somar(1, 1);
        calc.somar(2, 3);
        calc.somar(4, 2);
        calc.somar(3, 3);
        calc.somar(1, 4);

        List<string> lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count());
    }


}