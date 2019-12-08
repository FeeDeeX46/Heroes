using System;

namespace Patrones
{
	public interface IVehiculo
	{
		void encenderSirena();
		void conducir();
		void setEstado(EstadoDelMotor estado);
		EstadoDelMotor getEstado();
	}
}
