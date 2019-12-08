using System;
using System.Collections.Generic;

namespace Patrones
{
	public class Casa: ILugar, IPatrullable
	{
		private int numero;
		private int habitantes;
		private int superficie;
		private Calle calle;
		protected List<IObserver> observadores = new List<IObserver>();
		private BuilderDecorator builder;
		
		public Casa(int numero, int habitantes, int superficie)
		{
			this.numero = numero;
			this.habitantes = habitantes;
			this.superficie = superficie;
		}		
		
		public int getNumero()
		{
			return numero;
		}
		
		public void setNumero(int numero)
		{
			this.numero = numero;
		}
		
		public int getHabitantes()
		{
			return habitantes;
		}
		
		public void setHabitantes(int habitantes)
		{
			this.habitantes = habitantes;
		}
		
		public double getSuperficie()
		{
			return superficie;
		}
		
		public void setSuperficie(int superficie)
		{
			this.superficie = superficie;
			Console.WriteLine("<!> La superficie de la Casa fue seteada a: " + superficie);
		}
		
		public void setCalle(Calle calle)
		{
			this.calle = calle;
		}
		
		public Calle getCalle()
		{
			return calle;
		}		
		
		//Metodo que obtiene el tamaño de la matriz NxN
		public int getN()
		{
			int valor;
			double raiz = Math.Sqrt(superficie);
			valor = Convert.ToInt32(raiz);
			return valor;
		}
		
		public void setBuilder(BuilderDecorator builder)
		{
			this.builder = builder;
		}
		
		public BuilderDecorator getBuilder()
		{
			return builder;
		}
		
		//Metodos implementados de ILugar (Observable)
		public void addObserver(IObserver observer)
		{
			observadores.Add(observer);
		}
		
		public void removeObserver(IObserver observer)
		{
			observadores.Remove(observer);
		}
		
		
		public void chispa()
		{	
			foreach (IObserver observer in observadores)
			{
				Console.WriteLine("[ALERTA] Hay un incendio en una " + this.ToString() + "!");
				observer.alarmaDeIncendio(this);
			}
		}		
	
		public ISector decorarSector(ISector sector, int caudalLluvia, int temperatura, int velocidadViento)
		{	
			Random random = new Random();
			const double probabilidad_de_decorar = 0.2;
			
 			if(random.NextDouble() < probabilidad_de_decorar)
 				sector = new PastoSeco(sector);
 			
 			if(random.NextDouble() < probabilidad_de_decorar)
 				sector = new arbolesGrandes(sector);
 			
 			if(random.NextDouble() < probabilidad_de_decorar)
 				sector = new genteAsustada(sector, random.Next(5));
 			
 			if(temperatura > 30)
 				sector = new muchoCalor(sector, random.Next(40));
 			
 			if(velocidadViento > 80)
 				sector = new muchoViento(sector,random.Next(120));
 			
 			if(caudalLluvia > 50)
 				sector =new diaLluvioso(sector, 60);
 			
 			return sector;
		}
		
		public ISector crearSector(int caudalLluvia, int temperatura, int velocidadViento)
		{
			Random random = new Random();
			int caudal = random.Next(101);
			ISector sector = new Sector(caudal);
			return decorarSector(sector, caudalLluvia, temperatura, velocidadViento);
		}	

		public ISector[][] getSectores()		
		{
			Random r = new Random();
			
			//For que crea la matriz de tamaño NxN
			ISector[][] sectores = new ISector[getN()][];
			
			for(int i = 0; i <sectores.Length; i++)
			{
				sectores[i] = new ISector[getN()];
			}
			
			int longitud = sectores.GetLength(0);
			
			//For que crea objetos para cada sector en la matriz
			for(int i = 0; i < longitud; i++)
			{
				for (int j = 0; j < longitud; j++)
				{
					int valor = r.Next(101);
					sectores[i][j] = crearSector(valor, valor, valor);
				}
			}
			return sectores;
		}
				
		public bool hayAlgoFueraDeLoNormal()
		{
			const int probabilidad = 50;
			Random random = new Random();
			return (random.Next(100) < probabilidad);
		}
		
		public override string ToString()
		{
			return "Casa";
		}		
	}
}
