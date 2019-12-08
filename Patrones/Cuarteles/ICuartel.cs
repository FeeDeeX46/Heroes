using System;

namespace Patrones
{
	public interface ICuartel
	{
		void agregarVehiculo(IVehiculo vehiculo);
		void agregarPersonal(IResponsable responsable);
		void agregarHerramienta(IHerramienta herramienta);
		IResponsable getPersonal();
		
	}
}
