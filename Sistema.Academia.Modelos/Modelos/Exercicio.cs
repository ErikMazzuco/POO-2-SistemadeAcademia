using System;
using SQLite;
namespace Modelos

{

    public class Exercicio
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string GrupoMuscular { get; set; }
        public int Series { get; set; }
        public int Repeticoes { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Nome},{GrupoMuscular},{Series},{Repeticoes}, {Descricao} ";
        }



    }
}
