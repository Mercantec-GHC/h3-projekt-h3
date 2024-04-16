### H3-Smart-Kommunikationsplatform - Water my pot
 
Her skal alt omkring jeres projekt v�re.
 
Projekt kan findes her: ["Notion link"](https://mercantec.notion.site/Projekt-H3-IoT-og-Serverside-med-Christoffer-og-Kasper-e8980638a8584a72b0c7d718252dbba4?pvs=4)
 
 
Dette er mappe strukturen (i er velkommen til at �ndre i den, men s� opdater dette dokument)
 
Fjern denne forklarende tekst men behold mappe struktur og skriv jeres projekt pitch. Andet info m� i ogs� meget gerne have her
 
- Dokumentation
	- setup.md
	- bruger_manual.md
	-- Flowcharts
	-- ER diragrammer
	- Kravsspecificationer.md
	- Case_beskrivelse.md
- Arduino
	-- Biblioteker
	-- Sketches
- Database
- Backend (api)
- Frontend
- Tests
.gitignore
README.md
 
### Projekt pitch:
 
"Vi vil lave et vandingssystem, som man b�de kan benytte manuelt, men ogs� automatisk. Hvor brugeren v�lger hvilken plante som er tilknyttet hvilken sensor, s� vil en ventil �bne og kunne vande planterne, som g�r brug af disse hardwarekomponenter: arduino 2+ moisture, heat sensor and a motor. Vores m�l er at udvikle en l�sning, der kan vande planter, ved at integrere et interaktivt system, der kan indsamle og reagere p� data. For at opn� dette, t�nker vi at anvende  programmeringssprog c#(blazor og asp .net api), databaser mysql(heidi). til at opbygge systemet, som vil tillade os at bruge teknologien, til hvis man nu glemmer at vande dine planter, at det bliver gjort automatisk n�r fugtigheden er for lav, at den s� selv vil vande planten, hvor vi har motor som �bner og lukker en ventil, som er forbundet til en vand container.
 
Vores system vil kunne interagere med brugerne gennem et dashboard, der viser 1+ graf og hvor man kan v�lge dage og man skal kunne tilf�je en ny plante. om den skal v�re i auto eller manuel tilstand og hvor meget vand der er i containeren], hvilket giver brugerne mulighed for at  v�lge en plante fra en drop down eller de kan selv skrive en plante ind og hvor meget vand den skal bruge. De kan se en graf over fugtigheden og rumtemperaturen.
 