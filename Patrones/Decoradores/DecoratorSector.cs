using System;

namespace Patrones
{
	public abstract class DecoratorSector: ISector
	{
		private readonly ISector sector;
		
		protected DecoratorSector(ISector s)
		{
			sector = s;
		}
		
		public virtual bool estaApagado()
		{
			return sector.estaApagado();
		}
			
		public virtual void mojar(double agua)
		{
			sector.mojar(agua);
		}
		
		public double getAfeccion()
		{
			return sector.getAfeccion();
		}
	}
}
