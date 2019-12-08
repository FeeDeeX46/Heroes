using System;
using System.Collections.Generic;

namespace Patrones
{
	class Program
	{
		public static void Main(string[] args)
		{
			//patronStrategy();
			patronObserver();
			//patronComposite();
			//patronCommand();
			//patronDecorator();
			//patronTemplateMethod();
			//patronAdapter();
			//patronFactoryMethod();
			//patronBuilder();
			//patronIterator();
			//patronChainOfResponsability();
			//patronAbstractFactory();
			//patronSingleton();
			//patronProxy();
			//patronState();
			Console.ReadKey(true);
		}
		
		public static void patronStrategy()
		{
			Plaza plaza = new Plaza("San Jorge", 9, 5, 8);	
			Casa casa = new Casa(3, 2, 9);
			Calle calle = new Calle(10, 10, 50);
			
			Bombero bombero = new Bombero();			
			
			bombero.setStrategy("Secuencial");
			bombero.apagarIncendio(casa, calle);
		}
		
		public static void patronObserver()
		{
			//Observador
			Bombero bombero1 = new Bombero(); 
			Bombero bombero2 = new Bombero(); 
			
			//Observable
			Casa casa1 = new Casa(2,2,9);
			Casa casa2 = new Casa(2,2,9);
			Casa casa3 = new Casa(2,2,9);
			Casa casa4 = new Casa(2,2,9);
			Casa casa5 = new Casa(2,2,9);			
			Plaza plaza1 = new Plaza("San Juan", 9, 9, 9); 
			
			Calle calle = new Calle(300, 20, 50);
			casa1.setCalle(calle);
			plaza1.setCalle(calle);
			
			casa1.addObserver(bombero1);
			plaza1.addObserver(bombero1);
			
			bombero1.setStrategy("Secuencial");
			plaza1.chispa();		
		}
		
		public static void patronComposite()
		{
			Electricista electricista = new Electricista();
			
			Calle calle1 = new Calle(300, 4, 50);
			Calle calle2 = new Calle(300, 4, 50);
			Calle calle3 = new Calle(300, 4, 50);
			Calle calle4 = new Calle(300, 4, 50);
			Calle calle5 = new Calle(300, 4, 50);
			Calle calle6 = new Calle(300, 4, 50);
			Calle calle7 = new Calle(300, 4, 50);
			Calle calle8 = new Calle(300, 4, 50);
			
			Plaza plaza1 = new Plaza("San Juan", 50, 5, 6);
			Plaza plaza2 = new Plaza("San Telmo", 100, 15, 12);
			
			CompositeNodo manzana1 = new CompositeNodo();
			CompositeNodo manzana2 = new CompositeNodo();
			CompositeNodo manzana3 = new CompositeNodo();
			CompositeNodo manzana4 = new CompositeNodo();
			CompositeNodo manzana5 = new CompositeNodo();
			CompositeNodo manzana6 = new CompositeNodo();
			CompositeNodo manzana7 = new CompositeNodo();
			CompositeNodo manzana8 = new CompositeNodo();
			CompositeNodo manzana9 = new CompositeNodo();	
			
			manzana1.AddHijo(calle1);
			manzana1.AddHijo(calle2);
			manzana1.AddHijo(calle3);
			manzana1.AddHijo(calle4);
			
			manzana2.AddHijo(calle1);
			manzana2.AddHijo(calle4);
			manzana2.AddHijo(calle3);
			manzana2.AddHijo(calle5);
			
			manzana3.AddHijo(calle1);
			manzana3.AddHijo(calle5);
			manzana3.AddHijo(calle3);
			manzana3.AddHijo(calle6);
			
			manzana4.AddHijo(calle3);
			manzana4.AddHijo(calle1);
			manzana4.AddHijo(calle7);
			manzana4.AddHijo(calle4);
			
			manzana5.AddHijo(calle3);
			manzana5.AddHijo(calle4);
			manzana5.AddHijo(calle7);
			manzana5.AddHijo(calle5);
			
			manzana6.AddHijo(calle3);
			manzana6.AddHijo(calle5);
			manzana6.AddHijo(calle7);
			manzana6.AddHijo(calle6);
			
			manzana7.AddHijo(calle7);
			manzana7.AddHijo(calle1);
			manzana7.AddHijo(calle8);
			manzana7.AddHijo(calle4);
			
			manzana8.AddHijo(calle7);
			manzana8.AddHijo(calle4);
			manzana8.AddHijo(calle8);
			manzana8.AddHijo(calle5);
			
			manzana9.AddHijo(calle7);
			manzana9.AddHijo(calle5);
			manzana9.AddHijo(calle8);
			manzana9.AddHijo(calle6);	
			
			CompositeNodo barrioA = new CompositeNodo();
			barrioA.AddHijo(manzana1);
			barrioA.AddHijo(manzana2);
			barrioA.AddHijo(manzana3);
			barrioA.AddHijo(manzana4);
			barrioA.AddHijo(manzana5);
			barrioA.AddHijo(manzana6);
			barrioA.AddHijo(manzana7);
			barrioA.AddHijo(manzana8);
			barrioA.AddHijo(manzana9);
			barrioA.AddHijo(plaza1);
			barrioA.AddHijo(plaza2);
			
			CompositeNodo ciudad = new CompositeNodo();
			ciudad.AddHijo(barrioA);

			Plaza plaza3 = new Plaza("San Jorge", 10, 15, 10);
			Plaza plaza4 = new Plaza("San Martin", 10, 10, 12);
			
			electricista.revisar(ciudad);
			electricista.cambiarLamparasQuemadas(ciudad);
		}

