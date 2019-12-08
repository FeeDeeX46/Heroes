using System;

namespace Patrones
{
	public class OrdenA: IOrden
	{
		public void ejecutar(IPatrullable patrullable)
		{
			Console.WriteLine("[!] Gritando alto para que el delincuente se vaya de la " + patrullable + "\n");
		}
	}
}
