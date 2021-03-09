using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Zjazd2
{
    public class DataBase
    {
        private IDbConnection _connection;

        public DataBase(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public IEnumerable<Pracownicy> GetPracownicy()
        {
            return _connection.Query<Pracownicy>("SELECT * FROM Pracownicy");
        }

        public int AddPracownik(Pracownicy pracownicy)
        {
            return _connection.Execute(
                "insert into Pracownicy(IDpracownika, Nazwisko, Imię) values (@IDpracownika, @Nazwisko, @Imię)",
                new {pracownicy.IDpracownika, pracownicy.Nazwisko, pracownicy.Imię});
        }

        public int UpdatePracownik(Pracownicy pracownicy)
        {
            return _connection.Execute("update Pracownicy set Stanowisko=@stanowisko where IDpracownika=@id",
                new {stanowisko = pracownicy.Stanowisko, id = pracownicy.IDpracownika});
        }
        
        public int DeletePracownik(Pracownicy pracownicy)
        {
            return _connection.Execute("delete from Pracownicy where IDpracownika=@id",
                new {id = pracownicy.IDpracownika});
        }
        
    }
}