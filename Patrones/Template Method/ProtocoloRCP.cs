using System;

namespace Patrones
{
	public abstract class ProtocoloRCP
	{	
		public void atenderInfarto(IInfartable transeunte)
		{		
			this.eliminarObjetos();
			this.comprobarEstado();
			
			if (!transeunte.estaConciente())
			{
				Console.WriteLine("\nEl transeunte esta inconciente. Se lo llevará al hospital\n");
				this.llamarAmbulancia();
				this.descubrirTorax();
				this.acomodarCabeza();	
				do
				{
					this.hacerCompresion();
					this.hacerInsuflacion();					
				}
				while (!transeunte.estaRespirando());
				
				if (!transeunte.tieneRitmoCardiaco())
				{
					Console.WriteLine("\nEl transeunte no responde...\n");
					this.usarDesfibrilador();
				}
				else
				{
					Console.WriteLine("\nEl transeunte se ha salvado\n");
				}
			}
			else
			{
				Console.WriteLine("\nEl transeunte se encuentra a salvo..\n");
			}
		}
		
		public abstract void eliminarObjetos();
		public abstract void comprobarEstado();
		public abstract void llamarAmbulancia();
		public abstract void descubrirTorax();
		public abstract void acomodarCabeza();
		public abstract void hacerCompresion();
		public abstract void hacerInsuflacion();
		public abstract void usarDesfibrilador();	
	}
}