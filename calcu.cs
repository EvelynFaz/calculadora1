 namespace calculadora
{
    class Programa

    {
       
        static int suma(int a, int b)
        //funciones de la calculadora
        {
            int suma = a + b;
            return suma;
        }
 
        static int resta(int a, int b)
        {
            int resta = a - b;
            return resta;
        }
 
        static int multiplicacion(int a, int b)
        {
            int multi = a * b;
            return multi;
        }
 
        static int division(int a, int b)
        {
            int divi = a / b;
            return divi;
        }        
 
        //Menú 
 
        static void Main(string[] args)
        {
            int a, b;
            int num;
            int cuadrado = 0;
            Console.Write("\n" + "Ingrese un número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\n" + "Ingrese un número: ");
            b = int.Parse(Console.ReadLine());

            
            Console.WriteLine("inrese el numero de la raiz");
                
                while(!int.TryParse((console.ReadLine(), out num))
                console.WriteLine("ingrese un numero entero")
                
                while(num <= 0)
                    console.writeLine("ingrese un numero mayor que 0");
 
            Console.Write("\n" + "Seleccione una opción: " + "\n" + "\n");
            Console.Write("\n" + "     1º) Suma" + "\n" + "     2º) Resta" + "\n" + "     3º) Multiplicación" + "\n" + "     4º) División" + "\n" + "   5º) raiz" + "\n" + "   6º) resultado del Programa" + "\n" + "\n");
 
                switch (Console.Read())
 
                {
                     Console.Write("\n" + "    Suma = " + suma(a,b));
                    Console.Write("\n" + "    Resta = " + resta(a, b));
                    Console.Write("\n" + "    Multiplicación = " + multiplicacion(a, b));
                    Console.Write("\n" + "    División = " + division(a, b));
                    Console.Write("\n" + "    raiz = " + raiz(a, b, c));
                    Console.Write("\n" + " este fue tu resultado ");
                   
              }
 
            Console.ReadKey();
        }
    }
}