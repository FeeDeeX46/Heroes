using System;
using System.Collections.Generic;

namespace Patrones
{

	public class CuartelDeBomberos: ICuartel
	{		
		private readonly List<IVehiculo> vehiculos;
		private readonly List<IHerramienta> herramientas;
		private readonly List<IResponsable> responsables;
		
		private IResponsable responsable;
		private IVehiculo vehiculo;
		private IHerramienta herramienta;
		
		private static CuartelDeBomberos cuartelDeBomberos = null;
		
		private CuartelDeBomberos()
		{
			vehiculos = new List<IVehiculo>();
			herramientas = new List<IHerramienta>();
			responsables = new List<IResponsable>();
		}
		
		public static CuartelDeBomberos getInstance()
		{
			if (cuartelDeBomberos == null)
			{
				cuartelDeBomberos = new CuartelDeBomberos();
			}
			
			return cuartelDeBomberos;
		}
		
		public void agregarVehiculo(IVehiculo vehiculo)
		{
			this.vehiculo = vehiculo;
			vehiculos.Add(vehiculo);
		}
		
		public void agregarPersonal(IResponsable responsable)
		{
			this.responsable = responsable;
			responsables.Add(responsable);
		}
		
		public void agregarHerramienta(IHerramienta herramienta)
		{
			this.herramienta = herramienta;
			herramientas.Add(herramienta);
		}
		
		public IResponsable getPersonal()
		{
			IResponsable responsableListo = responsables[0];
			IVehiculo vehiculoListo = vehiculos[0];
			IHerramienta herramientaLista = herramientas[0];
			
			responsableListo.setHerramienta(herramientaLista);
			responsableListo.setVehiculo(vehiculoListo);
			
			return responsableListo;
		}		
	}
}
