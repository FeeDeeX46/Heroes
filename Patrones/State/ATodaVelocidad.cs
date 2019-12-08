using System;

namespace Patrones
{
	public class ATodaVelocidad: EstadoDelMotor
	{
		public ATodaVelocidad(IVehiculo vehiculo): base (vehiculo){}
		
		public override void acelerar()
		{
			Console.WriteLine("[!] La aceleración a toda velocidad sobreesforzó el motor y se rompió");
			this.getVehiculo().setEstado(new Roto(this.getVehiculo()));
		}
		
		public override void desacelerar()
		{
			Console.WriteLine("[!] Bajando la velocidad");
			this.getVehiculo().setEstado(new MediaMarcha(this.getVehiculo()));
		}
		
		public override void frenar()
		{
			Console.WriteLine("[!] Frenando...el motor está en Punto Muerto");
			this.getVehiculo().setEstado(new PuntoMuerto(this.getVehiculo()));
		}
		
		public override void apagar()
		{
			Console.WriteLine("[!] El motor está Apagado, sin embargo se ha Roto.");
			this.getVehiculo().setEstado(new Roto(this.getVehiculo()));
		}
	}
}
