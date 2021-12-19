using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new("Meine neuen Schuhe sind geil!", true, "Ecitah Pi");

            ImagePost bildPost1 = new("Hier sind sie!", "Ecitah Pi", "https://bilder.de/meineschuhe", true);
            Console.WriteLine("ImagePost ToString Methode : {0}", bildPost1.ToString());

            VideoPost videoPost1 = new("FailVideo", "Ecitah Pi", "https://video.com/failvideo", true, 10);
            Console.WriteLine("ImagePost ToString Methode : {0}", videoPost1.ToString());
            videoPost1.Play();
            Console.WriteLine("Drücke die  Taste um das Video zu stoppen!");
            Console.ReadKey();
            videoPost1.Stop();
            NewMethod();
        }

        private static void NewMethod()
        {
            Console.ReadKey();
        }
    }

    // HERAUSFORDERUNG 
    // Füge eine erbende Klasse "VideoPost" hinzu, mit den Eigenschaften VideoURL und Length
    // Erstelle die benötigten Konstrutoren um ein VideoPost Objekt anzulegen
    // Passe die ToString Methode entsprechend an
    // Erstelle eine Instanz von VideoPost und verwende die ToString Methode darauf.

    // Für Fortgeschrittene:
    // Verwende einen Timer und eine Callback Methode in diesem Beispiel (google wie das geht) ;)
    // Erstelle die Felder die Benötigt werden
    // Füge die Member Methode "Play" hinzu, welche regelmäßig die aktuelle Laufzeit des Videos anzeigen soll
    // Füge eine "Stop" Methode hinzu, welche den "Timer" stoppt und auf die Konsole schreibt "Angehalten bei {0}s" 
    // Spiele das Video nach der Erstellung der Instanz ab und stoppe es, wenn der Benutzer irgendeine Taste drückt.

}

