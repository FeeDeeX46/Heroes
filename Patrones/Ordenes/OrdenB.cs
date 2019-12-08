using System;

namespace Patrones
{
	public class OrdenB: IOrden
	{
		public void ejecutar(IPatrullable patrullable)
		{
			Console.WriteLine("[!] Persiguiendo al delincuente en la " + patrullable + "\n");
		}
	}
}
