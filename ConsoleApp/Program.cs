using System;


/// <summary>
///POLIMORFISMO: Es la capacidad que tienen los objetos en programación a comportarse de diferente forma o a tener diferente forma dependiendo del contexto
/// </summary>

namespace ConsoleApp
{
	internal class Program
	{
		protected Program()
		{
		}

		private static void Main(string[] args)
		{
			Circulo circulo = new Circulo(); //Objeto, tiene sus propiedades y métodos
											 //Iniciación de la variable de tipo círculo, instanciar una clase, ejemplarización.
			object[] marks = new object[3];

			marks[0] = "Hola";
			marks[1] = 1;
			var values = new { Nombre = "", Cedula = "" };
			Console.WriteLine("Círculo: " + circulo.calcularArea(3));
		}
	}

	internal class Circulo
	{
		private readonly double PI = 3.1416; // propiedad de la clase círculo, campo de clase.

		public double calcularArea(int radio) //Métodos = comportamientos que tiene la clase.
		{
			return PI * radio * radio;
		}
	}

	public class Mamifero
	{
		public void CuidarCrias()
		{
			Console.WriteLine("Cuido a mis crias");
		}

		/// <summary>
		/// Permite hacer un overwrite del método para las clases que hereden de esta.
		/// es necesario, si no, aparecerá un mensaje en los métodos override
		/// </summary>
		public virtual void Pensar()
		{
			Console.WriteLine("Pensamiento mínimo");
		}

		public void Respirar()
		{
			Console.WriteLine("Soy capaz de respirar");
		}
	}

	public class Gorila : Mamifero
	{
		public void Trepar()
		{
			Console.WriteLine("Soy capaz de trepar");
		}

		public override void Pensar()
		{
			Console.WriteLine("Pensamiento básico instintivo");
		}
	}

	public class Caballo : Mamifero
	{
		public void Galopar()
		{
			Console.WriteLine("Soy capaz de galopar");
		}

		/// <summary>
		/// El override indica que será una modificación del método pensar de la clase padre en este 
		/// caso mamífero, es la clase pensar de mamífero pero con ligeras modificaciones
		/// </summary>

		public override void Pensar()
		{
			Console.WriteLine("Pensamiento básico instintivo");
		}
	}

	public class Humano : Mamifero
	{
		public override void Pensar()
		{
			Console.WriteLine("Tengo un pensamiento avanzado");
		}

		public void Hablar()
		{
			Console.WriteLine("Soy capaz de pensar");
		}
	}
}
