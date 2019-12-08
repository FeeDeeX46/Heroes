using System;

namespace Patrones
{

	public class Passerby
	{
		static Random random = new Random();
		
		private int probConscius, probBrathing, probHeartRate;
		
		public Passerby(int pc, int pb, int phr)
		{
			probConscius = pc; 
			probBrathing = pb;
			probHeartRate = phr;
		}
		
		public bool estaConciente()
		{
			return random.Next(100) < probConscius;
		}
		
		public bool estaRespirando()
		{
			return random.Next(100) < probBrathing;
		}
		
		public bool tieneRitmoCardiaco()
		{
			return random.Next(100) < probHeartRate;
		}
	}
}
