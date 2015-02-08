### Projektbeschreibung
Aufgrund der vielen Verspätungen bei Terminen, soll eine Softwarelösung entwickelt werden, mit der Mitarbeiter
ihre Termine verwalten können. Hinzu kommt eine Unterteilung in Todo Listen, um ein besseres Filtern von Terminen 
zu ermöglichen.

Die Software soll auf allen möglichen PC Konfigurationen funktionieren. Als einzige Grundvorrausetzung soll eine .net 3.5 Version gegeben sein.


### 1. Zielbestimmungen
Musskriterien:
*	Anlegen von Kontakten
*	Anlegen von Terminen
*	Erstellen von Todo Einträgen
*	Grafische Benutzeroberfläche
*	Datenbankanbindung

Wunschkriterien: 
* Skalierung der GUI
* Export der Termine in Excel

### 2. Produkteinsatz
Anwendungsbereiche:
Das Produkt wird in Firmen oder von Privatpersonen zur Erstellung sowie Verwaltung von TODO-Listen und Terminen verwendet.

Zielgruppe:
Alle Personen die Termine wahrnehmen oder TODO-Listen verwalten müssen.

### 3. Produkt-Umgebung
Software:
Das Clientsystem benötigt ein Windows 7 Betriebssystem oder höher mit .net 4.0 Installation.

Hardware:
Die Systemvorrausetzungen gehen nicht über die des Betriebssystem hinaus.

Produktschnittstellen:
Die Anwendung hat eine Schnittstelle zu SQlite, welches die Daten speichert und zur Verfügung stellt.
Die SQLite Installation wird bei den Programm mitgeliefert, muss also nicht extra installiert werden.

### 4. Produkt–Funktionen
Startfunktionen:
* /F00/ Klick auf TODO-Liste öffnet die TODO-Listenansicht
* /F01/ Klick auf Neuer Kontakt öffnet den Kontaktdialog
* /F02/ Klick auf Kontaktliste öffnet die Kontaktlistenansicht

Kontaktfunktionen:
*	/F10/ Dropdownbox Anrede bedienbar und enthält Einträge (Herr, Frau)
*	/F11/ Textfeld Name bedienbar
*	/F12/ Textfeld Vorname bedienbar
*	/F13/ Textfeld Strasse bedienbar
*	/F14/ Textfeld Ort bedienbar
*	/F15/ Textfeld PLZ bedienbar
*	/F16/ Radiobuttons „privat“ und „geschäftlich“ bedienbar und eines von beidem auswählbar.
*	/F17/ Textfeld Firma bedienbar
*	/F18/ Textfeld Abteilung bedienbar

Todo-Listenfunktionen:
*	/F20/ Darstellung einer Treeview mit entsprechenden TODO-Listen
*	/F21/ Button für neue Todo Einträge bedienbar
*	/F22/ Button für neue Todo Einträge öffnet Todo Erstellungs Dialog
*	/F23/ Button „Löschen“ löscht den selektierten Eintrag und eventuelle Untereinträge
*	/F24/ Button „Neuer Eintrag“ öffnet den Erstellungsdialog für einen neuen Eintrag
*	/F25/ Textfeld „Titel“ bedienbar
*	/F26/ Datumsfeld „Startdatum“ bedienbar
*	/F27/ Datumsfeld „Enddatum“ bedienbar
*	/F28/ Datumsfelder öffnen Datetimepicker Dialog
*	/F29/ Zahlenfeld „Priorität“ bedienbar mit Inkrement Buttons (+1 , -1)
*	/F200/ Selektionsfeld „betroffene Kontakte“ bedienbar
*	/F201/ Mehrzeiliges Textfeld "Beschreibung" bedienbar

Daten-Funktionen:
* /F30/ Schnittstelle zur Datenbank erstellen
* /F31/ Entitäten für Termine und Kontakte erstellen
* /F32/ Datenbankschema aus Entitäten erstellen lassen
* /F32/ Entitäten Mapping festlegen

Export-Funktionen
* /F41/ Button für Export der Termine einbauen
* /F42/ Export Button öffnen einen File Dialog, wo man den Speicherort bestimmt
* /F43/ Export Logik einbauen

### 5. Produkt–Daten
* /D10/ Kontaktdaten der angelegten Kontakte
* /D11/ TODO-Listen mit Einträgen und deren Zustand
* /D12/ Termindaten mit Start- und Enddaten, Priorität und Beschreibung
* /D13/ Verknüpfung von Einträgen und Kontakten

### 6. Produkt-Leistungen:
* /L10/ Zügige Reaktionszeit auf Benutzereingaben, sichergestellt durch die lokale Datenbank SQLite
* /L11/ Daten sollen nach den Beenden des Programms gespeichert bleiben

### 7. Benutzeroberfläche
Die Benutzeroberfläche setzt sich aus verschiedenen WindowsForms zusammen.
Für jede der Hauptfunktionen wird ein eigenes Fenster geöffnet mit speziell für die Funktion angepassten Bedienfeldern.
Die Übersicht der TODO-Listen wird durch eine Treeview realisiert. Dadurch wird eine gute Übersicht über die eigenen Aufgaben garantiert.
Die Treeview bietet die Möglichkeit den Benutzer jederzeit den Ist-Zustand seiner Aufgaben visuell anzuzeigen wodurch eine gute Bedienbarkeit sichergestellt wird.

### 8. Entwicklungsumgebung
*	Visual Studio 2013 
*	.net 4.0
*	SQlite Version 3.8.8.*
*	Nhibernate 4.0.*
*	Spreadsheetlight 3.4
