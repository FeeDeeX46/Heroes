using System;

namespace Patrones
{
	public class PuntoMuerto: EstadoDelMotor
	{
		public PuntoMuerto(IVehiculo vehiculo) : base (vehiculo){}
		
		public override void acelerar()
		{
			Console.WriteLine("[!] Subiendo la velocidad del motor a Marcha Lenta");
			this.getVehiculo().setEstado(new MarchaLenta(this.getVehiculo()));
		}
		
		public override void apagar()
		{
			Console.WriteLine("[!] Apagando el motor.");
			this.getVehiculo().setEstado(new Apagado(this.getVehiculo()));
		}
	}
}
