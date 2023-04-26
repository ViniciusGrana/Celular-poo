using celular_poo;
celular x = new celular();

Console.Write($"Informe a cor do celular: ");
x.Cor = Console.ReadLine();
Console.Write($"Informe o modelo do celular: ");
x.Modelo = Console.ReadLine();
Console.Write($"Informe o tamanho do celular: ");
x.Tamanho = Console.ReadLine();


Console.WriteLine($"O celular esta ligado? (s/n)");
string ligado = Console.ReadLine();

if(ligado == "s")
{
    x.Ligando=true;
   
}
else
{
    x.Ligando=false;
}

Console.WriteLine(@$"Celular
1- Ligar
2 - Desligar
3 - Fazer ligação
4 - Mandar mensagem");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    x.Ligar();
        break;
    case "2":
    x.Desligar();
        break;
    case "3":
    x.FazerLigacao();
        break;
    case "4":
    x.EnviarMensagem();
        break;
    default:
    Console.WriteLine($"Opção invalida");
        break;
}


