using SQLite;

namespace Modelos
{
    public class FichaExercicio
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        // Chaves estrangeiras para relacionar FichaTreino e Exercicio
        public int FichaId { get; set; }
        public int ExercicioId { get; set; }
    }
}
