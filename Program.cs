
using EspacioCalculadora;

int operacion=1;
double termino;
var calculadora=new Calculadora();

do
{
    Console.WriteLine("==================");
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Limpiar");
    Console.WriteLine("0- Salir");
    Console.WriteLine("==================");
    Console.WriteLine("Ingrese una Operacion: ");
    bool controlOp=int.TryParse(Console.ReadLine(), out operacion);

    if(controlOp && operacion<6)
    {
        if(operacion!=0)
        {
            if(operacion!=5)
            {
                Console.WriteLine("Ingrese un numero: ");
                bool controNum=double.TryParse(Console.ReadLine(), out termino);

                if(controNum)
                {
                    switch (operacion)
                    {
                        case 1:
                        calculadora.Sumar(termino);
                        break;
                        case 2:
                        calculadora.Restar(termino);
                        break;
                        case 3:
                        calculadora.Multiplicar(termino);
                        break;
                        case 4:
                        calculadora.Dividir(termino);
                        break;

                        default:
                        Console.WriteLine("La Operacion Ingresada no existe");
                        break;
                    }
                }else
                {
                    Console.WriteLine("No Ingreso un numero");
                }

            }else
            {
                calculadora.Limpiar();
            }

        }else
        {
            Console.WriteLine("Resultado Total: "+calculadora.Resultado);
        }

    }else
    {
        Console.WriteLine("Operacion Incorrecta, Ingrese nuevamente");
    }
} while (operacion!=0);