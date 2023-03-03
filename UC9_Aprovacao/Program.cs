string[,] alunos = new string[5,7];
double[] notas = new double[5];
double[] faltas = new double[5];
int i = 0;
int j = 0;


for (i = 0; i <= 4; i++)
{
    Console.Clear();
    Console.WriteLine("Qual o nome do aluno ?");
    alunos[i,j++] = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Qual o total de aulas dadas ?");
    alunos[i, j++] = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Qual o numero de faltas ?");
    alunos[i, j++] = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Qual a nota da 1° prova ?");
    alunos[i, j++] = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Qual a nota da 2° prova ?");
    alunos[i, j++] = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Qual a nota da 3° prova ?");
    alunos[i, j++] = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Qual a nota do trabalho ?");
    alunos[i, j++] = Console.ReadLine();
    Console.WriteLine();


}

Console.Clear();



for (i = 0; i <= 5; i++)
{

    notas[i] = (double.Parse(alunos[i,3])*30/100)+ (double.Parse(alunos[i, 4]) * 25 / 100)+ (double.Parse(alunos[i, 5]) * 30 / 100);
    if (Double.Parse(alunos[i, 6]) >= 6)
    {
        notas[i]++;
    }

    faltas[i] = Double.Parse(alunos[i,1])*25/100;
}
