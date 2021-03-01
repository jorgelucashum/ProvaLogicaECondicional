using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaLogicaECondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Exercicio 1 - Estrutura Sequencial
            Console.WriteLine("1) Fazer um programa para ler as entradas e fazer a operação entre elas. \n");
            for (int cont = 0; cont < 3; cont++) 
            {
                Console.WriteLine("Digite as 3 primeiras entradas(Ex: 1 2,20 3): ");
            string[] linha1 = Console.ReadLine().Split(); // Split é usado para dividir uma cedeia em subcadeiras como matrizes. caso a delimitação nao for especificada será um espaço em branco
            //vetor sem tamanho definido, sendo a entrada do usuario. Toda declaração foi feita em uma só linha e também convertendo string (entrada) para float
            float n1 = float.Parse(linha1[0]), n2 = float.Parse(linha1[1]), n3 =float.Parse(linha1[2]);
            Console.WriteLine("Digite outras 3 entradas");
            string[] linha2 = Console.ReadLine().Split();
            float n4 = float.Parse(linha2[0]), n5 = float.Parse(linha2[1]), n6 = float.Parse(linha2[2]);
                float[] resultado = {0, 1, 2};
                resultado[0] = n3 + n5 * n6;
                resultado[1] = n2 * n3 + n5 * n6;
                resultado[2] = n3 + n6;

                Console.WriteLine("VALOR A PAGAR: R$" + Math.Round(resultado[cont], 2)  + "\n"); // Math.round(x,3) usa-se para limitar casas decimais, sendo 'x' = valor e '3' = numero de casas de decimais. ou Math.round(x,3).ToString()
            
            }
            
            // Exercicio 2
            Console.WriteLine("2) Fazer um programa para ler o valor do raio de um círculo e motrar o valor com 4 casas decimais");
            for(int cont = 0; cont < 3; cont++)
            {
                Console.WriteLine("Digite o valor do raio: ");
                double raio = double.Parse(Console.ReadLine()); //double = long float
                double area = 3.14159 * (raio*raio);
                Console.WriteLine("o valor da área do círuclo é: " + Math.Round(area, 4)); //mostrar 4 casas decimais
            }

            


            // Exercicio - 3

            for (int cont = 0; cont < 2; cont++)
            {

                Console.WriteLine("\n3)Digite o codigo do alimento e a quantidade do alimento desejado. Exemplo: 3 2 \n1-Cachorro Quente\n2-X Salada\n3-X Bacon\n4-Torrada simples\n5-Refrigerente\n");
                string[] entradas = Console.ReadLine().Split();
                float l1 = float.Parse(entradas[0]), q1 = float.Parse(entradas[1]);
                float lanche;
                switch (l1)
                {
                    case 1:
                        lanche = 4;
                        Console.WriteLine("Total: R$" + Math.Round(lanche * q1), 2);
                        break;
                    case 2:
                        lanche = 4.50f;
                        Console.WriteLine("Total: R$" + Math.Round(lanche * q1), 2);
                        break;
                    case 3:
                        lanche = 5;
                        Console.WriteLine("Total: R$" + Math.Round(lanche * q1), 2);
                        break;
                    case 4:
                        lanche = 2;
                        Console.WriteLine("Total: R$" + Math.Round(lanche * q1), 2);
                        break;
                    case 5:
                        lanche = 1.50f;
                        Console.WriteLine("Total: R$" + Math.Round(lanche * q1), 2);
                        break;
                    default:
                        Console.WriteLine("Codigo invalido");
                        break;
                }
            }



            // Exercicio - 4

            for (int cont = 0; cont < 4; cont++) 
                { 
            Console.WriteLine("\n4)Digite os valores de a, b e c em sequencia para realizar a equação do 2º grau. Exemplo: 10 20,1 5,1 ");
            string[] abc = Console.ReadLine().Split();
            float a = float.Parse(abc[0]), b = float.Parse(abc[1]), c = float.Parse(abc[2]);
            float delta = (b * b) - (4 * a * c);
                if (delta > 0 && a != 0) 
                { 
            double x1 = (-(b) + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-(b) - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("X1 = " + Math.Round(x1, 5) + " X2 = " + Math.Round(x2, 5));
                } else
                {
                    Console.WriteLine("Impossível calcular");
                }
            }


            // Exercicio - 5;
            for (int cont = 0; cont == 0;)
            {
                Console.WriteLine("\n5) Digite a senha: ");
                int senha = int.Parse(Console.ReadLine());
                if (senha == 2002) {
                    Console.WriteLine("Acesso permitido\n");
                    cont = + 1;
                } else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }


            // Exercicio - 6
            Console.WriteLine("Digite a quantidade de numeros a serem lidos");
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            int inIntervalo = 0;
            int outIntervalo = 0;
            for (int cont = 0; cont < x.Length; cont++)
            {
                Console.WriteLine("Digite um número: ");
                x[cont] = int.Parse(Console.ReadLine());
                if (x[cont] >9 && x[cont] < 21)
                {
                     inIntervalo = inIntervalo + 1; 
                } else
                {
                    outIntervalo = outIntervalo + 1;
                }
            }
            Console.WriteLine("\nNúmeros dentro do intervalo entre 10 e 20: " + inIntervalo);
            Console.WriteLine("Números fora do intervalo entre 10 e 20: " + outIntervalo);

            Console.ReadLine();
        }
    }
}
