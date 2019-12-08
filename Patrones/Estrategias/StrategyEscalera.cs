using System;

namespace Patrones
{
	public class StrategyEscalera: IStrategy
	{
		public void apagarIncendio(ILugar lugar, Calle calle)
		{
			Console.WriteLine("Un bombero esta apagando el incendio con el metodo Escalera en la " + lugar.ToString() + "\n");
			
			Console.WriteLine("\nEl fuego de la " + lugar.ToString() + " fue extinguido en su totalidad!!");
		}
	}
}
