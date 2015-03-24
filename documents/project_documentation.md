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
  
   Die entstehende Anwendung selbst wird in standard Büros zum Einsatz kommen.
  
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
	- Nhibernate
	- SQLite
	- Spreadsheetlight

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

  Als Entwicklungsmodel haben wir das erweiterte Wasserfallmodel genommen. Die einzelnen Phasen sind so klar voneinander getrennt und so abgetrennt.
  
  2. Projekt- und Zeitplanung

  Der Durchführungszeitraum des Projekts beginn Anfang Februar und soll bis zum 23. März abgeschlossen sein. Jede Woche stehen den beiden Programmierern ca. 4 Schulstunden zur Verfügung.
  Die Zeit außerhalb der Berufsschule, die für das Projekt genutzt wird, ist nach eigenem Ermessen.
  
  Als erstes erfolgte die Erstellung des Pflichtenheftes, bei dem sich die Programmierer auf gemeinsame Ziele und herangehensweisen einigten. Aus diesem Entwurf konnten so die Phasen für den Projektablauf gegliedert werden:
  
	Definition(8):

		- Recherche (2)
		- Ist-Analyse (2)
		- Soll-Zustand festlegen (2)
		- Wunschkriterien festelegn (2)
		- Review (1)
	Entwurf (6):

		- Erstellung des Datenbank Schemas (2)
		- Aussuchen der geeigneten Komponenten und Frameworks (2)
		- Erstellen eines GUI Themes (2)
		- Review (1)
	Implementierung (18):

		- Erstellen der Entitäten (2)
		- Erstellen des Mappings (2)
		- Erstellen und Testen des Backends (4)
		- Projektstruktur Modular gestalten (2)
		- Unit Tests erstellen (2)
		- Benutzeroberfläche (6)
		- Review (2)
	Test (4):
	
		- Kriterien bestimmen (1)
		- Test der Anwendung (1)
		- Fehlerbehebung (2)
		- Review (1)
	Deployment:
	
		- Übergabe (1)
  
  3. Änderungen gegenüber dem Projektauftrag

  Es wurden kleine Änderungen an der Benutzung des Projekts vorgenommen, die die Benutzerhandhabung aber insgesamt verbessert.
  
  Die Erzeugung eines neuen Todozweigs ruft keinen Extra Dialog auf. Statdessen wird direkt ein neuer Knoten erzeugt und der Benutzer kann diesen direkt editieren. So erspart man sich einen Dialog und mehrere Clicks.
  
  Die Logik der Kontakterstellung wurde ebenfalls leicht abgeändert, da diese so logischer erscheint. Wählt ein Benutzer aus, dass der neue Kontakt privater Natur ist, werden die Felder für "Firma" und "Abteilung" ausgeblendet.
  Ansonsten entspricht die Anwendung dem Pflichtenheft.

  4. Qualitätsmanagementmaßnahmen
    1. Planung und Kontrolle

	Jede Phase hat einen Review Punkt eingegliedert. In dieser Zeit sollen die Programmierer zusammen kommen um die Arbeit zu Bewerten und zu Kontrollieren.
	
    2. Testplanung

	Durch Unit Tests soll während des Projekts die stetigen Veränderungen getestet werden. Nach Abschluß der Implementierungsphase wird die Anwendung sowie alle Ihre Funktionen in ihrer gesamtheit getestet.

