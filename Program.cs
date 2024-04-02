class Program
{
    static void Main()
    {
        Console.WriteLine("Resolução do Teste Técnico para vaga de estagiário na empresa Target Sistemas");

        bool should_run = true;
        while (should_run)
        {
            Console.WriteLine("\nDigite o problema que você quer a resolução: 1, 2, 3, 5 (as respostas do problema 4 está escrita em sua função) ou S para sair: ");
            string opcao = Console.ReadLine()!.Trim().ToUpper();

            switch (opcao)
            {
                case "1":
                    Problema1();
                    break;
                case "2":
                    Problema2();
                    break;
                case "3":
                    Problema3();
                    break;
                case "5":
                    Problema5();
                    break;
                case "S":
                    Console.WriteLine("Obrigado pela atenção. Link para o meu GitHub: https://github.com/leomartinsdev. Encerrando programa!");
                    should_run = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    public static void Problema1()
    {
        // 1) Observe o trecho de código abaixo:
        // int INDICE = 13, SOMA = 0, K = 0;
        // enquanto K < INDICE faça
        // {
        // K = K + 1;
        // SOMA = SOMA + K;
        // }
        // imprimir(SOMA);
        // Ao final do processamento, qual será o valor da variável SOMA?

        int INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE)
        {
            K++;
            SOMA += K;
        }

        Console.WriteLine($"Ao final do processamento, o valor da variável SOMA é: {SOMA}");
    }

    public static void Problema2()
    {
        // 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

        // IMPORTANTE:
        // Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

        Console.WriteLine("Escolha um número: ");
        int numero_escolhido = Convert.ToInt32(Console.ReadLine());

        List<int> fibonacci = new List<int>
        {
            0,
            1
        };


        while (fibonacci[^1] <= numero_escolhido)
        {
            int numero_para_adicionar = fibonacci[^1] + fibonacci[^2];
            fibonacci.Add(numero_para_adicionar);

            if (fibonacci[^1] > numero_escolhido)
            {
                break;
            }
        }

        int counter = 0;
        while (true)
        {
            if (fibonacci[counter] == numero_escolhido)
            {
                Console.WriteLine("O número escolhido está presente na sequência de Fibonacci");
                break;
            }

            if (counter == (fibonacci.Count + 1) || numero_escolhido < fibonacci[counter])
            {
                Console.WriteLine("O número escolhido não está na sequência de Fibonacci");
                break;
            }

            counter++;
        }
    }

    public static void Problema3()
    {
        // 3) Descubra a lógica e complete o próximo elemento:

        // a) 1, 3, 5, 7, 9  -> soma 2

        // b) 2, 4, 8, 16, 32, 64, 128 -> potências de 2

        // c) 0, 1, 4, 9, 16, 25, 36, 49 -> quadrado da sua posição

        // d) 4, 16, 36, 64, 100

        // e) 1, 1, 2, 3, 5, 8, 13 -> Fibonacci

        // f) 2, 10, 12, 16, 17, 18, 19, 200 -> Todos começam com a letra D. O próximo é "duzentos".

        Console.WriteLine("Respostas -> a) 9, b) 128, c) 49, d) 100, e) 13, f) 200");
    }

    public static void Problema4()
    {
        // 4) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.

        // Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

        // Resposta: primeiramente, vamos supor que todas as lâmpadas estão desligadas. Inicialmente, eu ligaria os interruptores 1 e 2 e visitaria a sala 1.
        // Primeiro caso: se a sala 1 estivesse apagada, eu sei que o interruptor 3 controla a sala 1. Após isso, eu desligaria o interruptor 1 e entraria na sala 2. Se a sala dois estivesse desligada, eu saberia que o interruptor 1 controla a sala 2 e o interruptor 2 controla a sala 3. Nesse caso, a solução seria: sala 1 é controlada pelo interruptor 3, sala 2 é controlada pelo interruptor 1 e a sala 3 é controlada pelo interrutor 2. Caso ao desligar o interruptor 1 e entrar na sala 2 ela estivesse ligada, eu saberia que a sala 2 é controlada pelo interruptor 2 e a sala 3 é controlada pelo interruptor 1. Nesse caso, a solução seria: a sala 1 é controlada pelo interrupr 3, a sala 2 é controlada pelo interruptor 2 e a sala 3 é controlada pelo interruptor 3.

        // Segundo caso: se a sala 1 estivesse acesa, eu sei que a sala 1 é controlada ou pelo interruptor 1 ou pelo interruptor 2. Nesse caso, eu manteria o interruptor 1 ligado, desligaria o 2 e ligaria o 3. Após isso, entraria na sala 2. Se ela estivesse ligada, significa que a sala 1 é controlada ou pelo interruptor 1 ou pelo interruptor 2, e as outras salas seriam controladas pelos seus respectivos interruptores. Não daria para saber com certeza qual controla qual sala. Agora, no caso da sala 2 estar desligada, saberíamos que a sala 1 é controlada pelo interruptor 1, a sala 2 é controlada pelo interruptor 2 e a sala 3 é controlada pelo interruptor 3.

        // Levando em conta os dois casos, em 4 ramificações do problema, teríamos a resposta exata em 3 dos casos.


        // Agora, pensando que "duas visitas até uma das salas" possa significar que eu posso visitar duas vezes cada sala, a solução fica mais simples:
        // Primeiramente, eu ligaria o interruptor 1 e visitaria a sala 1. Caso estivesse ligada, sei que o interruptor 1 controla a sala 1. Após isso isso, desligaria o interruptor 1, ligaria o interruptor 2 e iria para a sala 2. Se ela estivesse ligada, saberia que ela é controlada pelo interruptor 2 e, consequentemente, a sala 3 seria controlada pelo interruptor 3. Caso a sala 2 estivesse desligada, saberia que ela é controlada pelo interruptor 3 e a sala 3 pelo interruptor 2.

        // Caso sala 1 estivesse desligada, eu desligaria o interruptor 1 e ligaria o interruptor 2. Voltaria para a sala 1 e, caso estivesse ligada, sei que a sala 1 é controlada pelo interruptor 2 e se estivesse desligada saberia que a sala 1 é controlada pelo interruptor 3. Se ela fosse controlada pelo interruptor 2, eu desligaria esse interruptor, ligaria o interruptor 1 e iria para a sala 2. Caso estivesse ligada, saberia que a sala 2 é controlada pelo interruptor 1 e a sala 3 controlada pelo interruptor 3. Caso fosse controlada pelo interruptor 3, desligaria esse interruptor e faria o mesmo processo, descobrindo assim os interruptores que controlam o restante das salas.
    }

    public static void Problema5()
    {
        // 5) Escreva um programa que inverta os caracteres de um string.
        // IMPORTANTE:

        // a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

        // b) Evite usar funções prontas, como, por exemplo, reverse;

        Console.WriteLine("Digite uma palavra");
        string palavra = Console.ReadLine()!;
        string palavra_reversa = "";

        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            palavra_reversa += palavra[i];
        }

        Console.WriteLine(palavra_reversa);
    }
}
