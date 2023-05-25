# H5-projekt
Projekt for H5. 
Lavet af Jeppe Kreiberg Munk Marcussen. 

Nye filer uploaded til dette projekt, er lavet i SKP. 

Projektet er web applikation bygget i blazor webframeworket. 

-Skrivet i C#

-Designet i HTML

-Stylet i CSS og Bootstrap

For at bruge dette projekt skal have entity framework installeret i visual studio 2022 og man skal have .NET 7. 

Databasen er en SQL database men koden er koded til at være en lokal database i Visual Studio. Husk at migrate databasen hvis man vil teste det. 

Command: add-migration [IndsætNavn] -context DatabaseContext (Det er vigtigt at have -context paramter da der er two contexts)

command update-database
