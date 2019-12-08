using System;

namespace Patrones
{

	public class Bombero: ManejadorDeDenuncias, IObserver, IResponsable
	{
		private IStrategy estrategia = null;
		private IHerramienta herramienta;
		private IVehiculo vehiculo;
		
		public Bombero(ManejadorDeDenuncias m): base (m)
		{
			this.vehiculo = new Autobomba();
			this.herramienta = new Manguera();
		}
		
		public Bombero(){}
		
		public override void apagarIncendio(ILugar lugar, Calle calle)
		{
			if (kit == true)
			{
				vehiculo.encenderSirena();
				vehiculo.conducir();
				herramienta.usar();
			}
			
			estrategia.apagarIncendio(lugar, calle);
			
			if (kit == true)
				herramienta.guardar();
		}

		public void setStrategy(string strategy)
		{
			switch(strategy)
			{
				case ("Escalera"):
				{
					Console.WriteLine(">> Estrategia seteada a Escalera");
					estrategia = new StrategyEscalera();
					break;
				}
				case ("Espiral"):
				{
					Console.WriteLine(">> Estrategia seteada a Espiral");
					estrategia = new StrategyEspiral();
					break;
				}
				case ("Secuencial"):
				{
					Console.WriteLine(">> Estrategia seteada a Secuencial");	
					estrategia = new StrategySecuencial();
					break;
				}
			}
		}
		
		public void bajarGatitoDeArbol()
		{
			Console.WriteLine("Un bombero esta bajando del arbol a un gatito");
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

		public void alarmaDeIncendio(ILugar lugar)
		{
			this.apagarIncendio(lugar, lugar.getCalle());
		}
	}
}
