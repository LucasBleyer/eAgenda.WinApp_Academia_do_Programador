using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompromissos.Dominio
{
    public class Compromisso
    {
        public Compromisso()
        {

        }

        public Compromisso(string assunto, string local, string horaInicio, string horaTermino)
        {
            Assunto = assunto;
            Local = local;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public string Assunto { get; set; }
        public string Local { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }

        public override string ToString()
        {
            return $"Assunto: {Assunto} , " +
                   $"Local: {Local} , " +
                   $"HoraInicio: {HoraInicio} , " +
                   $"HoraTermino: {HoraTermino}";
        }
    }
}
