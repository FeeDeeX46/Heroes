using System;

namespace Patrones
{
	
	public class PastoSeco: DecoratorSector
	{	
		private readonly ISector sector;
		
		public PastoSeco(ISector s): base (s)
		{
			this.sector = s;
		}
		
		public override void mojar(double agua)
		{	
			sector.mojar(agua/2);
		}
		
        public override string ToString()
        {
            return "Pasto seco, " + sector.ToString();
        }		
	}
}
