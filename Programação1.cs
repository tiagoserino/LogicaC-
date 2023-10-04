using static System.Console;
string nome;
decimal media, n1, n2, n3, n4;
ForegroundColor = ConsoleColor.Green;
WriteLine(">>>> VERIFICAR APROVAÇÃO <<<<\n");
ResetColor();
WriteLine("Qual é o seu nome?");
nome = ReadLine();
WriteLine("Digite a sua 1º nota:");
n1 = Convert.ToDecimal(ReadLine());
WriteLine("Digite a sua 2º nota:");
n2 = Convert.ToDecimal(ReadLine());
WriteLine("Digite a sua 3º nota:");
n3 = Convert.ToDecimal(ReadLine());
WriteLine("Digite a sua 4º nota:");
n4 = Convert.ToDecimal(ReadLine());
media = (n1 + n2 + n3 + n4) / 4;
if (media >= 6)
{
    ForegroundColor = ConsoleColor.Green;
    WriteLine(">>>> Você está aprovado <<<<\n");
    ResetColor();
}
else
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine(">>>> Você está reprovado <<<<\n");
    ResetColor();
}
ReadKey();