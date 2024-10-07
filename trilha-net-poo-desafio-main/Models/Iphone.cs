namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //IMPLEMENTADO LINHA 5, 7 E 9
    public class Iphone : Smartphone
    {   
        public Iphone(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
       
       {}
    
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO LINHAS 13 E 15
        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine("Instalando aplicativo " + nomeApp +  " no Iphone");
        }
    }
}