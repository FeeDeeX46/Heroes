using System;

namespace Patrones
{

	public class Policia: ManejadorDeDenuncias, IResponsable
	{
		private IHerramienta herramienta;
		private IVehiculo vehiculo;
		private IOrden orden;		
	
		public Policia(ManejadorDeDenuncias m): base (m)
		{
			this.vehiculo = new Patrullero();
			this.herramienta = new Pistola();
		}
		
		public Policia(){}
		
		public override void patrullarCalles(IPatrullable lugar)
		{
			if (kit == true)
			{
				vehiculo.encenderSirena();
				vehiculo.conducir();
				herramienta.usar();				
			}					
			Console.WriteLine("Un policia esta patrullando las calles...");
			
			if (lugar.hayAlgoFueraDeLoNormal())
			{
				orden.ejecutar(lugar);
			}
			else
			{
				Console.WriteLine("[!] No hay nada fuera de lo normal en la " + lugar + "\n");
			}
			if (kit == true)
				herramienta.guardar();
		}
		
		public void detenerDelincuente()
		{
			Console.WriteLine("Un policia esta deteniendo a un delincuente");
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

		public void setOrden(IOrden orden)
		{
			this.orden = orden;
		}
	}
}
