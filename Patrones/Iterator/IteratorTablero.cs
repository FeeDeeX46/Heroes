using System;
using System.Collections.Generic;
using System.Linq;

namespace Patrones
{
	public class IteratorTablero: IIteratorDenuncias
	{
		private int actualDenuncia;
		private readonly List<IDenuncia> denuncias;
		
		public IteratorTablero(List<IDenuncia> denuncias)
		{
			this.actualDenuncia = 0;
			this.denuncias = denuncias;
		}
		
		public void primero()
		{
			this.actualDenuncia = 0;
		}
		
		public void siguiente()
		{
			this.actualDenuncia++;
		}
		
		public bool fin()
		{
			return actualDenuncia == this.denuncias.Count();
		}
		
		public IDenuncia actual()
		{
			return this.denuncias[actualDenuncia];
		}
	}
}
