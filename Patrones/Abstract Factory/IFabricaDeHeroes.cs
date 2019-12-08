using System;

namespace Patrones
{
	public interface IFabricaDeHeroes
	{
		IResponsable crearHeroe(ManejadorDeDenuncias manejador = null);
		IVehiculo crearVehiculo();
		IHerramienta crearHerramienta();
		ICuartel crearCuartel();
	}
}
