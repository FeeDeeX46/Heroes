using System;

namespace Patrones
{

	public class Calle: IIluminable, IPatrullable
	{
		private int longitud;
		private int farolas;
		private int caudal;

		public Calle(int longitud, int farolas, int caudal)
		{
			this.longitud = longitud;
			this.farolas = farolas;
			this.caudal = caudal;
		}
		
		public int getLongitud()
		{
			return longitud;
		}
		
		public void setLongitud(int longitud)
		{
			this.longitud = longitud;
		}
		
		public int getFarolas()
		{
			return farolas;
		}
		
		public void setFarolas(int farolas)
		{
			this.farolas = farolas;
		}
		
		public int getCaudal()
		{
			return caudal;
		}
		
		public void setCaudal(int caudal)
		{
			this.caudal = caudal;
			Console.WriteLine("<!> El caudal de agua de la Calle fue seteado a: " + caudal + "\n");
		}
		
		public void revisarYCambiarLamparasQuemadas()
		{
			Console.WriteLine("Un electricista esta revisando lamparas quemadas");
		}

		public bool hayAlgoFueraDeLoNormal()
		{
			const int probabilidad = 50;
			Random random = new Random();
			return (random.Next(100) < probabilidad);
		}
	}
}
