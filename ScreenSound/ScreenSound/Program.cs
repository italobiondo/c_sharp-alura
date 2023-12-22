//Screen Sound

string mensagemDeBoasVindas = "Seja bem vindo ao Screen Sound";


void EscreveNaTela()
{
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoMenu = Console.ReadLine()!;
    int opcoesMenuNumerico = int.Parse(opcaoMenu);

    switch (opcoesMenuNumerico)
    {
        case 1: Console.WriteLine("Você escolheu a opção " + opcoesMenuNumerico);
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + opcoesMenuNumerico);
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcoesMenuNumerico);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcoesMenuNumerico);
            break;
        case -1:
            Console.WriteLine("Saindo do Screen Sound.");
            break;
        default: Console.WriteLine("Opção invalida.");
            break;
    }

}

Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();
Console.WriteLine("Olá, {0}!", nome);

EscreveNaTela();
ExibirOpcoesMenu();