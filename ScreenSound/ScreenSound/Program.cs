//Screen Sound

string mensagemDeBoasVindas = "Seja bem vindo ao Screen Sound";

List<string> listaDeBandas = new List<string> { "Metallica", "AC/DC", "Iron Maiden", "Guns N' Roses", "Led Zeppelin" };


void ExibirLogo()
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
    ExibirLogo();
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
        case 1: RegistarBanda();
            break;
        case 2: MostrarBandasRegistradas();
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

void RegistarBanda()
{
    Console.Clear();
    Console.WriteLine("**********************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("**********************************");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear() ;
    Console.WriteLine("**********************************");
    Console.WriteLine("Bandas Registradas");
    Console.WriteLine("**********************************\n");
    /*
    for (int i = 0; i < listaDeBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDeBandas[i]}");
    }
    */

    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();

}

ExibirOpcoesMenu();