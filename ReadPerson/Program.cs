/**************************************************************************************************************************
 *  
 *  Übungsnr.:		24/2of2
 *	Programmname:	ReadPerson
 *	Autor:			Christian SCHADLER
 *	Klasse:			4ABIF
 *	Datum:			16.03.2020
 *	
 *	-----------------------------------------------------------------------------------------------------------------------
 *	Verbesserungsmoeglichkeit/en:
 *  -----------------------------------------------------------------------------------------------------------------------
 *  Kurzbeschreibung:
 *	
 *  Das Programm ReadPerson ist Teil der Aufgabe SimpleFileIO
 *  Liest die Daten aus der Datei person.csv, die sich in dem der Solution uebergeordneten Ordner befindet,
 *  Zeile für Zeile in ein String-Array ein und gibt diese dann der Reihe nach auf der Konsole aus.
 **************************************************************************************************************************
 */

using System;
using System.IO;
using System.Text;

namespace ReadPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person ausgeben");
            Console.WriteLine("===============");
            string[] file = File.ReadAllLines("..//..//..//..//..//person.csv");
            for (int i = 0; i < file.Length; i++)
            {
                Console.WriteLine(file[i]);
            }


        }
    }
}






