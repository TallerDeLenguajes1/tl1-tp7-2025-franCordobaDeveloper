using SisPersonal;

class Program
{
    static void Main()
    {
        //Cargue los datos para 3 empleados en un arreglo de tipo empleados
        Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado("Francisco","Cordoba", new DateTime(1997, 11, 22), 'C', new DateTime(2023, 06, 22), 800000.00, Cargo.Ingeniero);
        empleados[1] = new Empleado("Facundo","Cordoba", new DateTime(1999, 09, 22), 'C', new DateTime(2020, 06, 22), 800000.00, Cargo.Administrativo);
        empleados[2] = new Empleado("Jose Luis","Palisa", new DateTime(1958, 03, 19), 'C', new DateTime(1994, 06, 22), 800000.00, Cargo.Auxiliar);

        Console.WriteLine("----- Datos de los Empleados -----");

        foreach (var emp in empleados)
        {
            emp.MostrarInformacionEmpleados();
        }

        //Obtener el Monto Total de lo que se paga en concepto de Salarios.
        double totalSalariosDeTodosLosEmpleados = 0;
        foreach (var item in empleados)
        {
            totalSalariosDeTodosLosEmpleados += item.CalcularSalario();
        }
        Console.WriteLine($"\n Total pagado en salarios: {totalSalariosDeTodosLosEmpleados:C}");

        //Muestre por pantalla los datos del empleado que esté más próximo a
        //jubilarse (incluyendo los datos del apartado 2.a y el salario
        //correspondiente.
        var porJubilar = empleados.OrderBy(e => e.AniosParaJubilarse()).First();
        Console.WriteLine("\nEmpleado más próximo a jubilarse:");
        porJubilar.MostrarInformacionEmpleados();

    }
}