4. Projektdurchführung
  1. Phasenbezogener Projektablauf
  
  In der Defintionsphase wurden Möglichkeiten gesucht, wie man am besten die Ziele der Anwendung umsetzt. Dort entschieden wir uns für die Datenbank zu SQLite, da es eine leichtgewichtige Datenbank ist die keine Installation benötigt.
  Für die Datenbankabstraktion sowie Datenabgreifung haben wir uns für Nhibernate entschlossen. Mit NHibernate wird das Datenbank Schema aus den gegebenen Entitäten und dem dazugehörigen Mappings bestimmt.
  Auch ist kein einziges SQL Statement nötigt, da NHibernate selbst das SQLite aus den Linq Abfragen erzeugt und an die Datenbank schickt.
  
  Die Excel Export Funktion wird mit Hilfe des Framesworks "Spreadsheetlight" ermöglicht. Wir haben uns hier gegen die Verwendung des offiziellen Office Frameworks entschieden, da es eine Installation von Excel vorraussetzt.
  
  In der Entwurfsphase haben wir uns auf folgendes Datenbank Schema geeinigt : 
  [SchemaBild]
  
  Die einzige Änderung zum finalen Schema ist die Ergänzung eines "Done" Felds in der Termin Entität, welches den Status eines Termins verdeutlichen soll.
  Ebenso wurde Beispiele von ähnlichen Software Projekten gesucht, um ein gewisses Gefühl für das spätere Aussehen der Anwendung zu bekommen.
  
  Implementierungsphase:
  
  In der Implementierungsphase stand das Implementieren des Backends an erster Stelle. Es wurden zeurst die Entitäten bestimmt und umgesetzt, danach wurde das Mapping für diese Entitäten erstellt.
  Daraufhin wurde eine Nhibernate Klasse erstellt, die für die Anwendung eine offene Session bereitstellt, mit dessen Hilfe die Datenbank angesprochen werden kann.
  
  Um die Datenoperationen zu erleichtern, wurde für jede Entität ein Repository geschrieben, welches Methoden wie GetbyId,Update und sonstiger CRUD Operationen bereitstellt. Im Zuge des Refactoring wurde eine generische Basisklasse
  geschaffen, welche die allgemeinen CRUD Funktionen für alle ableitetenden Repositories bereitstellt. Die Repositories selbst haben dann nurnoch spezielle Methoden die nur für die dazugehörige Entität relevant sind.
  
  Im Anschluss an das Backend wurde mit der Entwicklung des Frontends begonnen. Im Mittelpunkt steht die Startform, welche ein Hub für alle anderen Forms bildet. In dieser Startform werden auch alle Repositories erzeugt und an die relevanten Forms weitergegeben.
  Somit muss sich eine Form nicht selbst um seine Abhängigkeiten kümmern, sondern werden ihr diese explizit injiziert.
  
  Die Erstellung der Forms für die Kontaktliste und Kontakterzeugung lief dank unserer Vorarbeit im Backend recht unkompliziert.
  Die Implementierung der Todoform hingegen hat eine Herausforderungen dargestellt, die wir aber letztendlich bewältigen konnten. 
  Jeder Knoten der Todo Liste enthält in seinem "Tag" Feld das Objekt, was mit dem Knoten dargestellt werden soll. Zum Beispiel enthält ein TreeNode Objekt, das visuell einen Termin darstellt, in seinem "Tag" Feld die Objektdaten des dazugehörigen Termins.
  Mit dieser Hilfestellung konnten wir somit eine Treeview entwickeln, mit der mehrere Objekttypen darstell- und editierbar sind.
  
  2. Gewählte Prinzipien, Methoden, Techniken und Werkzeuge

  Wichtige Werkzeuge die notwendig waren um das Projekt zufriedenstellend zu erledigen waren Visual Studio 2013, die IDE wenn es darum geht Projekte mit der .NET Plattform zu erstellen, sowie Git ein Versionskontrollsystem welches die Zusammenarbeit unglaublich erleichtert.
  Techniken die angewendet wurden, war NHibernate ein Objekt-zu-Relationaler mapper mit den man nicht mehr SQL statements selber schreiben muss sondern diese Logik weg abstrahiert wurde, sowie SQlite eine leichgewichtige SQL Datenbank die keinerlei Konfiguratiuonen bedarf.
  
  Stetiges Refactoring war ebenfalls eine wichtige Methodik, um den Quellcode klar und verständlich zu gestalten. Ebenso wurde das Projekt in verschiedene Unterprojekte geteilt, um die Verantwortung eines Projektes zu trennen.
  
  3. Phasenbezogene Ergebnisse

	Anfangs waren wir skeptisch ob es sich lohnen würde NHibernate zu benutzen um die Datenbank zu abstrahieren. Doch im Laufe des Projekts stellte sich heraus, dass der Mehraufwand den man am Anfang des Projekts investiert hat sich mehr als auszahlt. Mithilfe von NHibernate waren wir in der Lage viel schneller das eigentliche Programm zu entwickeln, weil wir uns nicht mehr darum kümmern mussten wie man die Datenbank anbindet und wie man die Daten aus und in die Datenbank bekommt.

  4. Kontrolle und Steuerung
  
	Zur Kontrolle dienen die im Anhang B beschriebenen Testfälle.

