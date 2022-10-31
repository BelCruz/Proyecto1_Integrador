/*
 * Creado por SharpDevelop.
 * Usuario: maria
 * Fecha: 31/10/2022
 * Hora: 17:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Integrador
{
	/// <summary>
	/// Description of Estudio.
	/// </summary>
	public class Estudio
	{ 	
		private ArrayList  listaAbogados;
		private ArrayList  listaExpedientes;
		private int cantAbogados;
		private int cantExpedientes;
		
		
		public Estudio()
		{
			listaAbogados=new ArrayList();
			listaExpedientes= new ArrayList();
			this.cantAbogados= 0;
			this.cantExpedientes = 0;
			
		}
		
		public int CANTABOGADOS{
			get{ return this.cantAbogados; }
		}
		
		public int CANTEXPEDIENTES{
			get{ return this.cantExpedientes; }
		}
		
		public void agregarAbogadoALista(Abogado abogado){
			this.listaAbogados.Add(abogado);
			cantAbogados ++;
		}
		
		public void eliminarAbogadoALista(Abogado abogado){
			this.listaAbogados.Remove(abogado);
			cantAbogados --;
		}
		
		public void listarAbogados(){
			foreach (Abogado abogado in this.listaAbogados) {
				Console.WriteLine(abogado);
			}
		}
		
	}
}
