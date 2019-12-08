using System;

namespace Patrones
{
	public class FabricaElectricista: IFabricaDeHeroes
	{
		public IResponsable crearHeroe(ManejadorDeDenuncias manejador = null)
		{
			return new Electricista(manejador);
		}
		
		public IVehiculo crearVehiculo()
		{
			return new Camioneta();
		}
		
		public IHerramienta crearHerramienta()
		{
			return new Buscapolo();
		}
		
		public ICuartel crearCuartel()
		{
			return CentralElectrica.getInstance();
		}
	}
}
