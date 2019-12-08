using System;

namespace Patrones
{
	public class FactoryMuchoViento: FactoryDecorator
	{
		private readonly ISector sector;
		private readonly int velocidadViento;
		
		public FactoryMuchoViento(ISector sector, int velocidadViento)
		{
			this.sector = sector;
			this.velocidadViento = velocidadViento;
		}
		
		public override ISector crearSector()
		{
			return new muchoViento(sector, velocidadViento);
		}
	}
}
