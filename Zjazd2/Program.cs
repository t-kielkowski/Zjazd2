using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Zjazd2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataBase(
                "Data Source = PC-DOM; Initial Catalog = ZNorthwind; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");


            Console.WriteLine($"Dodano {db.AddPracownik(new Pracownicy(){IDpracownika = 10, Nazwisko = "Kowalski", Imię = "Krzychu"})} pracowników");
            
            Console.WriteLine($"Zmodyfikowano {db.UpdatePracownik(new Pracownicy() {Stanowisko = "Szefunio", IDpracownika = 10})} pracowników");

            Console.WriteLine($"Usunięto {db.DeletePracownik(new Pracownicy() {IDpracownika = 10})} pracowników");
            
            foreach (Pracownicy pracownicy in db.GetPracownicy())
            {
                Console.WriteLine(pracownicy);
            }
        }
    }
}