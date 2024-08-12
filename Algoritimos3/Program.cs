/*
void Mensagem(){
    Console.WriteLine("Olá América do Sul");
}

Mensagem();


void Escreva(string msg){
    Console.WriteLine(msg);
}

Escreva("olá amigo");
string minhaMsg = "testando...";
Escreva(minhaMsg);

void MostrarIdade(string nome, int idade)
{
    Console.WriteLine($"{nome} tem {idade}");
}
MostrarIdade("Joseph", 16);

void CalcularIdade(string nome,int ano)
{
    int idade = 2024 - ano;
    MostrarIdade(nome,idade);
}

CalcularIdade("Neko", 2022);

int Maiorentre(int a, int b)
{
    if(a >= b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
Console.WriteLine(Maiorentre(99,200));
Console.WriteLine(Maiorentre(15,7));
Console.WriteLine(Maiorentre(1,1));



//examplo de repetição

float resultado;

resultado = (100 + 50) / 2f;
Console.WriteLine("a média é: " + resultado);
resultado = (70 + 50) /2f;
Console.WriteLine("a média é: " + resultado);
resultado = (99 + 33) /2f;
Console.WriteLine("a média é: " + resultado);
*/

void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}
Soma(28,28);

void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}
Subtracao(28,13);

void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}
Multiplicacao(28,50);

void Divisao(float a, float b){
    if(b == 0){
        Console.WriteLine("Erro de divisão por zero");
        return;
    }
    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}

//variavieis globais
float a;
float b;

void DigitarAeB(string operacao){

    Console.WriteLine(operacao);

    Console.WriteLine("Digite o valor de a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite no valor de b:");
    b = float.Parse(Console.ReadLine());
}

//MENU
Console.WriteLine("--- Calculadora ---");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Sair");
Console.WriteLine("-------------");
Console.WriteLine("Digite a opção desejada");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitarAeB("Soma");
    Soma(a,b);
}
else if(opcao == 2){
    DigitarAeB("Subtração");
    Subtracao(a,b);
}
else if(opcao == 3){
    DigitarAeB("Multiplicação");
    Multiplicacao(a,b);
}
else if(opcao == 4){
    DigitarAeB("Divisão");
    Divisao(a,b);
}
else if(opcao == 5){
    Console.WriteLine("Saindo...");
}
else{
    Console.WriteLine("Opção inválida");
}