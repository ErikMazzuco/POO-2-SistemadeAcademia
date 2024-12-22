using System;
using SQLite;
namespace Modelos

{

    public class Exercicio
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Descricao}";
        }



    }
}
