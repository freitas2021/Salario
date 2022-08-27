class Salario
{
    static void Main()
    {
        string nome;
        string salario;
        int valorHr;
        int hrDiaria;
        bool controler = true;
        

       
        Console.WriteLine("Seja bem vindo, por favor digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine($"{nome}. Digite quantas horas deseja trabalhar diariamente: ");
        hrDiaria = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{nome}. Qual é o valor da sua hora trabalhada?: ");
        valorHr = Convert.ToInt32(Console.ReadLine());

        while(controler)
        {

        Console.WriteLine($"{nome}. Escolha o que deseja saber:\n 1 - Para salário diário;\n 2 - Para salário semanal;\n 3 - Para salário mensal;\n 4 - Para salário Anual;\n ");

        salario = Console.ReadLine();

        switch (salario)
        {
            case "1" :
                salarioDiario(hrDiaria, valorHr, nome);
                break;
            case "2" :
                salarioSemanal(hrDiaria, valorHr, nome);
                break;
            case "3" :
                salarioMensal(hrDiaria, valorHr, nome);
                break;
             case "4" :
                salarioAnual(hrDiaria, valorHr, nome);
                break;                      
            default:
                Console.WriteLine("Opção inválida, por favor escola uma opção válida");
                break;
        }

        Console.WriteLine("Aperte qualquer tecla para continuar ou digite [s] para sair.\n");
        string sair = Console.ReadLine();

        if(sair == "s"){
            controler = false;

        }
        
        }
    }

    static void salarioDiario(int hrDiaria, int valorHr, string nome)
    {
        int res = hrDiaria * valorHr; 
        Console.WriteLine($"{nome}, o seu salário diário é R${res:F2}\n");
    }
    static void salarioSemanal(int hrDiaria, int valorHr, string nome)
    {
        int res = (hrDiaria * valorHr) * 5;
        Console.WriteLine($"{nome}, o seu salário semanal é R${res:F2}\n");
    }
    static void salarioMensal(int hrDiaria, int valorHr, string nome)
    {
        int res = (hrDiaria * valorHr) * 20;
        Console.WriteLine($"{nome}, o seu salário semanal é R${res:F2}\n");
    }
    static void salarioAnual(int hrDiaria, int valorHr, string nome)
    {
        int res = (hrDiaria * valorHr) * 240;
        Console.WriteLine($"{nome}, o seu salário semanal é R${res:F2}\n");
    }
}