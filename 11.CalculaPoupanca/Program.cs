using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

        double investimento = 1000;

        //rendimento de 0.5% (0.005) ao mês.

        //mes 1
        investimento = investimento + investimento * 0.005;
        
        //mes 2
        investimento = investimento + investimento * 0.005;

        //mes 3
        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);

        //Saber o investimento daqui doze mes (enquanto/while o mes for igual ou menos a doze, o meu investimento será de...

        int mes = 1;
        while (mes <= 12) {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mes " + mes + " você tem " + investimento);

            //mes = mes + 1 ou também mes ++;
            mes += 1; //Sem esse trecho de código aconteceria o laço de repetição (loop) pois ao chegar na chave voltaria para o while.
        } 



        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
        Console.Write("Que pena, vejo você no próximo código");
        Console.ReadLine();
    }

}