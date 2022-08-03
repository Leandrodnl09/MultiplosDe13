// Exercício do site URI "Multiplos de 13"
// Nesse exercício o usuário ira digitar nois números inteiros "X" e "y", e entro eles o programa vai somar apenas os que não forem multiplos de 13.


int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int Soma = 0;
if (X > Y)
{
    int Troca = Y;
    Y = X;
    X = Troca;
}

for (int i = X; i <= Y; i++)
{
    if (i % 13 != 0)
    {
        Soma = Soma + i;
    }
}
Console.WriteLine(Soma);
