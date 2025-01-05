using Sistema.Academia.Modelos;
using SQLite;
using System;
using System.Collections.Generic; // Para ICollection

namespace Modelos
{
    public class FichaTreino
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }

        // Lista de exercícios relacionados
        [Ignore] // Ignora na tabela direta, pois será representado por uma tabela intermediária
        public ICollection<Exercicio> Exercicios { get; set; }

        public FichaTreino()
        {
            Exercicios = new List<Exercicio>();
        }

        public override string ToString()
        {
            return $"{Id}, {Descricao}, {DataCriacao}";
        }
    }
}

