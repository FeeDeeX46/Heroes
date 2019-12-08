using System;

namespace Patrones
{
	public class Desfibrilador: IHerramienta
	{
		public void usar()
		{
			Console.WriteLine("[!] Usando desfibrilador");
		}
		public void guardar()
		{
			Console.WriteLine("[!] Guardando desfibrilador\n\n");
		}		
	}
}
