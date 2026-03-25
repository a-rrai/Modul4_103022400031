// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Collections.Generic;

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

    public class MesinKopi
    {
        public enum CoffeeState { Off, Standby, Brewing, Maintenance };

        private CoffeeState currentState = CoffeeState.Off;

        public void Barista(string kegiatan)
        {
            switch (currentState)
            {
                case CoffeeState.Off:
                    if (kegiatan == "PowerOn")
                    {
                        currentState = CoffeeState.Standby;
                        Console.WriteLine("Mesin Off berubah menjadi Standby");
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                break;
                case CoffeeState.Standby:
                    if (kegiatan == "StartBrew")
                    {
                        currentState = CoffeeState.Brewing;
                        Console.WriteLine("Mesin Standby berubah menjadi Brewing");
                    }
                    else if (kegiatan == "PowerOff")
                    {
                        currentState = CoffeeState.Off;
                        Console.WriteLine("Mesin Standby berubah menjadi Off");
                    }
                    else if (kegiatan == "StartMaintenance")
                    {
                        currentState = CoffeeState.Maintenance;
                        Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                break;
                case CoffeeState.Brewing:
                    if (kegiatan == "FinishBrew")
                    {
                        currentState = CoffeeState.Standby;
                        Console.WriteLine("Mesin Brewing berubah menjadi Standby");
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                break;
                case CoffeeState.Maintenance:
                    if (kegiatan == "FinishMaintenance")
                    {
                        currentState = CoffeeState.Standby;
                        Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                    break;
            }
        }
        public class Utama
        {
            static void Main(string[] args)
            {
                Console.WriteLine("==== Paket ====");
                string nama = "Gaming";
                Console.WriteLine($"Nama Paket: {nama} | KodePaket: {KodePaket.getKodePaket(nama)}");

                Console.WriteLine();

                Console.WriteLine("==== Cafe Tel-U ====");
                MesinKopi mesinKopi = new MesinKopi();

                mesinKopi.Barista("PowerOn");
                mesinKopi.Barista("StartBrew");
                mesinKopi.Barista("FinishBrew");
                mesinKopi.Barista("StartMaintenance");
                mesinKopi.Barista("FinishMaintenance");
                mesinKopi.Barista("PowerOff");
                mesinKopi.Barista("Bayar");

                Console.ReadLine();
            }
        }
    }
}


