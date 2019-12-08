using System;

namespace Patrones
{
	public class Buscapolo: IHerramienta
	{
		public void usar()
		{
			Console.WriteLine("[!] Usando buscapolo");
		}
		public void guardar()
		{
			Console.WriteLine("[!] Guardando buscapolo\n\n");
		}
	}
}
