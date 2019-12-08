using System;

namespace Patrones
{
	public class MediaMarcha: EstadoDelMotor
	{
		public MediaMarcha(IVehiculo vehiculo): base (vehiculo){}
		
		public override void acelerar()
		{
			Console.WriteLine("[!] Subiendo la velocidad del motor a Toda Velocidad.");
			this.getVehiculo().setEstado(new ATodaVelocidad(this.getVehiculo()));
		}
		
		public override void desacelerar()
		{
			Console.WriteLine("[!] Bajando la velocidad a Marcha Lenta.");
			this.getVehiculo().setEstado(new MarchaLenta(this.getVehiculo()));
		}
		
		public override void frenar()
		{
			Console.WriteLine("[!] Frenando... el motor está en Punto Muerto.");
			this.getVehiculo().setEstado(new PuntoMuerto(this.getVehiculo()));
		}
		
		public override void apagar()
		{
			Console.WriteLine("[!] El motor está Apagado, sin embargo se ha Roto.");
			this.getVehiculo().setEstado(new Roto(this.getVehiculo()));
		}
	}
}
