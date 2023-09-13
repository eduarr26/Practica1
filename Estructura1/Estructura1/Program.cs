
namespace Estructura1
{
    public class Estructura
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.nombre = "Jose";

            Console.WriteLine(empleado.nombre);

            Maestro maestro = new Maestro();
            maestro.nombre = "Alex";

        }

    }
}
