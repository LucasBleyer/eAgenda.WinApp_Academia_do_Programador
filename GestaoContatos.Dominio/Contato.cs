
namespace GestaoContatos.Dominio
{
    public class Contato
    {
        public Contato()
        {

        }

        public Contato(string nome, string email, string telefone, string empresa, string cargo) : this()
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public override string ToString()
        {
            return $"Número: {Numero} , " +
                   $"Nome: {Nome} , " +
                   $"Email: {Email} , " +
                   $"Telefone: {Telefone} ," +
                   $"Empresa: {Empresa}, " +
                   $"Cargo: {Cargo}";
        }
    }
}
