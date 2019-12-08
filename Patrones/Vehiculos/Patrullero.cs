using System;

namespace Patrones
{
	public class Patrullero: IVehiculo
	{
		private EstadoDelMotor estado;
		
		public void setEstado(EstadoDelMotor estado)
		{
			this.estado = estado;
		}
		
		public EstadoDelMotor getEstado()
		{
			return estado;
		}
		
		public void encenderSirena()
		{
			Console.WriteLine("[!] Encendiendo sinera del patrullero");
		}
		
		public void conducir()
		{
			Console.WriteLine("[!] Conduciendo patrullero");
		}
	}
}
