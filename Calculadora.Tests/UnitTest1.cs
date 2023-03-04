using Calculadora;

namespace Console.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow(8,2,10)]
    [DataRow(1,5,6)]
    public void SomaDoisNumeros(int num1, int num2, int resultadoEsperado)
    {        
        //Arrange        
        var calculadoraServices = new CalculadoraServices();
        //ACT
        var resultado = calculadoraServices.Soma(num1, num2);
        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    [DataRow(8, 2, 6)]
    [DataRow(5, 1, 4)]
    public void SubtraiDoisNumeros(int num1, int num2, int resultadoEsperado)
    {
        //Arrange        
        var calculadoraServices = new CalculadoraServices();
        //ACT
        var resultado = calculadoraServices.Substracao(num1, num2);
        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

}