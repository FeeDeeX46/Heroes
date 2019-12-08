using System;

namespace Patrones
{
	public interface ISector
	{
		void mojar(double agua);
		bool estaApagado();
		double getAfeccion();
	}
}
