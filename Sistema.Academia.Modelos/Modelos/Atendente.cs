using System;
using SQLite;
namespace Sistema.Academia.Modelos
{
    public class Atendente
    {
        [PrimaryKey, AutoIncrement]
         public int Id { get; set; }
        public string? Nome  { get; set; }
        public string? Cpf  { get; set; }
        public int? Idade { get; set; }
        public int? Salario { get; set; }
        public DateTime? Admissao { get; set; }

        public override string ToString()
        {
            return $"{Id},{Nome}, {Cpf}, {Idade}, {Salario}, {Admissao}";
        }

    }


}