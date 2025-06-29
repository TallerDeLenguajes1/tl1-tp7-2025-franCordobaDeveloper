using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisPersonal
{
    public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; } // 'S' = soltero, 'C' = casado
        public DateTime FechaDeIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public Cargo CargoEmpleado { get; set; }


        public Empleado(
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            char estadoCivil,
            DateTime fechaDeIngreso,
            double sueldoBasico,
            Cargo cargoEmpleado
        )
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            FechaDeIngreso = fechaDeIngreso;
            SueldoBasico = sueldoBasico;
            CargoEmpleado = cargoEmpleado;
        }

        public int Edad()
        {
            DateTime hoy = DateTime.Today;

            int edad = hoy.Year - FechaNacimiento.Year;

            if (FechaNacimiento.Date > hoy.AddYears(-edad))
                edad--;

            return edad;
        }

        public int Antiguedad()
        {
            DateTime hoy = DateTime.Today;

            int antiguedad = hoy.Year - FechaDeIngreso.Year;

            if (FechaDeIngreso.Date > hoy.AddYears(-antiguedad))
                antiguedad--;

            return antiguedad;
        }

        public int AniosParaJubilarse()
        {
            return Math.Max(0, 65 - Edad());
        }

        public double CalcularAdicional()
        {
           double adicional = 0;

            if (Antiguedad() < 20)
                adicional = SueldoBasico * (0.01 * Antiguedad());
            else
                adicional = SueldoBasico * 0.25;

            if (CargoEmpleado == Cargo.Ingeniero || CargoEmpleado == Cargo.Especialista)
                adicional *= 1.5;

            if (EstadoCivil == 'C')
                adicional += 150000;

            return adicional; 
        }

        public double CalcularSalario()
        {
            return SueldoBasico + CalcularAdicional();
        }

        public void MostrarInformacionEmpleados()
        {
            Console.WriteLine($"Nombre Completo: {Nombre} {Apellido}");
            Console.WriteLine($"Edad: {Edad()}");
            Console.WriteLine($"Antiguedad: {Antiguedad()}");
            Console.WriteLine($"Anios para jubilarse: {AniosParaJubilarse()}");
            Console.WriteLine($"Cargo: {CargoEmpleado}");
            Console.WriteLine($"Estado Civil: {(EstadoCivil == 'C' ? "Casado/a" : "Soltero/a")}");
            Console.WriteLine($"Sueldo Basico: {SueldoBasico:C}");
            Console.WriteLine($"Salario Total: {CalcularSalario()}");
            Console.WriteLine($"");
            Console.WriteLine($"____________________________________");
        }



    }
}
