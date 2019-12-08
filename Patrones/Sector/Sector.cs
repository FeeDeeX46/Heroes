using System;

namespace Patrones
{
	public class Sector: ISector
	{
		private double afeccion;
		
		public Sector(double afeccion)
		{
			this.afeccion = afeccion;
		}
		
		public double getAfeccion()
		{
			return afeccion;
		}
		
		public void mojar(double agua)
		{
			afeccion -= agua;
		}
		
		public bool estaApagado()
		{
			return afeccion <= 0;
		}
		
		public override string ToString()
		{
			return "Basico";
		}

	}
}
