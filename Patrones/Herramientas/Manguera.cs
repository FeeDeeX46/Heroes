using System;

namespace Patrones
{
	public class Manguera: IHerramienta
	{
		public void usar()
		{
			Console.WriteLine("[!] Usando manguera");
		}
		public void guardar()
		{
			Console.WriteLine("[!] Guardando manguera\n\n");
		}		
	}
}
