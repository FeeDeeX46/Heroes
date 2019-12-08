using System;

namespace Patrones
{
	public class FactoryPastoSeco: FactoryDecorator
	{
		private readonly ISector sector;
		
		public FactoryPastoSeco(ISector sector)
		{
			this.sector = sector;
		}
		
		public override ISector crearSector()
		{
			return new PastoSeco(sector);
		}
	}
}
