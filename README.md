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

## Refactoring and Code Standards
Pentru Refactoring si Code Standards ne-am folosit de documentatia oficiala de la Unity pentru a rearanja folderele dupa primele etape.  
Initial, le aveam mai dezordonat, dar dupa o privire mai in detaliu pe asupra acestei documentatii am reusit sa le reordonam dupa un anume stil.  
Aniimatiile, audio, backgrounds, scripts, sprites, spre exemplu, au fiecare folder separat.  
<br />![Imagine Foldere](https://cdn.discordapp.com/attachments/891073655650529351/986689361309495316/Screenshot_from_2022-06-15_20-47-19.png)  
<br />![Imagine Hierarchy](https://cdn.discordapp.com/attachments/891073655650529351/986689710653079562/Screenshot_from_2022-06-15_20-52-27.png)

## Diagrama UML
Mai jos se gaseste design-ul simplist al jocului nostru.
<br />![Imagine UML](https://viewer.diagrams.net/highlight=0000ff&edit=_blank&layers=1&nav=1&title=data.drawio#R7Vtbe9o4EP01PCafLfmCHxOSdC90N7vpNrv7ZkABNcJyZRGgv34lS8bXBJMglfTbl9Yay3I1Z87M0eAO4Gi5%2BcDidPGRzhAZAGe2GcCrAQAudKD4S1q2yhIOHWWYMzzTk0rDHf6GtLGYtsIzlNUmckoJx2ndOKVJgqa8ZosZo%2Bv6tAdK6m9N4zlqGe6mMWlb7%2FGML5R1CMLS%2FhPC80XxZjeI1J1lXEzWO8kW8YyuKyZ4PYAjRilXV8vNCBHpvMIv9z9v78n4Mfjwyx%2FZ1%2Fivy18%2F%2Ffb5TC12c8gjuy0wlPBXL70Yjuc%2Bvfl9%2Bu%2Fi6ub2OgG3n8dngd4a3xb%2BQjPhPj2kjC%2FonCYxuS6tl4yukhmSqzpiVM4ZU5oKoyuMXxDnWx0L8YpTYVrwJdF31TvlixoQ7dmfu3O6iFZEl4izrXiOIRJz%2FFRfLNZhM9%2FN2z16S7F4DXB0iAOo8dUBDgOnvgSP2Rxx%2FVTVwYculNEVm6LWQuKisp%2FSlON3AJau%2Bz3AfKAJ1zffjK34t%2BcuemGT2qUKk5ecAcwEC6hj7Dv9guVYGOu3PcVkpbdwMeWUtYAXuSqVl6slURPg5RNiHIu8OI4niNzSDHNMEzFlQjmny8qEC4Ln8gaXEVCFmq44wQka7TK18xz%2Bcim0eUUEtAHbFI6u%2Bd0rxusypxd0W1TTeROfKsQ1cA5FAvjfmW3AsUA3QzTywety7rFoBKIXwUto8o7R6pEdoWMEVi%2BswxqGx4KVTr7IlAMcIrOXWkwt%2FREleKUM6jK3vlwoq0Gtw6USCesF5ugujXNXr4UqroMaZ6nKfg94I4PDVgYE0K%2BnQADO%2FVYSdH2%2FIwsWxgOyoBhqpx%2FCK7dVnz6hDW%2BRjUtjzasMZfhbPMknSKpIMmWlU2Ndk6bCg4h1FKslns3yFJvK4Mq36V8O%2FCuJDyZkRIksggWzM87oI2oY63S3hCqMGoLCaxc2r6OwAWN1DbYgHICASLgm4mIuLzTRlFW8ZXfjnQOdJ2lGeaylkWOSzmF43iD0sE3nsAN6aAp6CKxURbTB%2FG%2F5%2BLnQUGr4j15NXl9tqoPtMyiZLqUg6FtKoZFS2jxouL5dhQRflrcGFJIbnBSsgRmF1Ej3rmcZ1tAyxcNXUdxiLBwd4sAD53DoR2Ek%2FvB9D9YBj4bnbuAF0BmGIQgCzyr8RfjXinsjHkrwJZJ7xHB3Wj5%2BtfTcOm9Ax%2Fl%2FlzItNQDC%2FUJpjJ7ydrr7o4olY3gPG3h3aKOhTW3kWdZGlazpnlTWNNQ6aOqd6Gitg574%2Fph6p%2BDDXr3jGdI7QUPvOJYb5p4dwXO6uA7NiJxGpy%2By3MAt9v%2F%2BhEyDEKHTFjJu1CVkzB372027Z4UM%2BF%2FIHPi7lVtv8oQdwtWqkIFd%2Fb1mhiQEpxk6HdY0Ts1RX84YE%2F%2FQ28%2BZPyldVrX%2FhNW8HHxdyS9Hch%2BeKS5cyOlBuilvlhRr0y5L8SPKBmAkl43X6mK6QNPHVKXd8rXqgSklBE05ljSUjoqJ8N775m6l2BqIuqChXUA77Lq426yFx4u6ruN7d9SBNvxdMfSAmYwFLpmdx0%2F%2ByVXNkoeZipeZsPQKotckEKNQwgaWHVnYDTt%2BOYuMnSe7BEyPBHIAlN1IyTsTupGJ49RBax4Je%2Fd8zHUBvLbXLJwmhBPZVvVTHbgz7DqqclA2B%2FLRtjq6RQyL%2FcvkXPlJy9zhxCu%2B89x3OAFmvugLG81Cv2eT%2FYKxeFuZpuvVwe8pI0yteNwDbQ%2B1rhMH7Jc4UIKWctsPOYNOPisEjc8sXdCVy62qwaLHb%2B1XleqPKqfVHuzNfe%2Bt3H8bYiegpH6EEg0bKXDXB6rWaNdujbb%2BbZ8dYplp5LW%2BP%2BrZdz%2B0VgZRvQ%2FiRzZq5fDYtRLkO%2Boid%2FXgLcfvrKr6obufyMcS22JY%2FrcZBXb5n4%2Fg9X8%3D)
