using System;

namespace Patrones
{
	public class BuilderBasic: BuilderDecorator
	{
		public override ISector construirDecorator()
		{
			Random r = new Random();
			int afeccion = r.Next(101);
			var sector = new Sector(afeccion);
			return FactoryDecorator.crearDecorator(sector, "Basico");
		}
	}
}
