// See https://aka.ms/new-console-template for more information
using System;
using System Collections Generic;

namespace Modul4_103022400031
{
    public class KodePaket
    {
        private static Dictionary<string, string> tabelKodePaket = new Dictionary<string, string>()
        {
            {"Basic", "P201"},
            {"Standard", "P202"},
            {"Premium", "P203"},
            {"Unlimited", "P204"},
            {"Gaming", "P205"},
            {"Streaming ", "P206"},
            {"Family", "P207" },
            {"Business", "P208"},
            {"Student", "P209"},
            {"Traveler", "P210"}
        };

        public static string getKodePaket(string namaPaket)
        {
            if (tabelKodePaket.ContainsKey(namaPaket))
            {
                return tabelKodePaket[namaPaket];
            }
            return "Tidak ada paket";
        }
    }
}

