using System;

namespace Patrones
{
	public class IteratorWhatsApp: IIteratorDenuncias
	{
		private MensajeWhatsApp denuncia;
		
		public IteratorWhatsApp(MensajeWhatsApp denuncia)
		{
			this.denuncia = denuncia;
		}
		
		public void primero()
		{
			this.siguiente();
		}
		
		public void siguiente()
		{
			denuncia = denuncia.getSiguienteMensaje();
		}
		
		public bool fin()
		{
			return denuncia == null;
		}
		
		public IDenuncia actual()
		{
			return denuncia;
		}
	}
}
