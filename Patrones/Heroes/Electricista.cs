using System;

namespace Patrones
{

	public class Electricista: ManejadorDeDenuncias, IResponsable
	{
		private IHerramienta herramienta;
		private IVehiculo vehiculo;
		
		
		public Electricista(ManejadorDeDenuncias m): base (m)
		{
			this.vehiculo = new Camioneta();
			this.herramienta = new Buscapolo();
		}
		
		public Electricista(){}	
		
		public void revisar(IIluminable iluminable)
		{
			if (kit == true)
			{
				vehiculo.encenderSirena();
				vehiculo.conducir();
				herramienta.usar();			
			}
			
			Console.WriteLine("Un electricista esta revisando");
			
			if (kit == true)
				herramienta.guardar();
		}
		
		public override void cambiarLamparasQuemadas(IIluminable lugar)
		{
			Console.WriteLine("Un electricista esta cambiando las lamparas quemadas");
		}

		public IHerramienta getHerramienta()
		{
			return herramienta;
		}
		
		public void setHerramienta(IHerramienta herramienta)
		{
			kit = true;
			this.herramienta = herramienta;
		}

		public IVehiculo getVehiculo()
		{
			return vehiculo;
		}
		
		public void setVehiculo(IVehiculo vehiculo)
		{
			kit = true;
			this.vehiculo = vehiculo;
		}		
	}
}
