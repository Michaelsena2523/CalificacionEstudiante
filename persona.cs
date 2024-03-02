
using System; 

class CalificacionEstudiante
{
    static void Main()
    {

        double examen1;
        double examen2;
        double examen3;
        double sum = 0;
        string seguir = "yes";
        

        do {

            while (true)
            {
                Console.WriteLine("Ingrese sus primera calificacion");
                try {
                    examen1 = double.Parse(Console.ReadLine());
                    if (examen1 >= 0 && examen1 <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El numero que debe insertar debe ser menor 100 y 0"); 
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Por favor introdusca calificacion validad"); 
                }

            }

            while (true)
            {
                Console.WriteLine("Ingrese sus primera calificacion");
                try
                {
                    examen2 = double.Parse(Console.ReadLine());
                    if (examen2 >= 0 && examen2 <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El numero que debe insertar debe ser menor 100 y 0");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor introdusca calificacion validad");
                }

            }

            while (true)
            {
                Console.WriteLine("Ingrese sus primera calificacion");
                try
                {
                    examen3 = double.Parse(Console.ReadLine());
                    if (examen3 >= 0 && examen3 <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El numero que debe insertar debe ser menor 100 y 0");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor introdusca calificacion validad");
                }

            }

        for (int i = 1; i < 4 ; i++ )
        {
            Console.WriteLine("Ingrese la primera la nota de la pratica" + i); 
            double pratica = double.Parse(Console.ReadLine());
            sum += pratica;
        }



            double resultado1 = examen1 * 25 / 100;
            double resultado2 = examen2 * 20 / 100;
            double resultado3 = examen3 * 25 / 100;

            double resultadoFinal = resultado1 + resultado2 + resultado3;
            double notaFinalPratica = sum / 100 * 3;
            double NotaFinalDelEstudiante = resultadoFinal + notaFinalPratica;  

            Console.WriteLine("Su calificacion de primera nota es:" + resultado1);
            Console.WriteLine("Su csalificacion de primera nota es:" + resultado2);
            Console.WriteLine("Su calificacion de primera nota es:" + resultado3);
            Console.WriteLine("Su calificacion final es: " + resultadoFinal);
            Console.WriteLine("La suma de lo pratica es " + notaFinalPratica);
            Console.WriteLine("Nota Final del estudiante Aprovado o Reprobado:"+ NotaFinalDelEstudiante);



            Console.WriteLine("Quieres seguir dentro del systema escriba (yes) caso contrario preciones cual tecla");
            seguir = Console.ReadLine();


            Console.ReadKey();
            Console.Clear();

        } while(seguir == "yes"); 


    }
}