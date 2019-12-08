using System;

namespace Patrones
{
	public class FabricaPolicia: IFabricaDeHeroes
	{
		public IResponsable crearHeroe(ManejadorDeDenuncias manejador = null)
		{
			return new Policia(manejador);
		}
		
		public IVehiculo crearVehiculo()
		{
			return new Patrullero();
		}
		
		public IHerramienta crearHerramienta()
		{
			return new Pistola();
		}
		
		public ICuartel crearCuartel()
		{
			return Comisaria.getInstance();
		}
	}
}
