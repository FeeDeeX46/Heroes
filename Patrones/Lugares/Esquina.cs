using System;

namespace Patrones
{

	public class Esquina: IIluminable, IPatrullable
	{
		private int semaforos;
		
		public Esquina(int semaforos)
		{
			this.semaforos = semaforos;
		}
		
		public int getSemaforos()
		{
			return semaforos;
		}
		
		public void setSemaforos(int semaforos)
		{
			this.semaforos = semaforos;
		}
		
		override public string ToString()
		{
			return "Esquina";
		}
		
		public void revisarYCambiarLamparasQuemadas()
		{
			Console.WriteLine("Un electricista esta revisando lamparas quemadas");
		}

		public bool hayAlgoFueraDeLoNormal()
		{
			const int probabilidad = 100;
			Random random = new Random();
			return (random.Next(1) < probabilidad);
		}	
	}
}
