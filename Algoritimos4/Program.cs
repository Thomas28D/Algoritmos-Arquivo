
bool Resposta()
{
    inicioPergunta:
    string resposta = Console.ReadLine();

    if(resposta == "s")
    {
        return true;
    }
    else if(resposta ==  "n")
    {
        return false;
    }
    else
    {
        Console.WriteLine("Não entendi, responda apenas s/n");
        goto inicioPergunta;
    }
}

Console.WriteLine("Quer jogar um jogo? s/n");
if(Resposta() == false)
{
    goto finalJogo;
}

iniciojogo:

int menor = 0;
int maior = 100;
int numTentativas = 10;
bool jogoRodando = true;

Random rand = new Random();
int sorteado = rand.Next(menor, maior + 1);
Console.WriteLine($"Pensei em um número entre {menor} e {maior}. Tente adivinhar!");


while(jogoRodando)
{
    Console.Write($"Tentativa {numTentativas}: ");
    int numDigitado = int.Parse(Console.ReadLine());
    if(numDigitado < sorteado)
    {
        Console.WriteLine("Muito baixo. Tente novamente.");
        numTentativas--;
    }
    else if(numDigitado > sorteado)
    {
        Console.WriteLine("Muito alto, Tente novamente.");
        numTentativas--;
    }
    else
    {
        Console.WriteLine("Parabéns! Você acertou!");
        jogoRodando = false;
    }

    if(numTentativas == 0)
    {
        Console.WriteLine($"Acaram suas tentativas. O número que pensei era {sorteado}.");
        jogoRodando = false;
    }
}



Console.WriteLine("Quer jogar de novo? s/n");
if(Resposta() == true)
{
    goto iniciojogo;
}

finalJogo:
Console.WriteLine("Então até a próxima!");
