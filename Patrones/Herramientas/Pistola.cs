using System;

namespace Patrones
{
	public class Pistola: IHerramienta
	{
		public void usar()
		{
			Console.WriteLine("[!] Usando pistola");
		}
		public void guardar()
		{
			Console.WriteLine("[!] Guardando pistola\n\n");
		}
	}
}
