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
        string resultado = RealizarMovimiento(movimiento);
        //Assert
        resultado.Should().Be("0,0:N");

    }

 

    [Fact]
    public void Si_Envio_M_Debe_Retornar_01_N()
    {
        //arrenge
        string movimiento = "M";
        //Act
        string resultado = RealizarMovimiento(movimiento);
        //Assert
        resultado.Should().Be("0,1:N");

    }

    [Fact]
    public void Si_Envio_MR_Debe_Retornar_01_E()
    {
        //arrenge
        string movimiento = "MR";
        //Act
        string resultado = RealizarMovimiento(movimiento);
        //Assert
        resultado.Should().Be("0,1:E");

    }
    public enum Orientacion
    {
        N,
        E,
        S,
        W
    }

    public class MarsRover
    {
        public int PosicionX { set; get; } = 0;
        public int PosicionY { set; get; } = 0;

        public Orientacion Orientacion { set; get; } = Orientacion.N;

    }

    private string RealizarMovimiento(string movimiento)
    {
        var rover = new MarsRover();

        foreach (var comando in movimiento)
        {
            if (comando == 'M')
            {
                if (rover.Orientacion == Orientacion.N)
                    rover.PosicionY++;
            }
            else if (comando == 'R')
            {
                if (rover.Orientacion == Orientacion.N)
                    rover.Orientacion = Orientacion.E;
            }
        }

        return $"{rover.PosicionX},{rover.PosicionY}:{rover.Orientacion}";
    }
}

   