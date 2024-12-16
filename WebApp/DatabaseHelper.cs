using System;
namespace WebApp;
using SQLite;
using System.IO;
using System;
using Sistema.Academia.Modelos;
using Modelos;

public static class DatabaseHelper
{
    private static SQLiteConnection _database;

    // Método para obter a conexão com o banco de dados
    public static SQLiteConnection GetDatabase()
    {
        if (_database == null)
        {
            // Caminho onde o banco de dados será salvo
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Academia.db");
            
            // Criação da conexão com o banco
            _database = new SQLiteConnection(dbPath);
            
            // Criação da tabela de alunos se não existir
            _database.CreateTable<Aluno>();
            _database.CreateTable<Atendente>();
            _database.CreateTable<Exercicio>();
            _database.CreateTable<FichaTreino>();
            _database.CreateTable<Mensalidade>();
            _database.CreateTable<Usuario>();
        }
            
        return _database;
    }



///-------------------ALUNO--------------------------
    public static void InsertAluno(Aluno aluno)
    {
        var database = GetDatabase();
        database.Insert(aluno);
    }
    public static List<Aluno> GetAllAlunos()
    {
        var database = GetDatabase();
        return database.Table<Aluno>().ToList();
    }

///----------------------------------------------------


    public static void InsertAtendente(Atendente atendente)
    {
         
        var database = GetDatabase();
        database.Insert(atendente);
    }
     public static List<Atendente> GetAllAtendente()
    {
        var database = GetDatabase();
        return database.Table<Atendente>().ToList();
    }




    public static void InsertFichas(FichaTreino FichaTreino)
    {
        var database = GetDatabase();
        database.Insert(FichaTreino);
    }
    public static List<FichaTreino> GetAllFichas()
    {
        var database = GetDatabase();
        return database.Table<FichaTreino>().ToList();
    }



//------------------------USER----------------------
public static void Insertuser(Usuario user)
    {
        var database = GetDatabase();
        database.Insert(user);
    }
    public static List<Usuario> GetAllusers()
    {
        var database = GetDatabase();
        return database.Table<Usuario>().ToList();
    }

//------------------------------------------------------




}
