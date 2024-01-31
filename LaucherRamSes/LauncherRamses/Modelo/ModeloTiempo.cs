namespace LauncherRamses.Modelo
{
    public class ModeloTiempo
    {
        public enum Minutos
        {
            Cinco = 5,
            Diez = 10,
            Quince = 15
        }

        public Minutos Valor { get; set; }
    }
}
