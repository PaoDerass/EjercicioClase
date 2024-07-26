using EjercicioClase;

SuperPoder SuperPoder1 = new SuperPoder();
SuperPoder1.nombre = "Velocidad";
SuperPoder1.descripcion = "Capacidad de ser veloz";
SuperPoder1.nivel = 7;

SuperPoder SuperPoder2 = new SuperPoder();
SuperPoder2.nombre = "Super Fuerza";
SuperPoder2.descripcion = "Capacidad de mucha fuerza";
SuperPoder2.nivel = 9;

SuperPoder SuperPoder3 = new SuperPoder();
SuperPoder3.nombre = "Sentidos aracnidos";
SuperPoder3.descripcion = "Capacidad de tirar telarañas";
SuperPoder3.nivel = 8;


SuperHeroe SuperHeroe1 = new SuperHeroe();
SuperHeroe1.nombre = "Flash";
SuperHeroe1.identidadSecreta = "Bartholomew Henry Allen";
SuperHeroe1.ciudad = "Central City";
SuperHeroe1.puedeVolar = false;
SuperHeroe1.superPoder= SuperPoder1;



SuperHeroe SuperHeroe2 = new SuperHeroe();
SuperHeroe2.nombre = "Hulk";
SuperHeroe2.identidadSecreta = "Bruce Banner";
SuperHeroe2.ciudad = "Ohio, Estados Unidos";
SuperHeroe2.puedeVolar = false;
SuperHeroe2.superPoder = SuperPoder2;



SuperHeroe SuperHeroe3 = new SuperHeroe();
SuperHeroe3.nombre = "SpiderMan";
SuperHeroe3.identidadSecreta = "Peter Parker";
SuperHeroe3.ciudad = "New York";
SuperHeroe3.puedeVolar = true;
SuperHeroe3.superPoder = SuperPoder3;

SuperHeroe1.Imprimir();
Console.WriteLine();
SuperHeroe2.Imprimir();
Console.WriteLine();
SuperHeroe3.Imprimir();



