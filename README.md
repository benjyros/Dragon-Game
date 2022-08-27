# Dragon-Game
Groupproject about the Snake-Game.

# Lern-Bericht
Dragongame - Shayanthan Ravindran, Julian Hartmann (https://github.com/JHartmann-ims), Benjamin Peterhans

## Einleitung

Für dieses Projekt konnten wir zum Abschluss ein eigenes Projekt erstellen. Es hatte zwar ein paar Ideen in einem Dokument, bei dem wir uns etwas orientieren konnten. Wir haben schlussendlich entschieden, uns mit etwas Neuem auseinanderzusetzen, und zwar über Setup-Files. ES ging also hauptsächlich um das Erstellen einer Setup-Datei, sodass man das Spiel installieren kann. Für das haben wir ein Snake-Game implementiert.

## Ziele

Ziele:

- Der Porgrammcode sollte mit Kommentaren beschmückt sein

- Im Projekt sollen wir mit einer neuen "System.IO"-Klasse arbeiten

- Die Bestenliste soll überarbeitet werden, sodass es jetzt funktioniert

- Als Gruppe sollten die Arbeitspakete gut verteilt sein

- Die Gruppe soll ihre Arbeitspakete rechtzeitig abgeben

## Produkt
### Beschreibung

Bei Starten des Spiels kommt man in ein Interface, bei dem man sich einloggen bzw. registrieren muss. Nach dem Einloggen erhält man zuerst eine Instruktion, bei der man nachschauen kann, wie das Spiel und auch bestimmte Spielmodi funktionieren. Man hat drei verschiedene Optionen, wie schnell das Spiel laufen soll. Es gibt ausserdem auch eine Option, bei der man die Hintergrundfarbe des Spiels einstellen kann. 
Das Design des Spiels haben wir mit einem Drachenthema belegt - deshalb auch unser Spielname "Blackdragon". Im Grunde genommen verhält sich das Spiel wie das bekannte Snake-Game. Die Bewegungen erfolgen durch die Pfeiltasten. Das Ziel ist es, so viel Punkte einzusammeln - pro "Drachenei" erhält man 100 Punkte. Falls man genug Punkte geholt hat, um in die Bestenliste zu gelangen, wird der Benutzername in der jeweiligen Kategorie (nach Geschwindigkeit kategorisiert) angezeigt. 
An sich ist das Spiel simpel zu verstehen, aber wir möchten gerne in Zukunft auch noch andere Versionen dieses Spiels freigeben, bei der die Spielmodi hinzugefügt werden oder bei der auch andere Einstellungen und Features verfügbar sind.

### Demo

[![IMAGE ALT TEXT](http://img.youtube.com/vi/hwE9_iscyeM/0.jpg)](http://www.youtube.com/watch?v=hwE9_iscyeM "Dragon-Game")

## Das Projekt
### Dateisystem

![alt text](https://github.com/benjyros/Dragon-Game/blob/main/Images/dateisystem.PNG.png?raw=true)

### Dateisystem erklärt

Unter dem Ordner "Application Folder" werden alle nötigen Dateien des Spiels eingefügt. Hier in diesem Fall sind die .EXE-Datei selbst und die .EXE.config-Datei relevant. Die ico-Datei ist dafür da, um dem Spiel ein Bild zu geben. Unter dem Ordner "User's Desktop" wird eine Verknüpfung der .EXE-Datei eingefügt, damit das Spiel auch auf dem Desktop des Benutzers erreichbar ist. Ausserdem ist der Ordner "User's Programs Menu" auch sehr relevant, da das Spiel dort auf die Dateien zugreift. Diese Ordner und Dateien müssen in diesen Ordner eingefügt werden, sonst würde das Spiel nicht funktionieren. Ein kleiner Hinweis: Dass das Spiel richtig funktioniert, sollte das Spiel als Administrator ausgeführt werden. Der Grund dafür ist der Zugriff auf die Dateien.

### System.IO

Zu der neuen System.IO-Klasse war es eigentlich ganz einfach zu programmieren. Es war lediglich nur eine Linie von Programmcode, die das alles ausmachte. Mit "Path.GetFullPath(Environment.CurrentDirectory)" kann man einen bestimmten Ordner ausfindig machen, ohne eine absolute Pfadangabe anzugeben.

### Beispiel System.IO

```cs
string baseRout = "";
string saves = "";
string settings = "";

public user_login()
{
    InitializeComponent();
    Get_Routes();
}

private void Get_Routes();
{
    baseRoute = Path.GetFullPath(Environment.CurrentDirectory);
    saves = baseRoute + @"\saves";
    settings = baseRoute + @\"settings";
}
```
### Bestenliste erklärt

Hier unten sieht man den Code, mit dem wir das Problem mit der Bestenliste gelöst haben. Mit einem zweiten Array, neben der .txt-Datei, haben wir die sortierte Bestenliste abgespeichert. Die höheren erzielten Punkte rutschen immer um eins nach oben, wenn die Punktzahl z.B. der zweiten Zeile grösser ist als die erste Zeile.

## Code Bestenliste

```cs
private void Set_HighscoreList()
{
    //Reading highscore-list file (.txt)
    string[] zeilen = File.ReadAllLines(highscoreListSlow);
    stringArray = new string[zeilen.Length + 1];

    //Copying the textfile into an array
    for (int i = 0; i < zeilen.Length; i++)
    {
        stringArray[i + 1] = zeilen[i];
    }
    
    //Sorting the array (if the upper value is smaller than the lower value of the array they change position)
    for (int j = 0; j < zeilen.Length; j++)
    {
        for (int k = 1; k < zeilen.Length; k++)
        {
            if (Convert.ToInt32(stringArray[k].Split(';')[1]) < Convert.ToInt32(stringArray[k + 1].Split(';')[1]))
            {
                string temp = stringArray[k];
                stringArray[k] = stringArray[k + 1];
                stringArray[k + 1] = temp;
            }
        }
    }

    label_Assign();
}
```

## Verifikation

Z1 wird mit dem Screenshot der Bestenliste und dem Code unter der Zip-Datei validiert.

Z2 wird Abschnitt über "System.IO" validiert.

Z3 wird mit dem Abschnitt über "Bestenliste" validiert.

Z4 und Z5 wird mit dem Dokument "BlackDragons_1500_final.docx" validiert.

# Reflektion

## Lernatelier

Ich muss sagen, dass die ersten Projekte sehr rasch ins Programmieren eingeführt wurden. In den IPA-Lektionen hatten wir gerade die grundlegenden Sachen über das Programmieren einer Website durchgenommen, während wir hier praktisch mittendrin angefangen haben. Ich denke aber, dass das nützlich war, da auch das Arbeitstempo deutlich schneller und auch anspruchsvoller war.

In Allgemeinen haben mir alle Projekte bis jetzt gefallen. Ich habe viel Neues gelernt, was ich jetzt, aber auch später anwenden kann. Meiner Meinung nach wird das Portfolio etwas zu überbewertet. Die Noten ergaben sich ja nur aus den Portfolios und nicht unbedingt aus dem Projekt selbst. Ich würde deshalb in Zukunft auch die Projekte in die Note einbeziehen, sodass die vergebenen Noten etwas fairer sind. Ansonsten war dieses Schuljahr im Lernatelier sehr lehrreich und auch spannend.

## Programmierprojekt

In Bezug auf das letzte Programmierprojekt (Lernatelier Modul 404) hatten wir Probleme bei der Effizienz und den Abgabezeiten. Wir haben dort auch vermutet, dass die Zeitplanung ein Problem sein könnte.
In diesem Projekt haben wir uns wieder in der gleichen Gruppe eingefunden, weshalb wir auch die vorherigen Probleme als Gruppe verbessern konnten. Ich kann zu dem nur eines sagen: Wir hatten hier gar keine Probleme mit der Effizienz, der Zeitplanung und den Abgabezeiten. Der Grund dafür waren sicher die Arbeitspakete. Im letzten Projekt hatten wir auf jeden Fall nicht so viele Arbeitspakete erstellt, wie in diesem. Deshalb haben wir auf die strikten, aber auch strukturierten Abgabezeiten geachtet, damit wir gut die Zeit einteilen konnten.

Jeder von unserer Gruppe hat seine Arbeitspakete aus der Dokumentation zugeteilt bekommen. Julian war für das Programmieren des Spiels, Shayan für das Design und ich für die System.IO-Klasse und die Bestenliste zuständig. Was wir aber eigentlich im Projekt erreichen wollten, war eine Setup-Datei, sodass man das Spiel herunterladen und installieren kann. Dafür waren wir gegen Ende des Projektes alle zuständig. Jeder von uns hat sich mit einem bestimmten Thema des Erstellens einer Setup-Datei befasst. Somit haben wir das Wissen über diese verschiedenen Themen vertieft. Wir haben uns dann für eine bessere Methode entschlossen, welche wir dann auch für dieses Projekt benutzt haben.

Ich hatte bei meinem Abteil keine grossen Probleme mit der neuen System.IO-Klasse wie auch mit der Bestenliste. Bei der Bestenliste war es etwas aufwendiger als bei der neuen Klasse, da ja bei dieser Klasse nur eine Zeile verändert werden musste. Für die Bestenliste brauchte ich länger, um auf eine Lösung zu kommen, zum Beispiel wie man logisch eine Sortierung einer Bestenliste aus .txt-Dateien implementieren kann.

Da wir mit der System.IO-Klasse die neue Funktion ausprobieren wollten, hatten wir einen OneDrive-Ordner, mit dem wir alle programmiert hatten. Jedoch ergab sich daraus ein Problem: Wenn mehrere Personen gleichzeitig am Spiel programmiert hatten, kam es dazu, dass vielleicht das Projekt nicht richtig abgespeichert werden konnte und somit Fortschritte bzw. Dateien verloren gingen. Aus diesem Grund möchte ich bei der nächsten Gruppenarbeit darauf achten, dass jeder einzelne einen eigenen Ordner zum Programmieren hat.
