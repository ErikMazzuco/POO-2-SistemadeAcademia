using System;
namespace Modelos


{
    public class Usuario
    {

        public int Id { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }


        public override string ToString()
            {
                return $"{Id}, {User}, {Senha}";
            }
    }
}
