using System;

namespace Patrones
{

	public class ProtocoloB: ProtocoloRCP
	{
		override public void eliminarObjetos()
		{
			Console.WriteLine("Protocolo B: Elimando objetos");
		}
		
		override public void comprobarEstado()
		{
			Console.WriteLine("Protocolo B: Comprobando estado");
		}
		
		override public void llamarAmbulancia()
		{
			Console.WriteLine("Protocolo B: Llamando ambulancia");
		}
		
		override public void descubrirTorax()
		{
			Console.WriteLine("Protocolo B: Descubriendo torax");
		}
		
		override public void acomodarCabeza()
		{
			Console.WriteLine("Protocolo B: Acomodando cabeza");
		}
		
		override public void hacerCompresion()
		{
			Console.WriteLine("Protocolo B: Haciendo compresion");
		}
		
		override public void hacerInsuflacion()
		{
			Console.WriteLine("Protocolo B: Haciendo insuflacion");
		}
		
		override public void usarDesfibrilador()
		{
			Console.WriteLine("Protocolo B: Usando desfibrilador");
		}
	}
}
