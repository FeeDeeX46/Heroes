using System;

namespace Patrones
{

	public class muchoCalor: DecoratorSector
	{
		private readonly ISector sector;
		private readonly int temperatura;
		
		public muchoCalor(ISector s, int temperatura): base (s)
		{
			this.sector = s;
			this.temperatura = temperatura;
		}
		
		public override void mojar(double agua)
		{
			sector.mojar(agua - (temperatura));
		}
		
		public override string ToString()
		{
			return "Mucho calor, " + sector.ToString();
		}
	}
}
