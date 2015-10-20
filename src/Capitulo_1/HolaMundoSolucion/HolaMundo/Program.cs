using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Aquí va tu código

            Console.Read();
        }

        /// <summary>
        /// Escribe hola mundo en pantalla.
        /// </summary>
        static void HolaMundo()
        {
            Console.WriteLine("¡Hola Mundo!");
        }

        /// <summary>
        /// Método que recibe dos parametros de tipo entero, y devuelve un valor de tipo entero
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Suma(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Le pregunta al usuario su nombre y edad, y escribe dicha información en pantalla.
        /// </summary>
        static void Ejemplo_1_NombreEdad()
        {
            // Declaramos las variables nombre y edad
            string nombre;
            int edad;

            Console.Write("Ingrese su nombre: ");

            // Lo que el usuario escriba será asignado a la variable nombre
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            // Lo que el usuario escriba ahora será asignado a su edad (debe ser un entero)
            edad = int.Parse(Console.ReadLine());

            // Armamos el mensaje final.
            string mensajeFinal = string.Format("Usted se llama {0} y tiene {1} años de edad", nombre, edad);

            // Mostramos el mensaje final
            Console.WriteLine(mensajeFinal);
        }

        /// <summary>
        /// Ejemplo de una clase con 3 variables.
        /// </summary>
        class Persona
        {
            public string Nombre;
            public int Edad;
            public string Direccion;
        }

        /// <summary>
        /// Instanciando la clase persona.
        /// </summary>
        static void InstanciandoLaClasePersona()
        {
            // Instanciamos la clase y le ponemos el nombre p a la variable
            Persona p = new Persona();

            // acceso los miembros de la clase utilizando un punto (.) y luego el nombre del miembro de la clase.
            p.Nombre = "Fausto Contreras";
            p.Edad = 35;
            p.Direccion = "Calle 123";
        }

        /// <summary>
        /// Varios ejemplos de algunos de los operadores de C#.
        /// </summary>
        private static void Operadores_Ejemplos()
        {
            // asignación
            var a = 1;
            var b = 2;
            var c = 8;
            var d = 9;
            string templateEncabezado = "\n--- {0} ---\n";

            Console.WriteLine(templateEncabezado, "Operaciones aritméticas");
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", c, a, c - a);
            Console.WriteLine("{0} * {1} = {2}", b, c, b * c);
            Console.WriteLine("{0} / {1} = {2}", c, b, c / b);

            //Como 1 y 2 son enteros, al dividirlos nos devuelve un entero y no un double
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);

            // Si escribimos 1.0 entonces el resultado de la división es de tipo double, pues 1.0 es double
            Console.WriteLine("{0} / {1} = {2}", "1.0", b, 1.0 / b);

            // Incremento en 1 el valor de a
            a++;
            Console.WriteLine("El incremento de {0} es {1} pues x++ = x + 1", a - 1, a);

            // Disminuyo en 1 el valor de a
            a--;
            Console.WriteLine("El decremento de {0} es {1} pues x-- = x - 1", a + 1, a);

            Console.WriteLine(templateEncabezado, "Residuo");
            Console.WriteLine("{0} % {1} = {2}", b, a, b % a);
            Console.WriteLine("{0} % {1} = {2}", d, b, d % b);

            // Acceso de miembro
            Console.WriteLine(templateEncabezado, "Acceso a miembro");
            var stringEjemplo = string.Empty;
            Console.WriteLine("var stringEjemplo = string.Empty;");

            // invocación de método
            Console.WriteLine(templateEncabezado, "Invocación de un método");
            var esVacioElString = string.IsNullOrEmpty(stringEjemplo);
            Console.WriteLine(" var esVacioElString = string.IsNullOrEmpty(stringEjemplo);");

            Console.WriteLine(templateEncabezado, "default");
            Console.WriteLine("El valor por defecto de {0} es {1}", typeof(int), default(int));
            Console.WriteLine("El valor por defecto de {0} es {1}", typeof(bool), default(bool));
            Console.WriteLine("El valor por defecto de {0} es {1}", typeof(DateTime), default(DateTime));


            // Operaciones de relacion
            Console.WriteLine(templateEncabezado, "operaciones de relación");
            Console.WriteLine("{0} < {1} es {2}", a, b, a < b);
            Console.WriteLine("{0} < {1} es {2}", c, a, c < a);

            Console.WriteLine("{0} > {1} es {2}", a, b, a > b);
            Console.WriteLine("{0} > {1} es {2}", d, b, d > b);

            Console.WriteLine("{0} <= {1} es {2}", c, d, c <= d);
            Console.WriteLine("{0} <= {0} es {1}", b, b <= b);

            Console.WriteLine("{0} >= {1} es {2}", c, d, c >= d);
            Console.WriteLine("{0} >= {0} es {1}", a, a >= a);

            Console.WriteLine("{0} is int = {1}", a, a is int);
            Console.WriteLine("{0} is string = {1}", a, a is string);

            Console.WriteLine("{0} == {1} = {2}", a, b, a == b);
            Console.WriteLine("{0} == {0} = {1}", a, a == a);

            Console.WriteLine("{0} != {1} = {2}", c, d, c != d);
            Console.WriteLine("{0} != {0} = {1}", b, b != b);

            // operaciones logicas
            Console.WriteLine(templateEncabezado, "operaciones lógicas");
            var booleano = true;
            Console.WriteLine("Operación negación: !{0} = {1} ", booleano, !booleano);

            Console.WriteLine("{0} & {0} = {1}", true, true & true);
            Console.WriteLine("{0} & {0} = {1}", false, false & false);
            Console.WriteLine("{0} & {1} = {2}", true, false, true & false);

            Console.WriteLine("{0} ^ {0} = {1}", true, true ^ true);
            Console.WriteLine("{0} ^ {0} = {1}", false, false ^ false);
            Console.WriteLine("{0} ^ {1} = {2}", true, false, true ^ false);

            Console.WriteLine("{0} | {0} = {1}", true, true | true);
            Console.WriteLine("{0} | {1} = {2}", true, false, true | false);
            Console.WriteLine("{0} | {1} = {2}", false, false, false | false);

            int? enteroNulo = null;
            int? enteroNoNulo = 7;
            Console.WriteLine("{0} ?? {1} = {2}", enteroNoNulo, a, enteroNoNulo ?? a);
            Console.WriteLine("null ?? {0} = {1}", a, enteroNulo ?? a);

            Console.WriteLine("{0} ? {1} : {2} = {3}", true, a, b, true ? a : b);
            Console.WriteLine("{0} ? {1} : {2} = {3}", false, a, b, false ? a : b);
        }

        /// <summary>
        /// Utilizamos la sentencia if para restringir el acceso a nuestro software.
        /// </summary>
        static void Ejemplo_2_SentenciaIf()
        {
            string nombre;
            int edad;

            Console.Write("Ingrese su nombre: ");

            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("No ofrecemos servicio a menores.");
            }
            else
            {
                string mensajeFinal = string.Format("Usted se llama {0} y tiene {1} años de edad", nombre, edad);
                Console.WriteLine(mensajeFinal);
            }
        }

        /// <summary>
        /// Imprime los números del 1 al 3 en pantalla
        /// </summary>
        static void BucleFor_ImprimerNumerosDelUnoAlTres()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i); // Imprime el actual valor de i
            }
        }

        /// <summary>
        /// Recorriendo una lista usando la sentencia for.
        /// </summary>
        static void BucleFor_RecorrerUnaLista()
        {
            var listadoStrings = new List<string>() { "ejemplo 1", "ejemplo 2", "ejemplo 3" };

            for (int i = 0; i < listadoStrings.Count; i++)
            {
                // Sustituyo el elemento por el mismo en mayúscula
                listadoStrings[i] = listadoStrings[i].ToUpper();
            }

            // Imprimo el resultado en pantalla
            for (int i = 0; i < listadoStrings.Count; i++)
            {
                Console.WriteLine(listadoStrings[i]);
            }
        }

        /// <summary>
        /// Imprime numeros de dos en dos usando la sentencia while
        /// </summary>
        static void BucleWhile_CuentaDeDosEnDos()
        {
            int contador = 2;
            int final = 10;
            while (contador <= final)
            {
                Console.WriteLine(contador);
                contador += 2; // Le suma 2 a la variable contador
            }
        }

        /// <summary>
        /// El Promediador 3000 permite ingresar una secuencia de enteros vía consola y devuelve
        /// el promedio de dicha secuencia.
        /// </summary>
        static void Ejemplo3_Promediador3000()
        {
            Console.WriteLine("¡Bienvenido al Promediador 3000!");
            Console.WriteLine("¡Ingrese números enteros y le calculamos el promedio!");
            Console.WriteLine("");

            var continuarEjecucion = true;
            var listadoDeInputs = new List<int>();
            string input;

            while (continuarEjecucion)
            {
                Console.Write("Ingrese un número a la secuencia:");
                input = Console.ReadLine();
                if (input == "")
                {
                    string InputsSeparadosPorComa = string.Join(",", listadoDeInputs.ToArray());
                    double promedio = listadoDeInputs.Average();
                    Console.WriteLine("El promedio de los números {0} es {1}",
                        InputsSeparadosPorComa, promedio);

                    listadoDeInputs.Clear();
                    Console.Write("¿Desea empezar de nuevo (y/n)?");
                    input = Console.ReadLine();
                    if (input != "y")
                    {
                        continuarEjecucion = false;
                    }
                }
                else
                {
                    listadoDeInputs.Add(int.Parse(input));
                }
            }
        }

        /// <summary>
        /// Demostración de que la sentencia do ejecuta su bloque al menos una vez, a diferencia
        /// de la sentencia while que no necesariamente lo hace.
        /// </summary>
        static void BucleDo_BucleWhile_Diferencia()
        {
            while (false)
            {
                Console.WriteLine("El bloque while se ejecuta");
            }

            do
            {
                Console.WriteLine("El bloque Do se ejecuta");
            } while (false);
        }

        /// <summary>
        /// Utilizamos el foreach para recorrer una lista de strings e imprimir sus elementos.
        /// </summary>
        static void BucleForeach_ImprimeUnaLista()
        {
            var listado = new List<string>() { "Ejemplo 1", "Ejemplo 2", "Ejemplo 3" };
            foreach (var item in listado)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Detenemos la ejecución de un bucle utilizando la sentencia Break.
        /// </summary>
        static void Break_DeteniendoUnBucle()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Ignoramos un elemento de una secuencia utilizando la sentencia Continue.
        /// </summary>
        static void Continue_ContinuandoUnBucle()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Ejemplo de un enum.
        /// </summary>
        enum Servicio
        {
            Regular = 5,
            VIP = 24,
            Platinum = 2
        }

        /// <summary>
        /// Utilizando un enum para un switch.
        /// </summary>
        static void enums_Switch()
        {
            var categoriaServicio = Servicio.VIP;
            switch (categoriaServicio)
            {
                case Servicio.Regular:
                    break;
                case Servicio.VIP:
                    break;
                case Servicio.Platinum:
                    break;
            }
        }

        /// <summary>
        /// Código utilizado para demostrar el poder de las herramientas de debugging de Visual Studio
        /// </summary>
        static void debug_codigoConUnError()
        {
            var monto = 29.99m;
            var cantidad = 3;
            var total = CalcularTotal(monto, cantidad);
            total = Math.Round(total, 2); // Redondea a dos dígitos
            // Con un impuesto del 10%, el total debe ser: 98.967
            Console.WriteLine(total); // La cantidad va a ser diferente a lo esperado
        }

        /// <summary>
        ///Código utilizado para demostrar el poder de las herramientas de debugging de Visual Studio 
        /// </summary>
        /// <param name="monto"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        static decimal CalcularTotal(decimal monto, int cantidad)
        {
            var impuesto = 0.1m; // Impuesto obtenido via consulta
            var montoPorcantidad = monto + cantidad;
            var total = montoPorcantidad * (impuesto + 1);
            return total; // Con return devolvemos un valor
        }
    }
}
