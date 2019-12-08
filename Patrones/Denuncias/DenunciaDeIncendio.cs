using System;

namespace Patrones
{
	public class DenunciaDeIncendio: IDenuncia
	{
		private readonly ILugar lugar;
		
		
		public DenunciaDeIncendio(ILugar lugar)
		{
			this.lugar = lugar;
		}
		
		public void atender(IResponsable responsable)
		{
			var manejador = (ManejadorDeDenuncias) responsable;
			manejador.apagarIncendio(lugar, lugar.getCalle());
		}
	}
}