		public static void patronDecorator()
		{
			patronObserver();
		}
		
		public static void patronCommand()
		{
			var lugares = new List<IPatrullable>();
			var policia = new Policia();
			lugares = crearLugares(15);
			
			//For para setear una Orden al policia cada 5 lugares
			for (int i = 0; i < lugares.Count; i++)
			{
				if (i == 0)
				{
					policia.setOrden(new OrdenA());
				}
				
				else if (i == 5)
				{
					policia.setOrden(new OrdenB());
				}
				
				else if (i == 10)
				{
					policia.setOrden(new OrdenC());
				}
				
				policia.patrullarCalles(lugares[i]);
			}
		}
		
		public static void patronTemplateMethod()
		{
			var protocoloA = new ProtocoloA();
			var medico = new Medico(protocoloA);
			
			var transeunte = new Transeunte(50, 40, 70);
			
			medico.atenderInfarto(transeunte);
		}
		
		public static void patronAdapter()
		{
			ProtocoloA protocolo = new ProtocoloA();
			Medico medico = new Medico(protocolo);		
			
			Passerby passerby = new Passerby(5, 100, 8);
			AdapterInfartable adapter = new AdapterInfartable(passerby);
			medico.atenderInfarto(adapter);
		}	
		
		public static void patronFactoryMethod()
		{
			patronDecorator();
		}
		
		public static void patronBuilder()
		{
			var bombero = new Bombero();
			bombero.setStrategy("Secuencial");
			
			var A = new Casa(10, 5, 9);
			var calle = new Calle(9, 1, 5);
			
			A.setCalle(calle);
			
			A.addObserver(bombero);

			A.chispa();
		}
		
		public static void patronIterator()
		{	
			var calle = new Calle(100, 50, 50);
			
			var A = new Casa(100, 5, 9);
			A.setCalle(calle);
			
			var B = new Casa(100, 5, 9);
			B.setCalle(calle);
			
			var C = new Casa(100, 5, 9);
			C.setCalle(calle);
			
			var D = new Casa(100, 25, 4);
			D.setCalle(calle);
			
			var E = new Casa(100, 25, 4);
			E.setCalle(calle);
			
			var F = new Plaza("San Martin", 25, 9, 4);
			F.setCalle(calle);
			
			var G = new Plaza("Belgrano", 25, 9, 4);
			G.setCalle(calle);
			
			var H = new Plaza("Plazita", 25, 9, 4);
			H.setCalle(calle);
			
			var I = new Plaza("Villa 31", 25, 9, 4);
			A.setCalle(calle);
			
			var J = new Plaza("San Diego", 25, 9, 4);
			A.setCalle(calle);
			
			var denunciaTablero = new DenunciasPorTablero();
			A.addObserver(denunciaTablero);
			B.addObserver(denunciaTablero);
			C.addObserver(denunciaTablero);
			D.addObserver(denunciaTablero);
			E.addObserver(denunciaTablero);
			F.addObserver(denunciaTablero);
			
			MensajeWhatsApp listaWhatsApp = null;
			listaWhatsApp = new MensajeWhatsApp(new DenunciaDeIncendio(G), listaWhatsApp);
			listaWhatsApp = new MensajeWhatsApp(new DenunciaDeIncendio(H), listaWhatsApp);
			listaWhatsApp = new MensajeWhatsApp(new DenunciaDeIncendio(I), listaWhatsApp);
			var denunciaWhatsapp = new DenunciasPorWhatsapp(listaWhatsApp);
			
			var denunciaMostrador = new DenunciasPorMostrador(J);
			
			B.chispa();
			F.chispa();
			
			Bombero bombero = new Bombero();
			bombero.setStrategy("Secuencial");
			bombero.setHerramienta(new Manguera());
			
			var vehiculo = new Autobomba();
			vehiculo.setEstado(new Apagado(vehiculo));
			bombero.setVehiculo(vehiculo);
			
			BomberoSecretario bomberoSecreatario = new BomberoSecretario(bombero);
		
			bomberoSecreatario.atenderDenuncias(denunciaTablero);
			bomberoSecreatario.atenderDenuncias(denunciaWhatsapp);
		}
		
