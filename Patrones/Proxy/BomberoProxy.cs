using System;

namespace Patrones
{
	public class BomberoProxy: ManejadorDeDenuncias, IResponsable
	{
		Bombero bomberoReal;
		IHerramienta herramienta;
		IVehiculo vehiculo;
		
		public BomberoProxy(ManejadorDeDenuncias m): base (m)
		{
			this.vehiculo = new Autobomba();
			this.herramienta = new Manguera();
		}		
		
		public override void apagarIncendio(ILugar lugar, Calle calle)
		{
			if (bomberoReal == null)
			{
				bomberoReal = new Bombero();
			}
			
			bomberoReal.setHerramienta(herramienta);
			bomberoReal.setVehiculo(vehiculo);
			bomberoReal.apagarIncendio(lugar, calle);
		}
		
		public void setHerramienta(IHerramienta herramienta)
		{
			this.herramienta = herramienta;
		}
		
		public IHerramienta getHerramienta()
		{
			return bomberoReal.getHerramienta();
		}
		
		public void setVehiculo(IVehiculo vehiculo)
		{
			this.vehiculo = vehiculo;
		}
		
		public IVehiculo getVehiculo()
		{
			return bomberoReal.getVehiculo();
		}
	}
}
