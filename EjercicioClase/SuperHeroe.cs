

namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string nombre { get; set; }
        public string identidadSecreta { get; set; }
        public string ciudad { get; set; }

        public bool puedeVolar { get; set; }

        public SuperPoder superPoder { get; set; }


     public void Imprimir()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Nombre: {identidadSecreta}");
            Console.WriteLine($"Nombre: {ciudad}");
            Console.WriteLine($"Nombre: {puedeVolar}");
            Console.WriteLine($"Nombre: {superPoder}");
        }

    }
}


