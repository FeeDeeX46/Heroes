using System;

namespace Patrones
{

	public class arbolesGrandes: DecoratorSector
	{	
		private readonly ISector sector;
		
		public arbolesGrandes(ISector s): base (s)
		{
			sector = s;
		}
		
		public override void mojar(double agua)
		{
			sector.mojar(agua - (agua * 0.25));
		}
		
		public override string ToString()
		{
			return "Arboles grandes, " + sector.ToString();
		} 
	}
}
