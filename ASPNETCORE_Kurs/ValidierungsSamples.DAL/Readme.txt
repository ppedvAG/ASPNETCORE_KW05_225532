DataAccessLayer kann man in einer DLL auslagern. 

Neben DbContext, befindet sich auch das DesignPattern: z.B. Repository und UnitOfWork


Beim Rollout mit Add-Migration + Updata-Database muss geachtet werden:
1.) Ausführbare Webseite muss als Startprojekt markiert sein.
2.) Dll indem sich die DbContext befindet muss in Package Manager Console als Projekt selektiert sein. 