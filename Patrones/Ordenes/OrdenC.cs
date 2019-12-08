using System;

namespace Patrones
{
	public class OrdenC: IOrden
	{
		public void ejecutar(IPatrullable patrullable)
		{
			Console.WriteLine("[!] Avisando a la comisaría y pidiendo refuerzos en la " + patrullable + "\n");
		}
	}
}
