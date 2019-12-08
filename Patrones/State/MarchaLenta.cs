using System;

namespace Patrones
{
	public class MarchaLenta: EstadoDelMotor
	{
		public MarchaLenta(IVehiculo vehiculo): base (vehiculo){}
		
		public override void acelerar()
		{
			Console.WriteLine("[!] Subiendo la velocidad del motor a Media Marcha.");
			this.getVehiculo().setEstado(new MediaMarcha(this.getVehiculo()));
		}
		
		public override void desacelerar()
		{
			Console.WriteLine("[!] Bajando la velocidad, el motor está en Punto Muerto.");
			this.getVehiculo().setEstado(new PuntoMuerto(this.getVehiculo()));
		}
		
		public override void frenar()
		{
			Console.WriteLine("[!] Poniendo el motor en Punto Muerto.");
			this.getVehiculo().setEstado(new PuntoMuerto(this.getVehiculo()));
		}
		
		public override void apagar()
		{
			Console.WriteLine("[!] El motor está Apagado, sin embargo se ha Roto.");
			this.getVehiculo().setEstado(new Roto(this.getVehiculo()));
		}
	}
}
