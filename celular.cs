namespace celular_poo
{
    public class celular
    {
       public string Cor; 
       public string Modelo;

    public string Tamanho;
    public bool Ligando;

    public void Ligar()
    {
       if(Ligando == false)
       {
        Console.WriteLine($"Ligar");
        
       }
       else
       {
         Console.WriteLine($"O celular ja esta ligado");
         
       }
    }
    public void Desligar()
    {
      if(Ligando == true)
      {
         Console.WriteLine($"Desligando o celular");
         
      }
      else
      {
         Console.WriteLine($"O celular ja esta desligado");
         
      }
    }
    public void FazerLigacao()
    {
      if(Ligando == true)
      {
         Console.WriteLine($"Para quem você deseja ligar? ");
         
      }
      else
      {
         Console.WriteLine($"Não é possivel executar esse comando pois o celular esta DESLIGADO");
         
      }
    }
    public void EnviarMensagem()
    {
      if(Ligando == true)
      {
         Console.WriteLine($"Envie uma mensagem!");
      }
      else
      {
         Console.WriteLine($"Não é possivel executar esse comando pois o celular esta DESLIGADO");
      }
    }
    }
}