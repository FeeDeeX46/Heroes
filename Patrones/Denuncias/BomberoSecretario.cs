using System;

namespace Patrones
{

	public class BomberoSecretario
	{
		private readonly Bombero bombero;
		
		public BomberoSecretario(Bombero bombero)
		{
			this.bombero = bombero;
		}
		
		public void atenderDenuncias(IDenuncias denuncias)
		{
			var iterator = denuncias.getIterator();
			iterator.primero();
			
			while (!iterator.fin())
			{
				iterator.actual().atender(bombero);
				iterator.siguiente();
			}
		}
	}
}
