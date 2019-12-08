using System;
using System.Collections.Generic;

namespace Patrones
{
	public class DenunciasPorWhatsapp: IDenuncias
	{
		private readonly MensajeWhatsApp denuncia;
		
		public DenunciasPorWhatsapp(MensajeWhatsApp denuncia)
		{
			this.denuncia = denuncia;
		}
		
		public IIteratorDenuncias getIterator()
		{
			return new IteratorWhatsApp(denuncia);
		}
	}
}
