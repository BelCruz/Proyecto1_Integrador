/*
 * Creado por SharpDevelop.
 * Usuario: maria
 * Fecha: 31/10/2022
 * Hora: 17:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Integrador
{
	/// <summary>
	/// Description of Expediente.
	/// </summary>
	public class Expediente
	{
		private int  numero;
		private string  tipoTramite;
		private string estado;
		private  DateTime fechaPresentacion;
		private Abogado abogado;
		
		public Expediente(int numero, string tipoTramite , string estado, DateTime fechaPresentacion)
		{
			this.numero=numero;
			this.tipoTramite=tipoTramite;
			this.estado =estado;
			this.fechaPresentacion=fechaPresentacion;	
		}
		
		public int NUMERO
		{
			set {numero=value;}
			get{return numero;}
		}
		public string TIPOTRAMITE
		{
			set{tipoTramite=value;}
			get{return tipoTramite;}
		}
		public string ESTADO
		{
			set {estado=value;}
			get{return estado;}
		}
		public Abogado ABOGADOACARGO
		{
			set {abogado =value;}
			get{return abogado;}
		}
		public DateTime FECHAPRESENTACION
		{
			set {fechaPresentacion=value;}
			get{return fechaPresentacion;}
			
		}
		
		public void AsignarAbogado(Abogado abogado){
		this.abogado =abogado;
		}
		
	}
}
