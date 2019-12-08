using System;
using System.Collections.Generic;

namespace Patrones
{
	public class CompositeNodo: IIluminable
	{
		private readonly List<IIluminable> iluminables;
		
		public CompositeNodo()
		{
			iluminables = new List<IIluminable>();
		}
		
		public void AddHijo(IIluminable iluminable)
		{
			iluminables.Add(iluminable);
		}
		
		public void removeHijo(IIluminable iluminable)
		{
			iluminables.Remove(iluminable);
		}
		
		public void revisarYCambiarLamparasQuemadas()
		{
			foreach (IIluminable iluminable in iluminables)
			{
				iluminable.revisarYCambiarLamparasQuemadas();
			}
		}
	}
}
