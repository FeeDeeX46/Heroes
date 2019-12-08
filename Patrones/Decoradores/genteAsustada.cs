using System;

namespace Patrones
{

	public class genteAsustada: DecoratorSector
	{
		private readonly ISector sector;
		private int cantidadPersonas;
		
		public genteAsustada(ISector s, int cantidadPersonas): base (s)
		{
			this.sector = s;
			this.cantidadPersonas = cantidadPersonas;
		}
		
		public override void mojar(double agua)
		{
			if (cantidadPersonas == 5)
			{
            agua = this.cantidadPersonas == 5 ? (agua - (agua * 0.75)) : agua;
            this.sector.mojar(agua);
        }
			
			sector.mojar(agua);	
		}
		
		public override string ToString()
		{
			return "Gente asustada, " + sector.ToString();
		}
	}
}
