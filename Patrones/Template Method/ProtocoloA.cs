using System;

namespace Patrones
{

	public class ProtocoloA: ProtocoloRCP
	{
		override public void eliminarObjetos()
		{
			Console.WriteLine("Elimando objetos");
		}
		
		override public void comprobarEstado()
		{
			Console.WriteLine("Protocolo A: Comprobando estado");
		}
		
		override public void llamarAmbulancia()
		{
			Console.WriteLine("Protocolo A: Llamando ambulancia");
		}
		
		override public void descubrirTorax()
		{
			Console.WriteLine("Protocolo A: Descubriendo torax");
		}
		
		override public void acomodarCabeza()
		{
			Console.WriteLine("Protocolo A: Acomodando cabeza");
		}
		
		override public void hacerCompresion()
		{
			Console.WriteLine("Protocolo A: Haciendo compresion");
		}
		
		override public void hacerInsuflacion()
		{
			Console.WriteLine("Protocolo A: Haciendo insuflacion");
		}
		
		override public void usarDesfibrilador()
		{
			Console.WriteLine("Protocolo A: Usando desfibrilador");
		}
	}
}
