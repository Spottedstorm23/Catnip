# Catnip
 
## Git-/Code - Regeln
* **Code**: englisch (Funktionen, Variablen etc.)
* **Kommentare/ Dokumentation**: deutsch
* **GIT**:
  * erst _pull_, dann _push_
  * _Feature-Branches_ 
    * Name wie das zugehörige Issue 
    * erstellen:
      * `git checkout -b branchname` -> Lokales Erstellen
      * `git push --set-upstream origin branchname` -> Branch in Repo pushen
    * Review durch andere Mitglieder
    * Merge wenn Arbeit am Branch abgeschlossen
  * _Commitmessages_: deutsch/englisch (?)
    * `TASK:` -> abgeschlossene Aufgabe für ein Feature, eventuell mit Beschreibung
    * `WIP:` -> Zwischencommits während der arbeit an einem Feature
    * `FIX:` -> Fehlerbehebung mit eventueller Beschreibung
    * `CLEAN_UP:` -> Aufräumcommits für Mergerequests


## Beschreibung

>Catnip soll ein VR Blumenshop Simulator werden. Darin soll der Spieler sich um seine Pflanzen kümmern und nebenbei Begleiter in Form von Katzen aufnehmen können.

>Um die Pflanzen aufzuziehen, muss der Spieler in bestimmten Zeitintervallen die richtige Aktion auf die Pflanze anwenden. Gelingt dies nicht, verwelkt sie und man muss erneut einen Samen einsetzen. 

>Hat der Spieler eine Pflanze erfolgreich bis zur Reife gepflegt, lässt sich die Blüte ernten und an die Katzen weitergeben. Diese gehen dann im Gegenzug auf ein Abenteuer, um neue Items zu finden, wie beispielsweise neue Samen oder Pflanzendünger.
Andernfalls kann man die Blüten auch in einem Shop verkaufen. Im Gegenzug dafür könnte man neue Items, wie zum Beispiel weitere Blumentöpfe, erwerben.

>Damit die Katze auf Erkundung gehen kann, muss der Spieler sie füttern. Sie legt sich außerdem nach einer gewissen Anzahl an Erkundungen schlafen, um das Pacing des Spiels zu regulieren.

>Des Weiteren soll ein Katzen-Freundschafts-System implementiert werden. Durch bestimmte Interaktionen sollen höhere Freundschaftslevel erreicht werden. Je höher das Level, desto mehr Boni gibt es auf die Erkundungen, wie zum Beispiel eine verringerte Dauer.

>Dem Spieler soll es außerdem möglich sein, den Namen der Katze zu ändern. 

