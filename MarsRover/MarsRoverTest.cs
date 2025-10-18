using FluentAssertions;

namespace MarsRover;

public class MarsRoverTest
{
    [Fact]
    public void SiEnvio_vacio_Debe_Retornar_00_N()
    {
        //arrenge
        string movimiento = "";
        //Act
        string resultado = RealizarMovimiento( movimiento);
        //Assert
        resultado.Should().Be("0,0:N");

    }

    private string RealizarMovimiento(object numero)
    {
        throw new NotImplementedException();
    }
}