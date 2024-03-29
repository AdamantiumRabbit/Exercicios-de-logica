using System;
using System.Collections.Generic;
				
public class Oferta
{
	int  quantidade,posicao;
	double valor;

	public Oferta(int posicao, int quantidade, double valor)
	{	
		if(valor > 0 && quantidade > 0 && posicao > 0){
			this.posicao = posicao;
			this.valor = valor;
			this.quantidade = quantidade;
		}
		else{
			Console.WriteLine("Os valores devem ser positivos e diferentes de zero\nAperte enter para prosseguir");
			Console.ReadLine();
		}
		
	}	
	
	public void atualizar(int qtd,double val){
		if(val > 0 && qtd > 0){
			this.quantidade = qtd;
			this.valor = val;
			Console.WriteLine("Informações atualizadas\nAperte enter para prosseguir");
			Console.ReadLine();
		}
		else{
			Console.WriteLine("Os valores devem ser positivos e diferentes de zero\nAperte enter para prosseguir");
			Console.ReadLine();
		}
	}

	
	public static void Main()
	{ 
		Console.WriteLine("Bem vindo a nossa lista de ofertas");
 		
		int i=0,posi=0,acao=0,qtd=0;
		double val;
	  	List<Oferta> listaOferta = new List<Oferta>();
    	
		do{
			
			Console.WriteLine("----------------------------\n" +
							  "POSICAO----VALOR----QUANTIDADE");
			
			for(int j=0;j <= listaOferta.Count-1;j++){
				    Console.WriteLine("{0}   ---- {1} ---- {2}",listaOferta[j].posicao,listaOferta[j].valor,listaOferta[j].quantidade);
					}
			
			Console.WriteLine("----------------------------\n\n");
			
			Console.WriteLine("Gostaria de fazer quantas notificações?");
			int.TryParse(Console.ReadLine(),out i);
			
			for(; i!=0 ;i--){
				Console.WriteLine("Digite a posiçao da oferta {0}º",i);
				int.TryParse(Console.ReadLine(), out posi);

				Console.WriteLine("Digite a quantidade da oferta");
				int.TryParse(Console.ReadLine(), out qtd);

				Console.WriteLine("Digite o valor da oferta");
				double.TryParse(Console.ReadLine(),out val);
				
				Console.WriteLine("Digite a ação que gostaria de fazer\n" +
							  "0- para inserir\n1- para atualizar\n2- para deletar");
				if(!int.TryParse(Console.ReadLine(), out acao)){
					Console.WriteLine("Ocorreu um problema\nAperte enter para prosseguir");
					Console.ReadLine();
					break;
				}
				

				///----------ACAO
				switch(acao){
					//CRIA
					case 0:
						bool verificador= true;
						if(listaOferta.Count >0)
							//Preocura a posicao
							for(int j =0 ;j <= listaOferta.Count-1;j++){
								if(posi == listaOferta[j].posicao){
									verificador = false;
									Console.WriteLine("Essa posição ja esta ocupada tente outra\nAperte enter para prossguir");
									Console.ReadLine();
								}
							}	
						
						if(verificador){
							listaOferta.Add(new Oferta(posi,qtd,val));					
						}
					break;
					//ATUALIZA
					case 1:
						for(int j =0 ;j <= listaOferta.Count-1;j++){
							if(listaOferta[j].posicao == posi){
								listaOferta[j].atualizar(qtd,val);
							}
						}
					break;
					//DELETA
					case 2:
						for(int j =0 ;j <= listaOferta.Count-1;j++){
							if(listaOferta[j].posicao == posi){
								listaOferta.Remove(listaOferta[j]);
							}
						}
					break;
					default:
						Console.WriteLine("Ação não reconhecida");
					break;
				}
				Console.Clear();
			}//fim for
			Console.WriteLine("Se quiser finalizar o programa aperte N/n\nSe quiser continuar aperte outra letra");
		}while(Console.ReadLine().ToLower() != "n");	
	}
} 