using GestaoCompromissos.Dominio;
using System.Collections.Generic;


namespace GestaoCompromissos.Infra
{
    public class RepositorioCompromisso
    {
        List<Compromisso> compromissos = new List<Compromisso>();
        private int contador = 0;

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;    
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            novoCompromisso.Numero = ++contador;
            compromissos.Add(novoCompromisso);
        }

        public void Editar(Compromisso compromisso)
        {
            foreach(Compromisso c in compromissos)
            {
                if(c.Numero == compromisso.Numero)
                {
                    c.Assunto = compromisso.Assunto;
                    c.Local = compromisso.Local;
                    c.HoraInicio = c.HoraInicio;
                    c.HoraTermino = c.HoraTermino;
                    break;
                }
            }
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
        }
    }
}