5. Projektabschluss
  1. Wirtschaftlichkeitsbetrachtung
  
  An dieser Stelle soll herausgefunden werden, ob die Erstellung der Software sich auszahlen wird.
  Zur Zeit haben die Mitarbeiter des Kunden keine Möglichkeit um Termine und Aufgaben sinnvoll aufzuschreiben. Jeder Mitarbeiter braucht täglich durchschnittlich 30 min für die Organisation der Termine. Bei einen Stundensatz von 85 € macht das im Monat für alle 80 Mitarbeiter 65.000 € die sinnvoller eingeplant werden könnten.
  Bei einer Projektdauer von 2 Monaten und 2 Mitarbeitern belaufen sich die Kosten auf 24.000 €.
  Es ist davon auszugehen, dass die täglich aufgewendete Zeit für die Termin und Aufgabenverwaltung auf 10 min sinken wird. Also kostet die Terminverwaltung den Kunden nur noch 22.666 €. Das Projekt würde sich also bereits nach den ersten Monat rentieren.

  2. Reflexion
    1. Persönliche Reflexion / lessons learned

		Peter: Im Laufe des Projekts konnte ich viel Erfahrung sammeln in der C# Programmierung mit der .NET Platform und NHibernate. Für weitere Projekte werden ich aufjedenfall im Hinterkopf behalten wie nützlich es ist, wenn man object-relational mapper benutzt um Teile des Projekts zu abstrahieren. Auch wenn die .NET Platform per se nicht schlecht ist, gefällt sie mir persönlich nicht und ich würde es vorziehen bei zukünftigen Projekten andere Technologien zu verwenden.
		Was ich beim nächsten mal besser machen kann ist die höhere Priorisierung der Dokumentation sowie die Beseitigung der letzen Bugs. Beides erwies sich schwieriger als gedacht.

6. Anhang
  * Anhang A: Lasten- und Pflichtenheft
  * Anhang B: Testfälle
  
	*1. Kontakt erfolgreich hinzufügen*

	Der Benutzer öffnet die "Neuer Kontakt" Form und trägt in alle Eingabefelder die entsprechenden Werte ein. Erwartetes Verhalten ist, dass nachdem auf "Speichern" geklickt wurde eine MessageBox mit den Inhalt "Kontakt erfolgreich gespeichert" auftaucht und alle Eingabefelder wieder leer sind.

	*2. Kontaktinformationen erfolgreich anpassen*

	Der Benutzer öffnet die "Kontakt-Liste" Form, wählt den gewünschten Kontakt aus und passt ihn an. Erwartetes Verhalten ist, dass nach den klicken auf "Änderung Speichern" eine MessageBox mit den Inhalt "Kontakt erfolgreich gespeichert" erscheint und mögliche Änderungen in der ListBox sichbar werden.

	*3. Kontakt erfolgreich löschen*

	Der Benutzer öffnet die "Kontakt-Liste" Form, wählt den gewünschten Kontakt aus und löscht ihn. Erwartetes Verhalten ist, dass nach den klicken auf "Kontakt Löschen" eine MessageBox mit den Inhalt "Kontakt erfolgreich gelöscht" erscheint und der Kontakt aus der ListBox verschwunden ist.

	*4. Todoliste erfolgreich anlegen*

	Der Benutzer öffnet die "TODO-Listen" Form und erstellt eine neue Todoliste mit eigenen Namen. Erwartetes Verhalten ist, dass nach den Klick auf "Neuen Todozweig anlegen" eine neue Todoliste erstellt wird ausser man versucht sie unter einen Termin zu speichern, dann erscheint eine MessageBox mit den Inhalt "Todoliste kann nicht einen Termin untergeordnet werden".

	*5. Termin erfolgreich anlegen*

	Der Benutzer öffnet die "TODO-Listen" Form, wählt eine Todoliste aus, gibt Termindaten ein und speichert der Termin. Erwartetes Verhalten ist, dass nach der Eingabe aller Daten wie z.B. Titel, Startdatum, zugewiesene Kontakte oder Beschreibung und den Klick auf "Neuen Termin speichern" der Termin in der TreeView unter der Todoliste auftaucht.

	*6. Termin erfolgreich anpassen*

	Der Benutzer öffnet die "TODO-Listen" Form, wählt den gewünschten Termin aus und passt ihn an. Erwartetes Verhalten ist, dass nach den Abändern der Daten und den Klick auf "Eintrag aktualisieren" eine MessageBox mit den Inhalt "Der Eintrag wurde erfolgreich aktualisiert" erscheint und mögliche Änderungen in der TreeView sichtbar sind.

	*7. Termine erfolgreich exportieren*

	Der Benutzer öffnet die "TODO-Listen" Form und exportiert erfolgreich eine Excel Datei mit allen Terminen. Erwartetes Verhalten ist, dass nach den Klick auf "Excel Export Termine" ein Speicherort ausgewählt wird, die Datei gespeichert werden kann und beim öffnen alle Termine enthalten sind.
