using System;

namespace Patrones
{
	public class DenunciaDeInfarto: IDenuncia
	{
		private readonly IInfartable infartable;
		
		public DenunciaDeInfarto(IInfartable infartable)
		{
			this.infartable = infartable;
		}
		
		public void atender(IResponsable responsable)
		{
			var manejador = (ManejadorDeDenuncias) responsable;
			manejador.atenderInfarto(infartable);
		}
	}
}
