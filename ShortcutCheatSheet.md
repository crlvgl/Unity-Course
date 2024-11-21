# Shortcut/Command Cheat Sheet für VS Code, git & Unity (probably)

## VS Code

Strg + C -> Kopieren <br>
Strg + V -> Einfügen <br>
Strg + A -> Alles markieren <br>
Strg + X -> Ausschneiden <br>
Strg + Z -> Rückgängig <br>
Strg + Y -> Wiederholen <br>
Strg + S -> Speichern <br>
Strg + F -> Suchen <br>
Strg + H -> Suchen und Ersetzen <br>
Strg + P -> Datei öffnen <br>
Strg + N -> Neue Datei <br>
Strg + O -> Datei öffnen <br>
Strg + W -> Datei schließen <br>
Strg + Shift + P -> Command Palette <br>
Strg + Shift + N -> Neues Fenster <br>
Strg + Shift + T -> Letzte Datei wieder öffnen <br>
Strg + Shift + V -> Vorschau anzeigen <br>
Strg + Shift + S -> Speichern unter <br>
Strg + Shift + F -> In Dateien suchen <br>
Strg + Shift + H -> In Dateien suchen und ersetzen <br>
Strg + Shift + L -> Alle Vorkommen auswählen (erstellt Multi-Cursor) <br>
Strg + Shift + X -> Extensions <br>
Strg + Shift + C -> neues Terminal (CMD) <br>
Strg + # -> Zeile kommentieren/entkommentieren <br>
Alt + Pfeil hoch/runter -> Zeile nach oben/unten verschieben <br>
Alt + Shift + Pfeil hoch/runter -> Zeile kopieren und einfügen <br>
Alt + Shift + Pfeil links/rechts -> Text markieren <br>
Alt + Strg + Pfeil hoch/runter -> Multi-Cursor <br>
Shift + Pfeiltaste -> Text markieren <br>
Strg + Shift + Pfeiltaste -> Text markieren (bis zum nächsten Wort) <br>
Strg + Shift + Alt + Pfeiltaste -> Text markieren mit Multi-Cursor <br>
Strg + Backspace -> Löscht Text bis zum Anfang des Wortes <br>
Strg + Entf -> Löscht Text bis zum Ende des Wortes <br>
Strg + Shift + Backspace -> Löscht Text bis zum Anfang der Zeile <br>
Strg + Shift + Entf -> Löscht Text bis zum Ende der Zeile <br><br>
**Strg + K + Strg + S -> Keyboard Shortcuts Editor (mit Liste aller Shortcuts)** <br>

### GitHub Copilot
Strg + I -> Ask Copilot (in line) <br>
Strg + Shift + I -> Insert Copilot <br>
Strg + . -> Insert Copilot <br>
während Copilot Vorschläge macht: <br>
- Strg + reche Pfeiltaste -> Wort für Wort einfügen <br>
- Tab -> Vorschlag übernehmen <br>

In Copilot Chat: <br>
- Wenn Zeile markiert, wird Zeile als Referenz übergeben <br>
- Ansonsten wird das geöffnete Dokument als Referenz übergeben <br>
- (für Debugging also die Zeile mit dem Fehler markieren) <br>

### Markdown
Strg + K + V -> Markdown Preview im Splitscreen <br>
Strg + K + Strg + V -> Markdown Preview in neuem Tab <br>
Strg + B -> Fett <br>
Strg + I -> Kursiv <br>
ansonsten: https://www.markdownguide.org/basic-syntax/ <br>

## git in CMD
git clone [URL] -> Repository herunterladen <br>
git status -> Status anzeigen <br>
git add -A -> Alle Dateien hinzufügen <br>
git add --all -> Alle Dateien hinzufügen <br>
git add [Dateiname] -> Datei hinzufügen <br>
git commit -m "[Nachricht]" -> Commit erstellen <br>
git push -> Änderungen hochladen <br>
git pull -> Änderungen herunterladen <br>
git stash -> Änderungen verstecken <br>
git stash list -> Liste der versteckten Änderungen anzeigen <br>
git stash show -> Versteckte Änderungen anzeigen <br>
git stash apply -> Versteckte Änderungen wieder hinzufügen <br>
git stash pop -> Versteckte Änderungen wieder hinzufügen und aus stash löschen <br>
git revert [Commit-ID] -> Commit rückgängig machen <br>
git revert HEAD1 -> Letzten Commit rückgängig machen <br>
git reset --hard HEAD -> Änderungen verwerfen <br>
_bitte nicht git reset --hard HEAD1 verwenden, da dieser den letzten Commit löscht, anstelle von einem neuen Commit in der git history zu erstellen_ <br>

### Workflow:
1. git status -> Status anzeigen <br>
2. _Projekt bearbeiten_ <br>
3. git status -> Status anzeigen <br>
4. git add -A -> Alle Dateien hinzufügen oder <br> git add [Dateiname] -> Datei hinzufügen <br>
5. [optional] Schritt 4 wiederholen <br>
6. git commit -m "[Nachricht]" -> Commit erstellen <br>
7. git push -> Änderungen hochladen <br>

Setzt voraus, dass keine Konflikte auftreten. <br>
Konflikte müssen manuell gelöst werden. Geht am besten, indem vor dem commit mit _git stash_ die Dateien versteckt werden, dann der neue commit mit _git pull_ heruntergeladen wird. Danach können die Änderungen mit _git stash list_ gelistet, _git stash show_ betrachtet und _git stash apply_/_git stash pop_ wieder dem working branch hinzugefügt werden. <br><br>
Weiterführende Infos: https://git-scm.com/docs <br>

## Unity
Verwende ich selbst so gut wie nicht, drum kann ich euch da nicht so viel empfehlen. <br>
Listen und Infos findet ihr aber [hier](https://docs.unity3d.com/Manual/UnityHotkeys.html) für die Shortcuts und [hier](https://docs.unity3d.com/Manual/ShortcutsManager.html) für den Shortcut Manager. <br>
