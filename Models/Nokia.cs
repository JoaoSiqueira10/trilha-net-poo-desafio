namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Herdar da classe "Smartphone"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando aplicativo {nomeApp} no Nokia");
        }
    }
}