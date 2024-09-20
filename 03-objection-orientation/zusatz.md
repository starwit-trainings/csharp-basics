# Beispiel Trainermanagement

## Beschreibung

**Kurse, Trainer und Teinehmer** werden in Excel-Dateien verwaltet. Nun soll ein kleines Hilfsprogramm erstellt werden, welche aus den Excel-Dateien wichtige Informationen herausfiltern soll. Diese Excel-Dateien sollen als CSV-Dateien in eine eigelesen werden.

**Die Liste der Teinehmer hat folgendes Format:**

```
Name des Teilnehmers, Kurs
Max Mustermann, C# 1
Manuela Musterfrau, C# 1
```

**Die Liste der Kurse hat folgendes Format**

```
Kurs, Name des Trainers, Tage
C# 1, Anett Hübner, 16.9.2024 19.9.2024 20.9.2024
C# 2, Markus Zarbock, 16.9.2024 19.9.2024 20.9.2024
C# 3, Anett Hübner, 17.9.2024 18.9.2024
```

Unser Trainings-Manager soll diese Dateien einlegen und in der Lage sein, folgende Antworten auszugeben:

* gib mir an, in welchem Kurs ein bestimmter Teilnehmer (Konsoleneingabe) momentan ist. Verwende zum herausfinden des Kurses, den Namen des Teilnehmers
* gib mir an, welche Kurse grad stattfinden. Gib mir zu den grad stattfindenen Kursen auch die Teilnehmer aus.
* gib mir an, welche Kurse an einem bestimmten Tag (Konsoleneingabe laufen). Der Nutzer soll bei falscher Datumseingabe eine Fehlermeldung bekommen und darauf hingewiesen werden, in welchem Format das Datum eingegeben werden soll.

Welche Funktion aufgerufen wird, soll in der Konsole über eine Zahlenauswahl aufgerufen werden.

Bonus: gestaltet die Zahlenauswahl so, dass es einfach ist, weitere Auswahlmöglichkeiten hinzuzufügen.

## Aufgabe / Vorgehen

* Klassen anlegen
* Attribute definieren
* Methoden definieren
* Relationen hinzufügen (1:n, m:n, n:1, unidirektional oder bidirektional)
* Beispiele für CSV-Dateien erstellen und einlesen
* Methoden implementieren
* Menü im Hauptprogramm erstellen

Hinweis zu Einlesen einer Datei:
```
            StreamReader sr = new StreamReader("C:\\Users\\anett\\git\\csharp-basics\\teilnehmer.csv");
            //Read the first line of text
            string line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                line = sr.ReadLine();
                //write the line to console window
                Console.WriteLine(line);               
            }
            //close the file
            sr.Close();
            Console.ReadLine();
```
