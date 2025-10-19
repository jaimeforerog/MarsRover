using FluentAssertions;

namespace MarsRover;

public class MarsRoverTest
{
    [Fact]
    public void Si_Envio_vacio_Debe_Retornar_00_N()
    {
        //arrenge
        string movimiento = "";
        //Act
        string resultado = RealizarMovimiento( movimiento);
        //Assert
        resultado.Should().Be("0,0:N");

    }
    
    [Fact]
    public void Si_Envio_M_Debe_Retornar_01_N()
    {
        //arrenge
        string movimiento = "M";
        //Act
        string resultado = RealizarMovimiento( movimiento);
        //Assert
        resultado.Should().Be("0,1:N");

    }

    private string RealizarMovimiento(string movimiento)
    {
       if (movimiento=="")
          return "0,0:N";
       return "0,1:N";
    }
}