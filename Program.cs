using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindegy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
//1. feladat   
            int[] szamok = new int[100];
//2. feladat
            int darab = 0;
            while (darab < 100)
            {
                szamok[darab] = rnd.Next(1000, 10000);
                if(szamok[darab] % 5 == 0)
                {
                    darab++;
                }
            }
            //3. feladat
            int sum = 0;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    //4. feladat
                    if ((j * 10 + i) % 7 == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                        Console.Write(szamok[(j * 10) + i] + " ");
                        Console.ResetColor();
                    //5. feladat
                    sum += szamok[j * 10 + i];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"A tomb elemeinek osszege: {sum}");
            int kozeEsoElemekOsszege = 0;
            int kozeEsoElemekDarabszama = 0;
            for(int i = 0; i < szamok.Length; i++)
            {
                if(4000 <= szamok[i] && szamok[i] < 5000)
                {
                    kozeEsoElemekOsszege += szamok[i];
                    kozeEsoElemekDarabszama++;
                }
            }
           // Console.WriteLine(kozeEsoElemekOsszege);
          //  Console.WriteLine(kozeEsoElemekDarabszama);
            float kozeEsoElemekAtlaga = kozeEsoElemekOsszege / kozeEsoElemekDarabszama;
            Console.WriteLine($"A 4000 es 5000 koze eso elemek atlaga: {kozeEsoElemekAtlaga}");
            darab = 0;
            while(szamok[darab] % 65 != 0)
            {
                darab++;
            }
            Console.WriteLine($"Az elso 65-tel oszthato szam: {szamok[darab]}, az indexe pedig: {darab}");
            int harmassalKezdodo = 0;
            for(int i = 0; i < szamok.Length; i++)
            {
                // itt az alapötletem a pythonos // használata lett volna, de elvileg ennek nincs C#-os megfelelője, úgyhogy
                // parasztba megírtam a saját változatomat, nem valami szép, úgyhogy ezzel kapcsolatban ha tudsz valami szebbet/jobbat
                // akkor az érdekelne. stringé alakítás és left függvény is volt a fejemben, de az nem tetszett kinézetre
                int maradek = szamok[i] % 1000;
                int levagott = szamok[i] - maradek;
                if(levagott / 1000 == 3)
                {
                    harmassalKezdodo++;
                }
            }
            Console.WriteLine($"Harmassal kezdodo szamok: {harmassalKezdodo}db.");
            darab = 0;
            while(szamok[darab] < 5000) //csak hogy ne mindig a 0ás indexet adja vissza
            {
                darab++;
            }
            Console.WriteLine($"Az elso elfogadhato fizetes indexe: {darab}");
            int[] kerek100as = new int[100]; // nem tudom, hogy lehet-e itt a 100 helyére változót beírni, ha jól emlékszem C-ben nem lehetett
            //úgyhogy 100eleműre csináltam. szóval a kérdés, hogy ilyen van-e C#-ban, vagy lehet-e: int[] kerek100as = new int[darabszam]; ahol a
            //darab a 100al oszthatók száma lenne
            darab = 0;
            for(int i = 0; i < szamok.Length; i++)
            {
                if(szamok[i] % 100 == 0)
                {
                    kerek100as[darab] = szamok[i];
                    darab++;
                }
            }
            darab = 0;
            while(kerek100as[darab] != 0)
            {
                if((kerek100as[darab] / 100) % 11 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                Console.Write(kerek100as[darab]);
                Console.ResetColor();
                Console.Write(" ");
                darab++;
            }
            int szuletesiev = 1997;
            switch (szuletesiev % 5)
            {
                case 0:
                    break;
                case 1:
                    szuletesiev = szuletesiev - 1;
                    break;
                case 2:
                    szuletesiev = szuletesiev - 2;
                    break;
                case 3:
                    szuletesiev = szuletesiev + 2;
                    break;
                case 4:
                    szuletesiev = szuletesiev + 1;
                    break;
            }
            Console.WriteLine(); //sortörés
            bool szerepele = false;
           // szamok[3] = 1995; teszt
            for(int i = 0; i < szamok.Length; i++)
            {
                if(szuletesiev == szamok[i])
                {
                    szerepele = true;
                }
            }
            if (szerepele)
            {
                Console.WriteLine("Szerepel a tombben.");
            }
            else
            {
                Console.WriteLine("Nem szerepel a tombben.");
            }
            //Még itt a végére annyit, hogy említetted multkor, hogy nem nagyon kérdez senki a Gáboron meg a Tamáson kívül,
            //én azért nem szoktam, mert nem igazán tudok beszélni mostanság, meg hol tudok jönni órára hol nem megánéleti gondok miatt.
            //Abban sem voltam biztos, hogy ma ezt meg fogom tudni csinálni.



        }
    }
}
