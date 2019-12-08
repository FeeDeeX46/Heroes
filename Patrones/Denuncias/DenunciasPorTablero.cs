using System;
using System.Collections.Generic;

namespace Patrones
{
	public class DenunciasPorTablero: IDenuncias, IObserver
	{
		private readonly List<IDenuncia> listaDenuncias = new List<IDenuncia>();
		
		public IIteratorDenuncias getIterator()
		{
			return new IteratorTablero(listaDenuncias);
		}
		
		public void alarmaDeIncendio(ILugar lugar)
		{
			var denuncia = new DenunciaDeIncendio(lugar);
			listaDenuncias.Add(denuncia);
		}
	}
}
