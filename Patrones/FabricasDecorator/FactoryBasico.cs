using System;

namespace Patrones
{
	public class FactoryBasico: FactoryDecorator
	{
		private readonly ISector sector;
		
		public FactoryBasico(ISector sector)
		{
			this.sector = sector;
		}
		
		public override ISector crearSector()
		{
			return sector;
		}
	}
}
