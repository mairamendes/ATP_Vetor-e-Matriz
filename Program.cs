
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {

        //Exercicio1(); //Procedimento que imprime quais números gerados estão nas posições pares do vetor.
        void Exercicio1()
        {
            int[] numeros = new int[15];
            Random random = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(0, 50); //gera números aleatórios de 0 a 50
                if (i % 2 == 0) //verifica quais números gerados estão nas posições pares do vetor 
                {
                    Console.WriteLine($"Posição {i}: {numeros[i]}");
                }
            }
        }
        //Exercicio2(); //Procedimento que retorna média das notas dos alunos, a menor nota e exibe a quantidade de alunos acima da média 
        void Exercicio2()
        {
            int soma = 0, alunosMedia = 0;
            int[] notas = new int[10];
            Random random = new Random();
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = random.Next(0, 10); //gera números aleatórios de 0 a 10
                soma += notas[i];
                soma++;

                if (notas[i] >= 6)//verifica a quantidade de alunos acima da média
                {
                    alunosMedia++;
                }
            }
            int media = soma / 10;

            Console.WriteLine($"A média total dos alunos foi: {media:F1} pts\nQuantidade de alunos acima da média(6): {alunosMedia}");
        }

        //Exercicio3(); //Procedimento que preenche um vetor de N elementos e retorna posição do maior e do menor elemento.
        void Exercicio3() 
        {
            Random random = new Random();
            int menorNum = 999999;
            Console.WriteLine("Informe a quantidade de números que deseja:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];
            Console.WriteLine("Números gerados:");
            for (int i = 0; i < quantidade; i++)
            {
                numeros[i] = random.Next(0, 100);
                Console.WriteLine($"{numeros[i]}");

                if (numeros[i] < menorNum) //verifica o menor numero
                {
                    menorNum = numeros[i];
                }
            }
            Console.WriteLine($"O menor numero é o: {menorNum}");
        }

        //Exercicio4(); //Procedimento que preenche dois vetores e gera um novo vetor com os 2 vetores intercalando as posições ímpares e pares do novo vetor. 
        void Exercicio4()
        {
            int[] x = new int[10], y = new int[10];
            Random random = new Random();
            int[] z = new int[20];

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = random.Next(0, 10);
                y[i] = random.Next(0, 10);
            }

            // Preenche o vetor z alternando os valores de y (pares) e x (ímpares)
            for (int i = 0; i < z.Length; i++)
            {
                if (i % 2 == 0) // Verifica números pares
                {
                    z[i] = y[i / 2];
                }
                else // Verifica números impares
                {
                    z[i] = x[i / 2];
                }
            }

            Console.WriteLine("Vetor x: " + string.Join(", ", x));
            Console.WriteLine("Vetor y: " + string.Join(", ", y));
            Console.WriteLine("Vetor z (pares de y e ímpares de x): " + string.Join(", ", z));
        }

        //Exercicio5(); //Procedimento que verfica se o número de entrada é igual do vetor gerado
        void Exercicio5()
        {
            int[] vetor = new int[5];
            Random random = new Random();
            Console.WriteLine("Digite um número de 10 a 30");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(10, 30);
                Console.Write(vetor[i] + " "); //retorna os números do vetor
            }
            Console.WriteLine();
            for (int i = 0; i < vetor.Length; i++)
            {
                if (num >= 10 || num <= 30)
                {
                    if (num == vetor[i])
                    { //verifica se número de entrada é igual de algum do vetor
                        Console.WriteLine($"Tentativa número {i + 1}: correta!");
                    }
                    else
                    {
                        Console.WriteLine($"Tentativa número {i + 1}: errada!");
                    }
                }
            }
        }

        //Exercicio6(); //Procedimento que verifica temperaturas de 31 dias, imprime a média, a menor e a maior temperatura, além da quantidade de dia que a temperatura foi inferior à média.
        void Exercicio6()
        {
            int menor = 999999, maior = 0, contador = 0;
            double media = 0;
            int[] temperaturas = new int[31];
            Random random = new Random();
            for (int i = 0; i < temperaturas.Length; i++)
            {
                temperaturas[i] = random.Next(15, 40); //Preenche vetor com temperaturas de 15 a 40°C.
                Console.Write(temperaturas[i] + "°C - ");
                media += temperaturas[i];
                if (temperaturas[i] < menor) menor = temperaturas[i]; //Verifica menor temperatura
                if (temperaturas[i] > maior) maior = temperaturas[i]; //Verifica maior temperatura
            }
            media /= temperaturas.Length;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] < media) contador++; //Verifica quantidade de dias que a temperatura foi inferior a temperatura média
            }
            Console.WriteLine($"\nA menor temperatura foi de {menor}°C e a maior foi de {maior}°C");
            Console.WriteLine($"A temperatura média nos ultimos 31 dias foi de {media:F2}°C.");
            Console.WriteLine($"Total de dias que a temperatura foi inferior à temperatura média: {contador} dias.");
        }

        //Exercicio7(); //Procedimento que preenche um vetor, retorna os números primos, suas respectivas posições e a soma das mesmas.
        void Exercicio7()
        {
            int[,] matriz = new int[3, 3];
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = random.Next(1, 30);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            void verficaNumPrimo(int[,] matriz)
            {
                int soma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] % 2 != 0) //Verifica se é número primo
                        {
                            soma += i + j; // Soma das posições dos elementos de número primo
                            Console.WriteLine($"Posição: [{i}, {j}] - Número primo: {matriz[i, j]}");
                        }
                    }
                Console.WriteLine($"A soma das posições dos números primos deu: {soma}");
            }
            verficaNumPrimo(matriz);
        }

        //Exercicio8(); //Procedimento que preenche uma matriz e retorna a soma de algumas requisições. 
        void Exercicio8()
        {
            int[,] matriz = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(10);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            void SomaLinha3(int[,] matriz)
            {
                int soma = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[2, j]; //Percorre pela matriz buscando a linha 3 de todas colunas
                }
                Console.WriteLine($"\na) Soma da linha 3 de M: {soma}");
            }
            void SomaColuna2(int[,] matriz)
            {
                int soma = 0;
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    soma += matriz[i, 1];
                }
                Console.WriteLine($"b) Soma da coluna 2 de M: {soma}"); //Percorre pela matriz buscando a coluna 2 de todas linhas
            }
            void SomaDiagonalPrincipal(int[,] matriz)
            {
                int soma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    soma += matriz[i, i];
                }
                Console.WriteLine($"c) Soma da diagonal principal: {soma}");
            }
            void SomaDiagonalSecundaria(int[,] matriz)
            {
                int n = matriz.GetLength(0) - 1; //
                int soma = 0;
                for (int i = 0; i <= n; i++)
                {
                    soma += matriz[i, n - i];
                }
                Console.WriteLine($"d) Soma da diagonal secundária: {soma}");
            }
            void SomaTodosElementos(int[,] matriz)
            {
                int soma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        soma += matriz[i, j];
                    }

                Console.WriteLine($"e) Soma de todos os elementos da matriz: {soma}");
            }
            SomaLinha3(matriz);
            SomaColuna2(matriz);
            SomaDiagonalPrincipal(matriz);
            SomaDiagonalSecundaria(matriz);
            SomaTodosElementos(matriz);
        }

        //Exercicio9(); //Procedimento que retorna a matriz transporta.
        void Exercicio9()
        {
            Random random = new Random();
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(10);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz Transposta:\n");

            // Obtém e imprime a matriz transposta
            int[,] transposta = TransporMatriz(matriz);
            for (int i = 0; i < transposta.GetLength(0); i++)
            {
                for (int j = 0; j < transposta.GetLength(1); j++)
                {
                    Console.Write(transposta[i, j] + "\t");
                }
                Console.WriteLine();
            }
            static int[,] TransporMatriz(int[,] matriz)
            {
                int linhas = matriz.GetLength(0);
                int colunas = matriz.GetLength(1);
                int[,] transposta = new int[colunas, linhas];

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        transposta[j, i] = matriz[i, j];
                    }
                }

                return transposta;
            }
        }

        Exercicio10(); //Procedimento que preenche uma matriz e retorna algumas requisições.
        void Exercicio10()
        {
            int[,] matriz = new int[10, 10];
            PreencherMatriz(matriz);

            Console.WriteLine("Matriz Original:");
            ExibirMatriz(matriz);

            // Realiza as operações solicitadas
            TrocarLinhas(matriz, 2, 8);
            Console.WriteLine("\nMatriz após troca da linha 2 com a linha 8:");
            ExibirMatriz(matriz);

            TrocarColunas(matriz, 4, 10);
            Console.WriteLine("\nMatriz após troca da coluna 4 com a coluna 10:");
            ExibirMatriz(matriz);

            TrocarDiagonais(matriz);
            Console.WriteLine("\nMatriz após troca da diagonal principal com a diagonal secundária:");
            ExibirMatriz(matriz);

            // Preenche a matriz com valores aleatórios entre 0 e 99
            static void PreencherMatriz(int[,] matriz)
            {
                Random random = new Random();
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz[i, j] = random.Next(100);
                    }
                }
            }

            // Exibe a matriz no console
            static void ExibirMatriz(int[,] matriz)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(matriz[i, j].ToString("D2") + "\t");
                    }
                    Console.WriteLine();
                }
            }

            // Troca duas linhas da matriz
            static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
            {
                linha1--; // Ajusta para índice zero-based
                linha2--;

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int temp = matriz[linha1, j];
                    matriz[linha1, j] = matriz[linha2, j];
                    matriz[linha2, j] = temp;
                }
            }

            // Troca duas colunas da matriz
            static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
            {
                coluna1--; // Ajusta para índice zero-based
                coluna2--;

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    int temp = matriz[i, coluna1];
                    matriz[i, coluna1] = matriz[i, coluna2];
                    matriz[i, coluna2] = temp;
                }
            }

            // Troca a diagonal principal com a diagonal secundária
            static void TrocarDiagonais(int[,] matriz)
            {
                int n = matriz.GetLength(0);

                for (int i = 0; i < n; i++)
                {
                    int temp = matriz[i, i];
                    matriz[i, i] = matriz[i, n - i - 1];
                    matriz[i, n - i - 1] = temp;
                }
            }
        }
    }
}




