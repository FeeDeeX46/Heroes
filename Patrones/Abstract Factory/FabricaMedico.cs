using System;

namespace Patrones
{
	public class FabricaMedico: IFabricaDeHeroes
	{
		public IResponsable crearHeroe(ManejadorDeDenuncias manejador = null)
		{
			return new Medico(manejador);
		}
		
		public IVehiculo crearVehiculo()
		{
			return new Ambulancia();
		}
		
		public IHerramienta crearHerramienta()
		{
			return new Desfibrilador();
		}
		
		public ICuartel crearCuartel()
		{
			return Hospital.getInstance();
		}
		
		
	}
}
