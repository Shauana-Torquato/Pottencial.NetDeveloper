namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //IMPLEMENTADO LINHAS 8, 9, 10 E 12
        private string Modelo {get;}
        private int Imei {get;}
        private int Memoria {get;}

        public Smartphone(string numero, string modelo, int imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
           // IMPLEMENTADO LINHAS 17, 18, E 19
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}