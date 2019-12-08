using System;

namespace Patrones
{
	public abstract class FactoryDecorator
	{
		public static ISector crearDecorator(ISector sector, string tipo, int value = 0)
		{
			FactoryDecorator factory = null;
			
			switch (tipo)
			{
				case "ArbolesGrandes":
				{
					factory = new FactoryArbolesGrandes(sector);
					break;
				}
				case "GenteAsustada":
				{
					factory = new FactoryGenteAsustada(sector, value);
					break;
				}
				case "MuchoCalor":
				{
					factory = new FactoryMuchoCalor(sector, value);
					break;
				}
				case "MuchoViento":
				{
					factory = new FactoryMuchoViento(sector, value);
					break;
				}
				case "PastoSeco":
				{
					factory = new FactoryPastoSeco(sector);
					break;
				}
				case "Basico":
				{
					factory = new FactoryBasico(sector);
					break;
				}					
			}
			return factory.crearSector();
		}
		public abstract ISector crearSector();
	}
}
