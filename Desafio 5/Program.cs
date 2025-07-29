using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Desafio 5 – Competição de Performance

            Implemente dois métodos de busca (sequencial e binária) para encontrar um número inteiro dentro de um vetor com 1000 elementos ordenados. 
            Meça e exiba o tempo de execução de cada método. O objetivo é que os alunos compare a eficiência prática de cada algoritmo.

            Dica: use Stopwatch para medir o tempo de execução em C#.
             */
            // Criação do vetor com 1000 elementos ordenados
            int[] vetor = new int[1000];
            bool continuar = false;
            int numeroParaBuscar = 0;
            Stopwatch stopwatch = new Stopwatch();

            Bemvindo();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i + 1; // Preenchendo o vetor com números de 1 a 1000
            }
            // Número a ser buscado
            Console.WriteLine("Digite um número inteiro entre 1 e 1000 para buscar no vetor:");
            while (continuar == false)
            {
                try
                {
                    numeroParaBuscar = int.Parse(Console.ReadLine()); // Exemplo de número a ser buscado
                    if (numeroParaBuscar > 0 && numeroParaBuscar < 1000)
                        continuar = true;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Número inválido. Por favor, digite um número inteiro entre 1 e 1000:");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Número fora do intervalo permitido. Por favor, digite um número inteiro entre 1 e 1000:");
                }
            }

            // Medindo o tempo de execução da busca sequencial
            stopwatch.Start();
            int resultadoSequencial = BuscaSequencial(vetor, numeroParaBuscar);
            stopwatch.Stop();
            double tempo = ContandoTicks(stopwatch);

            // Medindo o tempo de execução da busca binária
            stopwatch.Reset();
            stopwatch.Start();
            int resultadoBinario = BuscaBinaria(vetor, numeroParaBuscar);
            stopwatch.Stop();
            double tempo2 = ContandoTicks(stopwatch);

            // Comparando os resultados
            if (tempo == tempo2)
            {
                Console.WriteLine("Os resultados das buscas são iguais.");
            }
            else if (tempo < tempo2)
            {
                Console.WriteLine("O algoritmo de busca sequencial foi mais eficiente");
            }
            else
            {
                Console.WriteLine("O algoritmo de busca binária foi mais eficiente");
            }

            // Espera o usuário pressionar uma tecla para fechar o console
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
        static double ContandoTicks(Stopwatch stopwatch)
        {
            long ticks = stopwatch.ElapsedTicks;
            double frequencia = Stopwatch.Frequency;

            double microssegundos = (ticks / frequencia) * 1_000_000;

            Console.WriteLine($"Tempo decorrido: {microssegundos:F3} microssegundos");

            return microssegundos;
        }

        static void Bemvindo()
        {
            Console.WriteLine("Bem-vindo a Competição de Performance!");
            Console.WriteLine("Neste desafio, você irá implementar dois métodos de busca (sequencial e binária) para encontrar um número inteiro dentro de um vetor com 1000 elementos ordenados.");
            Console.WriteLine("Vamos comparar a eficiência prática de cada algoritmo.");
            Console.WriteLine();
        }
        static int BuscaSequencial(int[] vetor, int numero)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == numero)
                {
                    return i; // Retorna o índice do número encontrado
                }
            }
            return -1; // Retorna -1 se o número não for encontrado
        }

        static int BuscaBinaria(int[] vetor, int numero)
        {
            int esquerda = 0;
            int direita = vetor.Length - 1;
            while (esquerda <= direita)
            {
                int meio = (esquerda + direita) / 2;
                if (vetor[meio] == numero)
                {
                    return meio; // Retorna o índice do número encontrado
                }
                else if (vetor[meio] < numero)
                {
                    esquerda = meio + 1;
                }
                else
                {
                    direita = meio - 1;
                }
            }
            return -1; // Retorna -1 se o número não for encontrado
        }
    }
}
