using System;

namespace Patrones
{
	public class FactoryArbolesGrandes: FactoryDecorator
	{
		private readonly ISector sector;
		
		public FactoryArbolesGrandes(ISector sector)
		{
			this.sector = sector;
		}
		
		public override ISector crearSector()
		{
			return new arbolesGrandes(sector);
		}
	}
}
