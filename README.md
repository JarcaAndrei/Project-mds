# The Way of Death

Un joc in Unity conceput si dezvoltat de echipa: Stafie Calin, Jarca Andrei, Cirlan Daniel, Oporanu Alexandru Stefan si Cordus Luca.

## Agile and Jira
Designul jocului s-a bazat pe modelul de Agile care se aplica si la conceperea marilor aplicatii. Mai exact, am folosit modelul Kanban, distribuind task-uri in mod egal diferitilor membrii ai echipei.

## User Stories and Backlog
Backlogul jocului poate fi accesat [aici](https://projectmds232ljacd.atlassian.net/jira/software/projects/CSJOC/boards/2), iar user stories poate fi vazut in pagina Wiki a Repository-ului, accesand acest [link](https://github.com/JarcaAndrei/Project-mds/wiki/User--Stories).

## Design and Build Tool
The Way of Death este un joc bazat pe mai multe nivele 2D platform game ce a fost inspirat dupa jocurile Super Mario Bros si Jazz Jackrabbit si a fost conceput folosindu-ne de Unity ProBuilder ca un build tool cu C#. Echipa noastra a creat de la 0 cam toate elementele care compun jocul, de la background, platforme, fizica inamicilor, caracterului si a obstacolelor si pana la atribuirea animatiilor in functie de actiunea executata de caracter.

## Source control
Am reusit sa impartim etapele proiectului pe mai multe branchuri si sa facem pull requesturi pentru a vedea ce a facut respectiva persoana pentru a vedea daca sa facem merge pe branchul de main.
* [Commits](https://github.com/JarcaAndrei/Project-mds/commits/main)
* [Branches](https://github.com/JarcaAndrei/Project-mds/branches)
* [Pull Requests](https://github.com/JarcaAndrei/Project-mds/pulls)

## Design Patterns
La SoundManager din folderul Scripts am folosit Singleton pentru ca muzica de background sa ramana de unde a ramas cand trecem la urmatorul nivel.    
<br />![Imagine Singleton](https://cdn.discordapp.com/attachments/891073655650529351/986684309773631498/Screenshot_from_2022-06-15_20-31-01.png)
  
## Bug reporting
Pentru buguri ne-am folosit de Issues din cadrul GitHub pentru a raporta si a rezolva anumite buguri din cadrul proiectului.  
Pentru a vedea bugurile se poate accesa acest [link](https://github.com/JarcaAndrei/Project-mds/issues)  
Am reusit sa le rezolvam pe toate cele care au fost detectate.:)

## Diagrama UML
Pe linkul acesta se gaseste diagrama UML a jocului nostru.  
<br />![Imagine UML](https://github.com/JarcaAndrei/Project-mds/blob/main/data.jpg)

## Refactoring and Code Standards
Pentru Refactoring si Code Standards ne-am folosit de documentatia oficiala de la Unity pentru a rearanja folderele dupa primele etape.  
Initial, le aveam mai dezordonat, dar dupa o privire mai in detaliu pe asupra acestei documentatii am reusit sa le reordonam dupa un anume stil.  
Aniimatiile, audio, backgrounds, scripts, sprites, spre exemplu, au fiecare folder separat.  
<br />![Imagine Foldere](https://cdn.discordapp.com/attachments/891073655650529351/986689361309495316/Screenshot_from_2022-06-15_20-47-19.png)  
<br />![Imagine Hierarchy](https://cdn.discordapp.com/attachments/891073655650529351/986689710653079562/Screenshot_from_2022-06-15_20-52-27.png)

## Demo joc
Pentru a viziona demo-ul jocului, accesati acest [link](https://drive.google.com/file/d/1m8kDnM2Qbs8namWYIMCaKVaQaSIsXJ_s/view?usp=sharing).

## Testing
Pentru testare am facut in mare parte manual, trial and error, cat si, am incercat sa facem cu Unity Test Runner cateva teste generale(gen pentru miscarea caracterului, stanga, dreapta, jumpul, atacul, pentru meniu, cand apasam pe buton daca face tranzitia cum trebuie, cat si selectarea nivelelor).
