using System;

namespace Patrones
{
	public class FactoryGenteAsustada: FactoryDecorator
	{
		private readonly ISector sector;
		private readonly int cantidadGente;
		
		public FactoryGenteAsustada(ISector sector, int cantidadGente)
		{
			this.sector = sector;
			this.cantidadGente = cantidadGente;
		}
		
		public override ISector crearSector()
		{
			return new genteAsustada(sector, cantidadGente);
		}
	}
}
