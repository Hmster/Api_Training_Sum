namespace Api_training1.Models
{
    public class Numbers
    {
        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public int Sum => (int)(Number1 + Number2);
    }
}