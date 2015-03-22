### Inhaltsverzeichnis

1. Einleitende Bemerkungen
	Inhalt dieses Dokuments soll die genaue Beschreibung des finales Projektstands wiederspiegeln.
	Darüberhinaus soll ein Einblick in die Entwicklung des Projekts gegeben werden sowie über eventuelle Änderungen zum Auftrag informieren.
	

2. Projektauftrag
  1. Projektumfeld
  Das Projekt wurde zum Teil in der Schule und an der dort befindlichen Windows 7 Rechnern mit Visual Studio 2010 durchgeführt. In den Arbeiten außerhalb der Schule wurde Visual Studio 2013 für die Entwicklung genutzt.
  Das Projekt ist mit beiden Visual Studio Versionen benutzbar und benötigt keiner Konvertierung.
  
  Für die Versionskontrolle wurde ein Github Repository genutzt.
  Zum commiten, pullen o.ä wurden die Github Kommandozeile oder die eingebauten Git Werkzeuge in Visual Studio 2013 benutzt.
  
  2. Ist-Zustand
    1. Zielsetzung

    Am Ende dieses Projekts soll es eine Software geben mit der Benutzer unkompliziert und einfach ihre TODO-Listen verwalten können.
    Hauptfunktionen der Software soll es sein neue Kontakte anzulegen, bestehende Kontakte einzusehen/ändern/zulöschen, 
	sowie TODO-Listen zu verwalten und in einer Baumstruktur diesen Todo Listen Termine oder andere Listen zuzordnen.

  3. Aufgabenstellung

  Es soll eine C#-Anwendung entwickelt werden, die eine komfortable Verwaltung von beliebig vielen TODO-Listen ermöglicht.
  Neben der Pflege von Kontaktdaten können beliebig viele TODO-Listen und einzelne Aktivitäten angelegt werden. 
  Alle Daten sollen in einer Datenbank (beispielsweise ACCESS) gespeichert werden. Dazu muss vorher ein geeignetes Datenmodell entwickelt werden.

  4. Prozessschnittstellen
    1. Technische Schnittstellen

    Technische Schnittstellen sind zum einen Systemgegebene wie Windows und dot net 4.
	Schnitstellen die von der Anwendung benutzt werden sind:
	Nhibernate
	SQLite
	Spreadsheetlight

  5. Technisches Umfeld
	Die Software läuft auf allen möglichen System Konfigurationen und benötigt nur eine kleine Menge des Arbeitsspeicher. Einzige Grundvorraussetzungen sind eine Windows und dot net 4 Installation.
	Die benötigten DLLs liegen der Software bei.
  6. Einzuhaltende Standards
    1. Qualitätsmanagement-Standards
	Es wurden Unit Tests entwickelt um schnell die Korrekte Datenhandhabung des Projekts zu bestimmen.Desweiteren wurden nach Entwicklung von Features von allen Entwicklern manuelle Tests durchgeführt.
	Sollte das Programm auf Fehler treffen, wird die Fehlermeldung an den Benutzer weitergegeben, damit man so eine möglichst genaue Beschreibung des Problems durchgeben kann.
    2. Entwicklungsstandards

    Der Quellcode der Anwendung wurde auschließlich mit englischen Begriffen entwickelt. Desweiteren wurde so oft wie möglich Refactored.
	Bevor der bearbeitete Quellcode auf das Github Repository gepushed wurde, wurden die Unit Tests ausgeführt um die Korrekte Funktion des Programms zu gewährleisten.

3. Projektplanung
  1. Vorgehensweise
  2. Projekt- und Zeitplanung
  3. Änderungen gegenüber dem Projektauftrag
  4. Geplante Wirtschaftlichkeit
  5. Qualitätsmanagementmaßnahmen
    1. Zieldefinition
    2. Planung und Kontrolle
    3. Testplanung
4. Projektdurchführung
  1. Phasenbezogener Projektablauf
  2. Gewählte Prinzipien, Methoden, Techniken und Werkzeuge
  Wichtige Werkzeuge die notwendig waren um das Projekt zufriedenstellend zu erledigen waren Visual Studio 2013, die IDE wenn es darum geht Projekte mit der .NET Plattform zu erstellen, sowie Git ein Versionskontrollsystem welches die Zusammenarbeit unglaublich erleichtert.
  Techniken die angewendet wurden, war NHibernate ein Objekt-zu-Relationaler mapper mit den man nicht mehr SQL statements selber schreiben muss sondern diese Logik weg abstrahiert wurde, sowie SQlite eine leichgewichtige SQL Datenbank die keinerlei Konfiguratiuonen bedarf.
  3. Phasenbezogene Ergebnisse
  4. Zeitaufwand
  5. Kontrolle und Steuerung
5. Projektabschluss
  1. Fachlicher Soll- / Ist-Vergleich
  2. Zeitlicher Soll- / Ist-Vergleich
    1. Abweichungen
  3. Wirtschaftlichkeitsbetrachtung
  
  An dieser Stelle soll herausgefunden werden, ob die Erstellung der Software sich auszahlen wird.
  Zur Zeit haben die Mitarbeiter keine Möglichkeit um Termine und Aufgaben sinnvoll aufzuschreiben. Jeder Mitarbeiter braucht täglich durchschnittlich 30 min für die Organisation der Termine. Bei einen Stundensatz von 85 € macht das im Monat für alle 80 Mitarbeiter 65.000 € die eingespart werden könnten wenn die Termin und Aufgabenverwaltung effizienter ablaufen würde.
  Bei einer Projektdauer von 2 Monaten und 2 Mitarbeitern die Vollzeit daran arbeiten belaufen sich die Kosten auf 24.000 €.
  Es ist davon auszugehen, dass die täglich aufgewendete Zeit für die Termin und Aufgabenverwaltung auf 10 min sinken wird. Also kostet es die Firma nur noch 22.666 €. Das Projekt würde sich also bereits nach den ersten Monat rentieren.

  4. Reflexion
    1. Fachliche Reflexion
    2. Persönliche Reflexion / lessons learned
6. Anhang
  * Anhang A: Glossar
  * Anhang B: Abkürzungsverzeichnis
  * Anhang C: Quellenverzeichnis
  * Anhang D: Lasten- und Pflichtenheft
  * Anhang E: Testprotokoll
  * Anhang F: Projektantrag
