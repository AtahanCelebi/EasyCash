namespace EasycashIdentityProject.EntityLayer.Concrete 
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessTyoe { get; set; }

        public decimal Amount { get; set; }

        public DateTime ProcessDate { get; set; }
        
    }
}