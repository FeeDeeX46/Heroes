using System;

namespace Patrones
{
	public class AdapterInfartable: IInfartable
	{
		private readonly Passerby passerby;
		
		public AdapterInfartable(Passerby passerby)
		{
			this.passerby = passerby;
		}
		
		public bool estaConciente()
		{
			return passerby.estaConciente();
		}
		
		public bool estaRespirando()
		{
			return passerby.estaRespirando();
		}
		
		public bool tieneRitmoCardiaco()
		{
			return passerby.tieneRitmoCardiaco();
		}
	}
}
