using System;

namespace Patrones
{
	public abstract class EstadoDelMotor
	{
		private IVehiculo vehiculo;
		
		protected EstadoDelMotor(IVehiculo vehiculo)
		{
			this.vehiculo = vehiculo;
		}
		
		public IVehiculo getVehiculo()
		{
			return vehiculo;
		}
		
		public virtual void encender()
		{
			Console.WriteLine("[!] Sin efecto");
		}
		
		public virtual void apagar()
		{
			Console.WriteLine("[!] Sin efecto");
		}
		
		public virtual void acelerar()
		{
			Console.WriteLine("[!] Sin efecto");
		}
		
		public virtual void desacelerar()
		{
			Console.WriteLine("[!] Sin efecto");
		}
		
		public virtual void frenar()
		{
			Console.WriteLine("[!] Sin efecto");
		}
		
		public virtual void arreglar()
		{
			Console.WriteLine("[!] Sin efecto");
		}
	}
}
