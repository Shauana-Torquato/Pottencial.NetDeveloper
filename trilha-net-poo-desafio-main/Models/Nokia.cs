namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //IMPLEMENTADO LINHAS 5, 7 E 9
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)

        {}
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //IMPLEMENTADO LINHAS 13, 14,15 E16
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo " + nomeApp +  " no Nokia");
        }
    }
}