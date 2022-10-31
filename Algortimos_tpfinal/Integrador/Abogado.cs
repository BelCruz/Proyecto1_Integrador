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
	/// <summary>
	/// Description of Abogado.
	/// </summary>
	public class Abogado
	{
		private string apynom;
		private string   dni;
		private string especialidad;
		private int cantidadExpedientes;// maximo 6
		
		
		// CONSTRUCTOR
		public Abogado( string apynom,string dni,string especialidad)
		{
			this.apynom=apynom;
			this.dni=dni;
			this.especialidad=especialidad;
			this.cantidadExpedientes=0;
			
		}
		//PROPIETIES
		
		public string APYNOM
		{   set {apynom=value;}
			get{return apynom;}
		}
		public string DNI
		{   set {dni=value;}
			get{return dni;}
		}
		public string ESPECIALIDAD
		{   set {especialidad=value;}
			get{return especialidad;}
			
		}
		public string CANTIDADEXPEDIENTES
		{
			get{return especialidad;}
			
		}
		
//		public void imprimir()
//		{
//			Console.WriteLine("nombre "+apynom,"DNI" +dni,"especialidad"+especialidad);
//		}
//		
		
		public void SumarUnExpediente()
		{
			this.cantidadExpedientes++;
		}
		
		public void RestarUnExpediente()
		{
			this.cantidadExpedientes--;
		}
		
		public override string ToString()
		{
			return string.Format("Dr/a. {0}, Especialidad: {1}", apynom, especialidad);
		}

		
	}
}
