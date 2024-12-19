using Sistema.Academia.Modelos;
using SQLite;
using System;
namespace Modelos
{
    public class FichaTreino
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { get; set; }

        //public Aluno aluno { get; set; }

        public DateTime DataCriacao { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Descricao}, {DataCriacao}";
        }
    }
}
