using System;

namespace Patrones
{
	public class FabricaBombero: IFabricaDeHeroes
	{
		public IResponsable crearHeroe(ManejadorDeDenuncias manejador = null)
		{
			return new Bombero(manejador);
		}
		
		public IVehiculo crearVehiculo()
		{
			return new Autobomba();
		}
		
		public IHerramienta crearHerramienta()
		{
			return new Manguera();
		}
		
		public ICuartel crearCuartel()
		{
			return CuartelDeBomberos.getInstance();
		}
	}
}
