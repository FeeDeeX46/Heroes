using System;

namespace Patrones
{

	public class muchoViento: DecoratorSector
	{
		private readonly ISector sector;
		private int velocidadViento;
		
		public muchoViento(ISector s, int velocidadViento): base (s)
		{
			this.sector = s;
			this.velocidadViento = velocidadViento;
		}
		
		public override void mojar(double agua)
		{
			sector.mojar(agua - (Math.Exp(velocidadViento/100)));
		}
		
        public override string ToString()
        {
            return "Mucho viento, " + sector.ToString();
        }
	}
}
