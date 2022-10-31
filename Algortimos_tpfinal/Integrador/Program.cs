/*
 * Creado por SharpDevelop.
 * Usuario: maria
 * Fecha: 31/10/2022
 * Hora: 17:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Estudio estudio= new Estudio();
			cargarAbogados(estudio);
			
			string opcion;
			do{
				Console.Clear();
				Console.WriteLine("************************ MENU ********************");
				Console.WriteLine(" 1 - AGREGAR ABOGADO" +
				                  "\n 2 - ELIMINAR ABOGADO" +
				                  "\n 3 - LISTADO DE ABOGADO" +
				                  "\n 4 - LISTADO DE EXPEDIENTE" +
				                  "\n 5 - AGREGAR NUEVO EXPEDIENTE" +
				                  "\n 6 - MODIFICAR ESTADO DE EXPEDIENTE" +
				                  "\n 7 - ELIMINAR EXPEDIENTE" +
				                  "\n 8 - LISTADO DE AUDIENCIA EN UN MES DETERMINADO" +
				                  "\n 9 - SALIR");
				
				Console.Write("ELIJA UNA OPCION: ");
				opcion = Console.ReadLine();
				
				switch (opcion) {
					case "1":
						Console.WriteLine("Agregar nuevo abogado");
						//controlar que puedo agregar abogado
						if (estudio.CANTABOGADOS < 6) {
							//si puedo
						agregarAbogado(estudio);
						Console.WriteLine("Se agrego abogado");
						}
						else {
							Console.WriteLine("No se puede agregar abogado.");
						}
						break;
					case "2":
						Console.WriteLine("caso Eliminar abogado");
						break;
					case "3":
						Console.WriteLine("Listado de abogados");
						estudio.listarAbogados();
						break;
					case "4":
						Console.WriteLine("caso 4");
						break;
					case "5":
						Console.WriteLine("caso 5");
						break;
					case "6":
						Console.WriteLine("caso 6");
						break;
					case "7":
						Console.WriteLine("caso 7");
						break;
					case "8":
						Console.WriteLine("caso 8");
						break;
					case "9":
						Console.WriteLine("salir");
						break;
						default :
							Console.WriteLine("default");
						break;
				}
				Console.WriteLine("Presione una tecla para continuar");
				Console.ReadKey();
			}while(opcion != "9");
			
			
			
			
		}
		public static void agregarAbogado(Estudio estudio){
			Console.Write("Ingrese apellido y nombre: ");
			string apynom = Console.ReadLine();
			Console.Write("Ingrese DNI: ");
			string dni = Console.ReadLine();
			Console.Write("Ingrese especialidad: ");
			string espec = Console.ReadLine();
			Abogado abogadoNuevo = new Abogado(apynom, dni, espec);
			
			estudio.agregarAbogadoALista(abogadoNuevo);
		}
		
		public static void cargarAbogados(Estudio estudio){
			
			estudio.agregarAbogadoALista(new Abogado("Orellana Maxi", "34516", "Ingeniero"));
			estudio.agregarAbogadoALista(new Abogado("Cruz Belen", "33199", "Arquitecta"));
			estudio.agregarAbogadoALista(new Abogado("Gramajo Sandra", "35136", "Medica"));
			
		}
	}
}