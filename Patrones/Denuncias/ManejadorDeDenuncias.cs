using System;

namespace Patrones
{
	public abstract class ManejadorDeDenuncias
	{
		private ManejadorDeDenuncias sucesor = null;
		protected bool kit = false; //Bandera que permite identificar si un Responsable tiene asignado vehiculo/herramienta.
		
		public ManejadorDeDenuncias(ManejadorDeDenuncias sucesor)
		{
			this.sucesor = sucesor;
		}	
		
		public ManejadorDeDenuncias(){}

		public virtual void apagarIncendio(ILugar lugar, Calle calle)
		{
			if (this.sucesor != null)
			{
				this.sucesor.apagarIncendio(lugar, calle);
			}
		}		
		
		public virtual void atenderInfarto(IInfartable passerby)
		{
			if (this.sucesor != null)
			{
				this.sucesor.atenderInfarto(passerby);
			}
		}
		
		public virtual void cambiarLamparasQuemadas(IIluminable lugar)
		{
			if (this.sucesor != null)
			{
				this.sucesor.cambiarLamparasQuemadas(lugar);
			}
		}
		
		public virtual void patrullarCalles(IPatrullable lugar)
		{
			if (this.sucesor != null)
			{
				this.sucesor.patrullarCalles(lugar);
			}
		}
		
	}
}
