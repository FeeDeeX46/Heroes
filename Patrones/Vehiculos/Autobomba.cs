using System;

namespace Patrones
{
	public class Autobomba: IVehiculo
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
			Console.WriteLine("[!] Encendiendo la Sirena de incendio");
		}
		
		public void conducir()
		{
			Console.WriteLine("[!] Un bombero está yendo en el Autobomba");
			Random r = new Random();
			
			for (int i = 0; i < 5; i++)
			{
				var valor = r.Next(11);
				
				if (valor <= 1)
				{
					estado.apagar();
				}
				else if (valor > 1)
				{
					estado.encender();
				}

				if (valor >= 4)
				{
				     estado.acelerar();
				}
				
				else
				{
					estado.desacelerar();
				}
				
				if (valor >= 9)
				{
					estado.frenar();
				}
				
				if (valor > 1 && this.getEstado() is Roto)
				{
					estado.arreglar();
				}
			}
		}
	}
}
