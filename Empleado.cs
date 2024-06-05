namespace EspacioEmpleado
{
    public enum Cargos {Auxiliar, Administrativo, Ingeniero, Especialista, Investigador}

    public class Empleado
    {
        //Campos Privados
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        //Propiedades Públicas
        public string Nombre {get => nombre; set => nombre=value;}
        public string Apellido {get => apellido; set => apellido=value;}
        public DateTime FechaNacimiento {get => fechaNacimiento; set => fechaNacimiento=value;}
        public char EstadoCivil {get => estadoCivil; set => estadoCivil=value;}
        public DateTime FechaIngreso {get => fechaIngreso; set =>  fechaIngreso=value;}
        public double SueldoBasico {get => sueldoBasico; set => sueldoBasico=value;}
        public Cargos Cargo {get => cargo; set => cargo=value;}

        //Constructor
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo) 
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            FechaIngreso = fechaIngreso;
            SueldoBasico = sueldoBasico;
            Cargo = cargo;
        }

        //Métodos
        public int Antiguedad() 
        {
            DateTime fechaActual = DateTime.Now;
            return(fechaActual.Year-FechaIngreso.Year);
        }

        public int Edad()
        {
            DateTime fechaActual = DateTime.Now;
            return(fechaActual.Year-FechaNacimiento.Year);
        }

        public int AniosParaJubilarse()
        {
            int edad=Edad();
            return(65-edad);
        }

        public double Salario()
        {
            double Adicional=0, Salario;
            int antiguedad=Antiguedad();

            if(Antiguedad() > 20)
            {
                Adicional=SueldoBasico*0.25;
            }else{
                Adicional=(SueldoBasico*0.01)*antiguedad;
            }

            if(Cargo==Cargos.Ingeniero || Cargo==Cargos.Especialista)
            {
                Adicional *= 1.50;
            }

            if(EstadoCivil=='C')
            {
                Adicional += 150000;
            }

            Salario=SueldoBasico+Adicional;

            return(Salario);
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Fecha de Nacimiento: " + FechaNacimiento.ToString());
            Console.WriteLine("Estado civil: " + EstadoCivil);
            Console.WriteLine("Fecha de Ingreso: " + FechaIngreso.ToString());
            Console.WriteLine("Salario basico: " + SueldoBasico);
            Console.WriteLine("Cargo: " + Cargo.ToString());
            Console.WriteLine("Antiguedad en la empresa: " + Antiguedad());
            Console.WriteLine("Edad: " + Edad());
            Console.WriteLine("Anios para Jubilarse: " + AniosParaJubilarse());
            Console.WriteLine("Salario: " + Salario());
        }
    }
}