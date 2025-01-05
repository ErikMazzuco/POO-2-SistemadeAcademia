using SQLite;
using System;
namespace Modelos

{
    public class Mensalidade
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        //incluir o aluno dono da mensalidade
        public string Situacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double ValorMensalidade { get; set; } //ou ter a classe plano aonde tem os valores

        public override string ToString()
        {
            return $"{Id}, {Situacao}, {DataInicio}, {DataFim}, {ValorMensalidade}";
        }
    }
}