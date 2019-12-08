using System;

namespace Patrones
{
	public class Apagado: EstadoDelMotor
	{
		public Apagado(IVehiculo vehiculo): base (vehiculo){}
		
		public override void apagar()
		{
			Console.WriteLine("Motor encendido");
			this.getVehiculo().setEstado(new PuntoMuerto(this.getVehiculo()));
		}
	}
}

