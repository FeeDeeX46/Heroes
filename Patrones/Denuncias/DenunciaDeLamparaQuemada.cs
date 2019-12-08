using System;

namespace Patrones
{
	public class DenunciaDeLamparaQuemada: IDenuncia
	{
		private readonly IIluminable lugar;
		
		public DenunciaDeLamparaQuemada(IIluminable lugar)
		{
			this.lugar = lugar;
		}
		
		public void atender(IResponsable responsable)
		{
			var manejador = (ManejadorDeDenuncias) responsable;
			manejador.cambiarLamparasQuemadas(lugar);
		}
	}
}