		public static void patronChainOfResponsability()
		{
			var calle = new Calle(100, 50, 50);
			
			var A = new Casa(100, 5, 9);
			A.setCalle(calle);
			
			var B = new Casa(100, 5, 9);
			B.setCalle(calle);
			
			var C = new Casa(100, 5, 9);
			C.setCalle(calle);
			
			var D = new Casa(100, 25, 4);
			D.setCalle(calle);
			
			var E = new Casa(100, 25, 4);
			E.setCalle(calle);
			
			var F = new Plaza("San Martin", 25, 9, 4);
			F.setCalle(calle);
			
			var G = new Plaza("Belgrano", 25, 9, 4);
			G.setCalle(calle);
			
			var H = new Plaza("Plazita", 25, 9, 4);
			H.setCalle(calle);
			
			var I = new Plaza("Villa 31", 25, 9, 4);
			A.setCalle(calle);
			
			var J = new Plaza("San Diego", 25, 9, 4);
			A.setCalle(calle);
			
			var denunciaTablero = new DenunciasPorTablero();
			A.addObserver(denunciaTablero);
			B.addObserver(denunciaTablero);
			C.addObserver(denunciaTablero);
			D.addObserver(denunciaTablero);
			E.addObserver(denunciaTablero);
			F.addObserver(denunciaTablero);
			
			B.chispa();
			F.chispa();
			
			Bombero bombero = new Bombero();
			BomberoProxy bomberoProxy = new BomberoProxy(bombero);

			Operador911 operador4 = new Operador911(bomberoProxy);
;
			operador4.atenderDenuncias(denunciaTablero);
		}

		public static void patronAbstractFactory()
		{
			//Instanciacion de la fabrica de bomberos
			
			FabricaBombero fabricaBombero = new FabricaBombero();
			ICuartel cuartel = crearHeroe(fabricaBombero);
			IResponsable responsable = cuartel.getPersonal();
			cuartel.agregarPersonal(responsable);
			cuartel.agregarHerramienta(responsable.getHerramienta());
			cuartel.agregarVehiculo(responsable.getVehiculo());
			
			//Instanciacion de la fabrica de electricistas
			
			FabricaElectricista fabricaElectricista = new FabricaElectricista();
			ICuartel cuartel2 = crearHeroe(fabricaElectricista);
			IResponsable responsable2 = cuartel.getPersonal();
			cuartel2.agregarPersonal(responsable2);
			cuartel2.agregarHerramienta(responsable2.getHerramienta());
			cuartel2.agregarVehiculo(responsable2.getVehiculo());
			
			//Intanciacion de la fabrica de policias
			
			FabricaPolicia fabricaPolicia = new FabricaPolicia();
			ICuartel cuartel3 = crearHeroe(fabricaPolicia);
			IResponsable responsable3 = cuartel3.getPersonal();
			cuartel3.agregarPersonal(responsable3);
			cuartel3.agregarHerramienta(responsable3.getHerramienta());
			cuartel3.agregarVehiculo(responsable3.getVehiculo());

			//Instanciacion de la fabrica de medicos
			
			FabricaMedico fabricaMedico = new FabricaMedico();
			ICuartel cuartel4 = crearHeroe(fabricaMedico);
			IResponsable responsable4 = cuartel.getPersonal();
			cuartel4.agregarPersonal(responsable4);
			cuartel4.agregarHerramienta(responsable4.getHerramienta());
			cuartel4.agregarVehiculo(responsable4.getVehiculo());			
		}
		
		public static void patronSingleton()
		{
			patronAbstractFactory();
			CentralElectrica ce = CentralElectrica.getInstance();
			IResponsable b1 = ce.getPersonal();
			IResponsable b2 = ce.getPersonal();
			IResponsable b3 = ce.getPersonal();
			IResponsable b4 = ce.getPersonal();	
		}
		
		public static void patronProxy()
		{
			patronChainOfResponsability();
			
		}
		
		public static void patronState()
		{
			patronChainOfResponsability();
		}
		
		public static List<IPatrullable> crearLugares(int cantidad)
		{
			var lista = new List<IPatrullable>();
			Random r = new Random();
			
			for (int i = 0; i < cantidad; i++)
			{
				int opcion = r.Next(3);
				IPatrullable lugar;
				
				switch (opcion)
				{
					case 0:
						lugar = new Esquina(r.Next(2));
						lista.Add(lugar);
						break;						
					case 1:
						lugar = new Casa(r.Next(5),4,10);
						lista.Add(lugar);
						break;
					case 2:
						lugar = new Plaza("Plaza " + r.Next(0,5), r.Next(50,100),r.Next(5,20),r.Next(6,20));
						lista.Add(lugar);
						break;
					default:
						lugar = new Esquina(r.Next(2));
						lista.Add(lugar);
						break;
				}
			}
			return lista;
		}
		
		public static ICuartel crearHeroe(IFabricaDeHeroes fabrica)
		{			
			ICuartel cuartel = fabrica.crearCuartel();
			IResponsable heroe = fabrica.crearHeroe();
			cuartel.agregarPersonal(heroe);
			
			IVehiculo vehiculo = fabrica.crearVehiculo();
			IHerramienta herramienta = fabrica.crearHerramienta();
			cuartel.agregarHerramienta(herramienta);
			cuartel.agregarVehiculo(vehiculo);

			return cuartel;
		}
	}
}