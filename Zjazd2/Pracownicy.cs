using System;

namespace Zjazd2
{
    public class Pracownicy
    {
        public int IDpracownika { get; set; }
        public string Nazwisko { get; set; }
        public string Imię { get; set; }
        public string Stanowisko { get; set; }
        public string ZwrotGrzecznościowy { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public DateTime DataZatrudnienia { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Kraj { get; set; }
        public string TelefonDomowy { get; set; }
        public int Szef { get; set; }

        public override string ToString()
        {
            return $"{nameof(IDpracownika)}: {IDpracownika}, {nameof(Nazwisko)}: {Nazwisko}, {nameof(Imię)}: {Imię}, {nameof(Stanowisko)}: {Stanowisko}, {nameof(ZwrotGrzecznościowy)}: {ZwrotGrzecznościowy}, {nameof(DataUrodzenia)}: {DataUrodzenia}, {nameof(DataZatrudnienia)}: {DataZatrudnienia}, {nameof(Adres)}: {Adres}, {nameof(Miasto)}: {Miasto}, {nameof(KodPocztowy)}: {KodPocztowy}, {nameof(Kraj)}: {Kraj}, {nameof(TelefonDomowy)}: {TelefonDomowy}, {nameof(Szef)}: {Szef}";
        }
    }
}