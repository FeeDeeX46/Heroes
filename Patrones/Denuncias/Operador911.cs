using System;

namespace Patrones
{
	public class Operador911
	{
		private IResponsable responsable = null;
		
		public Operador911(IResponsable responsable)
		{
			this.responsable = responsable;
		}
		
		public void atenderDenuncias(IDenuncias denuncias)
		{
			var iterator = denuncias.getIterator();
			iterator.primero();
			
			while (!iterator.fin())
			{
				var denuncia = iterator.actual();
				denuncia.atender(this.responsable);
				iterator.siguiente();
			}
		}
	}
}
