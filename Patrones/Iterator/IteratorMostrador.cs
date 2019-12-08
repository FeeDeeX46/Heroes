
namespace Patrones
{
	public class IteratorMostrador: IIteratorDenuncias
	{
		private readonly IDenuncia denuncia;
		private int denunciaActual;
		
		public IteratorMostrador(IDenuncia denuncia)
		{
			this.denuncia = denuncia;
		}
		
		public void primero()
		{
			this.denunciaActual = 0;
		}
		
		public void siguiente()
		{
			denunciaActual++;
		}
		
		public bool fin()
		{
			return denunciaActual > 0;
		}
		
		public IDenuncia actual()
		{
			return denuncia;
		}
	}
}
