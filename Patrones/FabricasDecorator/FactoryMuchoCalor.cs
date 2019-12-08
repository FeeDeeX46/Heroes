using System;

namespace Patrones
{
	public class FactoryMuchoCalor: FactoryDecorator
	{
		private readonly ISector sector;
		private readonly int temperatura;
		
		public FactoryMuchoCalor(ISector sector, int temperatura)
		{
			this.sector = sector;
			this.temperatura = temperatura;
		}
		
		public override ISector crearSector()
		{
			return new muchoCalor(sector, temperatura);
		}
	}
}
