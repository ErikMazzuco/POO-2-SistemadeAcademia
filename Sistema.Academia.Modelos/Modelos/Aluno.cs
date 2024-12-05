using SQLite;
using System;

namespace Sistema.Academia.Modelos
{
    public class Aluno
    {
         [PrimaryKey, AutoIncrement]
         public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public DateTime Nascimento { get; set; }

        public override string ToString()
        {
            return $"{Nome}, {Cpf}, {Idade}, {Sexo}, {Nascimento.Date}";
        }
    }



}