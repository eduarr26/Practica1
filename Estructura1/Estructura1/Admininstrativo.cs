
namespace Estructura1
{
    public class Admininstrativo : Empleado
    {
        public string Departamento { set; get; }
        public string DescripcionPuesto { set; get; }

        public void Copias()
        {
            Console.WriteLine("Sacando copias");
        }


    }
}
