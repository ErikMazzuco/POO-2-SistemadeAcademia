using System;

namespace Sistema.Academia.Modelos
{
    public class Atendente
    {
        public string? Nome  { get; set; }
        public string? Cpf  { get; set; }
        public int? Idade { get; set; }
        public int? Salario { get; set; }
        public DateTime? Admissao { get; set; }

        public override string ToString()
        {
            return $"{Nome}, {Cpf}, {Idade}, {Salario}, {Admissao}";
        }

    }


}