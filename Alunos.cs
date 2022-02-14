namespace FunçõesParaString
{
    public class Alunos
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public Alunos(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
