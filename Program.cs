using EspacioEmpleado;

Empleado empleado1 = new Empleado("Mateo", "Coronel", new DateTime(1998, 8, 14), 'C', new DateTime(2015, 7, 18), 550000, Cargos.Especialista);
Empleado empleado2 = new Empleado("Joaquin", "Pereyra", new DateTime(1985, 10, 15), 'C', new DateTime(2009, 5, 20), 650000, Cargos.Ingeniero);
Empleado empleado3 = new Empleado("Adrian", "Sanchez", new DateTime(2000, 2, 18), 'S', new DateTime(2018, 3, 12), 400000, Cargos.Administrativo);

/*Cargue los datos para 3 empleados en un arreglo de tipo empleados.*/
Empleado[] empleados={empleado1, empleado2, empleado3};

/*Obtener el Monto Total de lo que se paga en concepto de Salarios.*/
Console.WriteLine("Monto total de Salarios: " +(empleado1.Salario()+empleado2.Salario()+empleado3.Salario()));

/*Muestre por pantalla los datos del empleado que esté más próximo a jubilarse*/
Empleado empleadoAjubilarse = empleado1;

foreach (Empleado empleado in empleados)
{
    if(empleado.AniosParaJubilarse() < empleadoAjubilarse.AniosParaJubilarse())
    {
        empleadoAjubilarse=empleado;
    }
}

Console.WriteLine("---- Datos del empleado Más próximo a jubilarse ----");
empleadoAjubilarse.MostrarDatos();