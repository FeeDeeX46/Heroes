using System;

namespace Patrones
{
	public class Roto: EstadoDelMotor
	{	
		public Roto(IVehiculo vehiculo): base (vehiculo){}
		
		public override void arreglar()
		{
			Console.WriteLine("[!] Arreglando el vehiculo");
			this.getVehiculo().setEstado(new Apagado(this.getVehiculo()));
		}		
	}
}
