using System;

namespace Patrones
{
	public class DenunciaDeRobo: IDenuncia
	{
		private readonly IPatrullable lugar;
		
		public DenunciaDeRobo(IPatrullable lugar)
		{
			this.lugar = lugar;
		}
		
		public void atender(IResponsable responsable)
		{
			var manejador = (ManejadorDeDenuncias) responsable;
			manejador.patrullarCalles(lugar);
		}		
	}
}
