//using System;


//namespace Ejemplo
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            List<string> nombres = new List<string>(); 
//        }
//    }
//}

string cadena = "Hola|MUndo|Heriberto";
List<string> text = cadena.Split('|', ' ').ToList();
foreach (string s in text)
{
    Console.WriteLine(s);

}
//Verificar en Documentación de la pagina M.Net  