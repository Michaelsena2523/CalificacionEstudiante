using System; 


 class persona{
	 
	 
	 static void Main(){
        
         string seguirSystema = "yes"; 
		 double ResultadoPratica = 0;
    do{		
	
		 
	
		Console.WriteLine("Ingrese la primera nota");  
        double examen1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la primera nota");  
        double examen2 = double.Parse(Console.ReadLine());
 
        Console.WriteLine("Ingrese la primera nota");  
        double examen3 = double.Parse(Console.ReadLine()); 
		
		
		for(int i = 1 ; i < 4 ; i++)
		{
		 Console.WriteLine("Ingrese la nata de la pratica"+ i ); 
         double pratica = double.Parse(Console.ReadLine()); 
         ResultadoPratica += pratica; 		 
			
		}
   
        double resultadoExamen1 = examen1 * 25 / 100; 
		double resultadoExamen2 = examen2 * 20 / 100;
		double resultadoExamen3 = examen3 * 15 / 100;
		double sumaTotalExamen = resultadoExamen1 + resultadoExamen2 + resultadoExamen3;
		
		Console.WriteLine("El resultado es:" +resultadoExamen1);
		Console.WriteLine("El resultado es:" +resultadoExamen2);
		Console.WriteLine("El resultado es:" +resultadoExamen3);
		Console.WriteLine("El total del promedio del Examen es :"+ sumaTotalExamen);
        Console.WriteLine("EL resultado de la pratica:"+ ResultadoPratica); 		
    
	
	
	Console.WriteLine("Quieres seguir en systema escriba (yes)"); 
    seguirSystema = Console.ReadLine(); 
	
    Console.Clear();	

	}while(seguirSystema == "yes" ); 
   
   
		 
	 }
 }