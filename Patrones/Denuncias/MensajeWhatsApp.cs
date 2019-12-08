using System;

namespace Patrones
{
	public class MensajeWhatsApp: IDenuncia
	{
		private readonly IDenuncia denuncia = null;
		private MensajeWhatsApp siguienteMensaje = null;
		
		public MensajeWhatsApp(IDenuncia denuncia, MensajeWhatsApp mensaje)
		{
			this.denuncia = denuncia;
			this.siguienteMensaje = mensaje;
		}
		
		public MensajeWhatsApp getSiguienteMensaje()
		{
			return siguienteMensaje;
		}
		
		public void atender(IResponsable responsable)
		{
			denuncia.atender(responsable);
		}
	}
}
