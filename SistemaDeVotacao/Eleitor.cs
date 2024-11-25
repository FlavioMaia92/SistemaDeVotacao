namespace VotingManager.Model.Users
{
    public class Eleitor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public bool Votou { get; set; }
    }
}
