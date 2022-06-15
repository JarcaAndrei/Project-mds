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
![Imagine Singleton](https://cdn.discordapp.com/attachments/891073655650529351/986684309773631498/Screenshot_from_2022-06-15_20-31-01.png)
