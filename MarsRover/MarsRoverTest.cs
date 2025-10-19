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
    [Fact]
    public void Si_Envio_RR_Debe_Retornar_00_S()
    {
        //arrenge
        string movimiento = "RR";
        //Act
        string resultado = RealizarMovimiento(movimiento);
        //Assert
        resultado.Should().Be("0,0:S");

    }

    [Fact]
    public void Si_Envio_L_Debe_Retornar_00_W()
    {
        //arrenge
        string movimiento = "L";
        //Act
        string resultado = RealizarMovimiento(movimiento);
        //Assert
        resultado.Should().Be("0,0:W");
    }
    [Fact]
    public void Si_Envio_MRRM_Debe_Retornar_00_S()
    {
        //arrenge
        string movimiento = "MRRM";
        //Act
        string resultado = RealizarMovimiento(movimiento);
        //Assert
        resultado.Should().Be("0,0:S");
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
            if (comando == 'L')
            {
                rover.Orientacion = (Orientacion)(((int)rover.Orientacion - 1+4) % 4);
            }
            else if (comando == 'R')
            {
                rover.Orientacion = (Orientacion)(((int)rover.Orientacion + 1) % 4);
            }
            if (comando == 'M')
            {
                if (rover.Orientacion == Orientacion.N)
                    rover.PosicionY++;
                if (rover.Orientacion == Orientacion.S)
                    rover.PosicionY--;
            }
        }

        return $"{rover.PosicionX},{rover.PosicionY}:{rover.Orientacion}";
    }
}

   