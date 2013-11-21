namespace AbonnementsimuleringKlient
{
    public class Konto
    {
        public int EconomicAftalenummer { get; set; }
        public string EconomicBrugernavn { get; set; }
        public string EconomicKodeord { get; set; }
        public IBrugerDTO AbosimBruger { get; set; }
        
        public Konto()
        {
        }
    }  
}