### 1. Zielbestimmungen
Musskriterien:
*	Anlegen von Kontakten
*	Anlegen von Terminen
*	Erstellen von Todo Einträgen
*	Grafische Benutzeroberfläche
*	Datenbankanbindung

Wunschkriterien: 
* Skalierung der GUI

### 2. Produkteinsatz
Anwendungsbereiche:
Das Produkt wird in Firmen zur Terminverwaltung eingesetzt.
Zielgruppe:
Alle Angestellten die Termine wahrnehmen müssen.

### 3. Produkt-Umgebung
Software:
Das Clientsystem benötigt ein Windows Betriebssystem mit .net 4.0 Installation.
Hardware:
Die Systemvorrausetzungen gehen nicht über die des Betriebssystem hinaus.
Produktschnittstellen:
Die Anwendung hat eine Schnittstelle zu SQlite, welches die Daten speichert und zur Verfügung stellt.

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
* /F24/ Button „Neuer Eintrag“ öffnet den Erstellungsdialog für einen neuen Eintrag
*	/F25/ Textfeld „Titel“ bedienbar
*	/F26/ Datumsfeld „Startdatum“ bedienbar
*	/F27/ Datumsfeld „Enddatum“ bedienbar
*	/F28/ Datumsfelder öffnen Datetimepicker Dialog
*	/F29/ Zahlenfeld „Priorität“ bedienbar mit Inkrement Buttons (+1 , -1)
*	/F200/ Selektionsfeld „betroffene Kontakte“ bedienbar
*	/F201/ Mehrzeiliges Textfeld "Beschreibung" bedienbar

### 5. Produkt–Daten
* /D10/ Kontaktdaten der angelegten Kontakte
* /D11/ TODO-Listen mit Einträgen und deren Zustand
* /D12/ Einträge mit Start- und Enddaten, Priorität und Beschreibung
* /D13/ Verknüpfung von Einträgen und Kontakten

### 6. Produkt-Leistungen:

### 7. Benutzeroberfläche

### 8. Qualitäts-Zielbestimmungen
Das Produkt muss die angefertigten Testfälle bestehen.

### 9. Globale Testszenarien

### 10. Entwicklungsumgebung
*	Visual Studio 2013 
*	.net 4.0
*	SQlite Version 3.8.8.2
*	Nhibernate 4.0.3

### 11. Ergänzungen
