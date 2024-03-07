using System; 


class ModificadorAcceso
{

    int n1, n2, totalsum, totalres;


   static void Main() 
    {

        sum sumar = new sum();
        sumar.calcularsuma(); 

        Console.ReadKey();
        Console.Clear();    

    }



    public class sum
    {

        public void calcularsuma()
        {

            ModificadorAcceso objsuma = new ModificadorAcceso();

            Console.Write("ingrese el primer numero:");
            objsuma.n1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo numero:");
            objsuma.n2 = int.Parse(Console.ReadLine());
            objsuma.totalsum = objsuma.n1 + objsuma.n2;
            Console.Write("La suma de los numero es:" +objsuma.totalsum);
        }


    }

}