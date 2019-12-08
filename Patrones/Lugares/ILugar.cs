using System;

namespace Patrones
{
	
	public interface ILugar
	{		
		ISector[][] getSectores();
		void chispa();
		void addObserver(IObserver observador);
		void removeObserver(IObserver observador);		
		Calle getCalle();
	}
}
