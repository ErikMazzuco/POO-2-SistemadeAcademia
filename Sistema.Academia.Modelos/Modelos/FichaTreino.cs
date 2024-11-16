using System;
namespace Modelos
{
    public class FichaTreino
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Descricao}";
        }
    }
}
