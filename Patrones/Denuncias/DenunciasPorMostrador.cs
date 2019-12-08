using System;

namespace Patrones
{
	public class DenunciasPorMostrador: IDenuncias
	{
		private readonly IDenuncia denuncia;
		
		public DenunciasPorMostrador(ILugar lugar)
		{
			denuncia = new DenunciaDeIncendio(lugar);
		}
		
		public IIteratorDenuncias getIterator()
		{
			return new IteratorMostrador(denuncia);
		}		
	}
}
