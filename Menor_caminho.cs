using System;
public class Principal 
{
	public static void Main(){
		int[,] array1 = new int[28,56];
		int[,] array2 = new int[74,103];
		int index1,index2,index3,index4;
		Console.WriteLine("Arrays testados Array1[28][56] e Array1[74][103]");
		
		index1 = array1.GetLength(0);
		index2 = array1.GetLength(1);
		
		index3 = array2.GetLength(0);
		index4 = array2.GetLength(1);


		 index1 = index1 - index3;
		 index2 = index2 - index4;
		
			if(index1 != 0 && index2 != 0){
				if(index1 < 0){
					index1 *= -1;
				}
				if(index2 < 0){
					index2 *= -1;
				}
				
				string result = (index1<index2)? array1.GetLength(0) +" do Array 1 e "+array2.GetLength(0)+" do Array 2"  :
												 array1.GetLength(1) +" do Array 1 e "+array2.GetLength(1)+" do Array 2" ;
				Console.WriteLine("O camino mais curto é {0}",result);
			}
			else {
				Console.WriteLine("O array ja chegou no caminho mais curto");
			}
			
					
	}
}
				

	
