﻿using System;
using System.Collections.Generic;

namespace Patrones
{

	public class Comisaria: ICuartel
	{
		private readonly List<IVehiculo> vehiculos = new List<IVehiculo>();
		private readonly List<IHerramienta> herramientas = new List<IHerramienta>();
		private readonly List<IResponsable> responsables = new List<IResponsable>();
		
		private IResponsable responsable;
		private IVehiculo vehiculo;
		private IHerramienta herramienta;

		private static Comisaria comisaria = null;
		
		private Comisaria()
		{
			vehiculos = new List<IVehiculo>();
			herramientas = new List<IHerramienta>();
			responsables = new List<IResponsable>();
		}
		
		public static Comisaria getInstance()
		{
			if (comisaria == null)
			{
				comisaria = new Comisaria();
			}
			
			return comisaria;
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
