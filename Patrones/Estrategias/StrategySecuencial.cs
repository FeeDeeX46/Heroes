using System;
using System.Collections.Generic;

namespace Patrones
{
	public class StrategySecuencial: IStrategy
	{	
		public void apagarIncendio(ILugar lugar, Calle calle)
		{
			ISector [][] sectores = lugar.getSectores();
			int longitud = sectores.GetLength(0);
			int caudal = calle.getCaudal();
			
			Console.WriteLine("Un bombero esta apagando el incendio con el metodo Secuencial en la " + lugar.ToString() + "\n");
			Console.WriteLine("Matriz de sectores de la " + lugar.ToString() + " (" + longitud + "x" + longitud + "):");
			
			for (int i = 0; i < longitud; i++)
			{
				for (int j = 0; j < longitud; j++)
				{
					var fuegoRestante = new List<double>(); //Lista que va a ir añadiendo valores del caudal a medida que se va apagando el fuego.
					
					fuegoRestante.Add(sectores[i][j].getAfeccion());
					
					while (!sectores[i][j].estaApagado())
					{
						sectores[i][j].mojar(caudal);
						
                	    if (sectores[i][j].estaApagado())
                   		{
                   	 		fuegoRestante.Add(0); //Se añade 0 en caso de que el caudal sea menor o igual a 0.
                    	}
                    	else
                    	{
                    		fuegoRestante.Add(sectores[i][j].getAfeccion()); 
                    	}						
					}
					
					Console.WriteLine("(" + i + "," + j + ") - " + "("+sectores[i][j].ToString() + ") -> " + string.Join(" -> ", fuegoRestante));
				}
			}
			Console.WriteLine("\nEl fuego de " + lugar.ToString() + " fue extinguido en su totalidad!!");
		}		
	}
}
