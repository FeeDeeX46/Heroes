using System;

namespace Patrones
{
	public class Camioneta: IVehiculo
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
			Console.WriteLine("[!] Encendiendo sinera de la camioneta");
		}
		
		public void conducir()
		{
			Console.WriteLine("[!] Conduciendo camioneta");
		}
	}
}
