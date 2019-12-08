using System;

namespace Patrones
{
	public interface IResponsable
	{
		void setHerramienta(IHerramienta herramienta);
		IHerramienta getHerramienta();
		void setVehiculo(IVehiculo vehiculo);
		IVehiculo getVehiculo();
	}
}
