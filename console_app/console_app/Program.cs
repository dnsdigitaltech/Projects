using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array
            string[] a = new string[3];
            a[0] = "Davi";
            a[1] = "Silvia";
            a[2] = "Bernardo";

            // Tem como verificar se existe o item no array tambem, sendo que é mais complexo

            if (Array.Exists(a, e => e == "Davi"))
            {
                Console.WriteLine("Encontrei este item no meu Array");
            }

            int size = a.Length;//saber a quantidade do array
            Console.WriteLine(size);
            Array.Sort(a);//ordenando os dados no array

            foreach (string nome in a)
            {
                Console.WriteLine(nome);
            }

            //Colection mais usado
            List<string> b = new List<string>();
            b.Add("Carlos");
            b.Add("Phelipe");
            b.Add("Claudia");

            foreach (string nome2 in b)
            {
                Console.WriteLine(nome2);
            }

            int size_list = b.Count; ;//saber a quantidade da coleção
            Console.WriteLine(size_list);

            //Vantagens de usar collection
            if (b.Exists(e => e == "Claudia"))//verifica se existe um item no collection
            {
                Console.WriteLine("Encontrei este item no meu collection");
            }

            b.ToArray();//tranformando uma coleção em array


            Console.Read();

        }
    }
}
