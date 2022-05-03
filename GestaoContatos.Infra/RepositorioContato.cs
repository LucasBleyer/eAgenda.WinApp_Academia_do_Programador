using GestaoContatos.Dominio;
using System.Collections.Generic;

namespace GestaoContatos.Infra
{
    public class RepositorioContato
    {
        List<Contato> contatos = new List<Contato>();
        private int contador = 0;

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;
            contatos.Add(novoContato);
        }

        public void Editar(Contato contato)
        {
            foreach (Contato c in contatos)
            {
                if (c.Numero == contato.Numero)
                {
                    c.Nome = contato.Nome;
                    c.Email = contato.Email;
                    c.Telefone = contato.Telefone;
                    c.Empresa = contato.Empresa;
                    c.Cargo = contato.Cargo;
                    break;
                }
            }
        }
        public void Excluir(Contato tarefa)
        {
            contatos.Remove(tarefa);
        }
    }
}
