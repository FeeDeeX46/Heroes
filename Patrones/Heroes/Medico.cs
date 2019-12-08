using System;

namespace Patrones
{

	public class Medico: ManejadorDeDenuncias, IResponsable
	{
		private ProtocoloRCP protocolo;
		private IHerramienta herramienta;
		private IVehiculo vehiculo;	
		
		public Medico(ProtocoloRCP protocolo)
		{
			this.protocolo = protocolo;
		}
		
		public Medico(ManejadorDeDenuncias m): base (m)
		{
			this.vehiculo = new Ambulancia();
			this.herramienta = new Desfibrilador();
		}
		
		public Medico(){}
		
		public override void atenderInfarto(IInfartable passerby)
		{	
			if (kit == true)
			{
				vehiculo.encenderSirena();
				vehiculo.conducir();
				herramienta.usar();
			}

			Console.WriteLine("Un medico esta atendiendo un infarto\n");
			protocolo.atenderInfarto(passerby);	
			
			if (kit == true)
				herramienta.guardar();
		}
		
		public void atenderDesmayo()
		{
			Console.WriteLine("Un medico esta atendiendo un desmayo");
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
