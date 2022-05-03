
using System;

namespace GestaoCompromissos.Dominio
{
    public class Compromisso
    {
        public Compromisso()
        {

        }

        public Compromisso(string assunto, string local, DateTime data, string horaInicio, string horaTermino)
        {
            Assunto = assunto;
            Local = local;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public int Numero { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }

        public override string ToString()
        {
            return $"Assunto: {Assunto} , " +
                   $"Local: {Local} , " +
                   $"Data: {Data.ToShortDateString()} , " +
                   $"HoraInicio: {HoraInicio} , " +
                   $"HoraTermino: {HoraTermino}";
        }
    }
