using System;
namespace Modelos

{
    public class Mensalidade
    {
        public int Id { get; set; }
        public string Situacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double ValorMensalidade { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Situacao}, {DataInicio}, {DataFim}, {ValorMensalidade}";
        }
    }
}