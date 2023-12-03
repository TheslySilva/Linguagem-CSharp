using System;
using System.Linq;
using ConsoleTables;

namespace LojaDeVeiculos;

public class Veiculos {
   
   private int id;
   private string modelo;
   private double preco;
   private int parcelas;
   
   //Construtor para Compra Parcelada
   public Veiculos(int id,string modelo,double preco,int parcelas){
    this.id = id;
    this.modelo = modelo;
    this.preco = preco;
	this.parcelas = parcelas;
	
   }
   //Construtor para Compra a vista
   public Veiculos(int id,string modelo,double preco){
    
	this.id = id;
    this.modelo = modelo;
    this.preco = preco;
	this.parcelas = 1;
	
   }
   
   //Gerar Valor Final
   public double GerarValor(){
    
    double resultado = 0;
	
	// A vista
    if(parcelas == 1){ 
	    
		resultado = preco - ((preco * 20)/100.0);
		
	// Parcelado	
	}else{ 
	    switch(parcelas){
		    
		    case 6 : 
			resultado = preco + ((preco * 3)/100.0);
			break;
			
			case 12 : 
			resultado = preco + ((preco * 6)/100.0);
			break;
			
			case 18 : 
			resultado = preco + ((preco * 9)/100.0);
			break;
			
			case 24 : 
			resultado = preco + ((preco * 12)/100.0);
			break;
			
			case 30 : 
			resultado = preco + ((preco * 15)/100.0);
			break;
			
			case 36 : 
			resultado = preco + ((preco * 18)/100.0);
			break;
			
			case 42 : 
			resultado = preco + ((preco * 21)/100.0);
			break;
			
			case 48 : 
			resultado = preco + ((preco * 24)/100.0);
			break;
			
			case 54 : 
			resultado = preco + ((preco * 27)/100.0);
			break;
			
			case 60 : 
			resultado = preco + ((preco * 30)/100.0);
			break;
		}
	}
	return resultado;
   }
   
   public String Tabela(){
    
	var table = new ConsoleTable("Modelo","Parcelas","ValorFinal");
	
	double valor = GerarValor();
	string formatar = valor.ToString("C");
	
	table.AddRow(modelo,parcelas,formatar);
	
	return table.ToString();
   }
}