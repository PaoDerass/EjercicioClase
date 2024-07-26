

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
            Console.WriteLine($"Identidad Secreta: {identidadSecreta}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Puede Volar: {puedeVolar}");
            Console.WriteLine($"Super Poder: {superPoder.nombre}");
            Console.WriteLine($"Descripcion: {superPoder.descripcion}");
            Console.WriteLine($"Nivel: {superPoder.nivel}");
        }

    }
}


