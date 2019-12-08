using System;

namespace Patrones
{

	public class diaLluvioso: DecoratorSector
	{
		private readonly ISector sector;
		private readonly int intensidadLluvia;
		
		public diaLluvioso(ISector s, int intensidadLluvia): base (s)
		{
			this.sector = s;
			this.intensidadLluvia = intensidadLluvia;
		}
		
		public override void mojar(double agua)
		{
			sector.mojar(agua + intensidadLluvia);
		}
		
        public override string ToString()
        {
            return "Dia lluvioso, " + sector.ToString();
        }
	}
}
