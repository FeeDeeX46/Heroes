using System;

namespace Patrones
{
	public class FactoryDiaLluvioso: FactoryDecorator
	{
		private readonly ISector sector;
		private readonly int intensidad;
		
		public FactoryDiaLluvioso(ISector sector, int intensidad)
		{
			this.sector = sector;
			this.intensidad = intensidad;
		}
		
		public override ISector crearSector()
		{
			return new diaLluvioso(sector, intensidad);
		}
	}
}
