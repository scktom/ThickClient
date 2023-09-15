# ThickClient
This code was written in Hungarian. The program needs a SQL Server to run. I wrote TSQL script for every SQL query in database.

## Adatbázis => Database
This folder includes the database file.

### Tables connection
![image](https://github.com/scktom/ThickClient/assets/23421135/6e019313-6945-41b4-b79d-6c7c969462cb)

## App.config
This file will set the database connection information in connectionString.

## Beadando/Adatbazis/Manager
These files manage the database connection and Select, Add, Update, Delete functions for the table records.

## Beadando/Adatbazis/Rekordok
These files represent all classes for every table in database. The HashCode file returns the input string data converted to SHA1 coding.

## Beadando
* All forms in this folder are for the desinged GUI.
* First the user needs to login to the database. Belépés => Login, Regisztrálás => Register.
* After login, the database will load and show the records for the selected table.
* The code will call the appropriate Manager and Rerkordok files for functions. Add => Hozzáadás, Update => Szerkesztés. To delete, the user needs to select record ID and click the Törlés button.

### Login
![image](https://github.com/scktom/ThickClient/assets/23421135/991d762c-6966-4e4c-ad49-f0238a79d258)

### Register
![image](https://github.com/scktom/ThickClient/assets/23421135/04133806-1e9d-4645-9c47-a38480f4e79f)

### Main window after login
![image](https://github.com/scktom/ThickClient/assets/23421135/b26d1cc0-6079-48ad-bae0-631a813b8790)

### Selected table
![image](https://github.com/scktom/ThickClient/assets/23421135/294815f1-1b05-4ff3-b4f2-0a9406524234)

### Add new record
![image](https://github.com/scktom/ThickClient/assets/23421135/0d666656-7d17-4090-95b2-894e4038148b)

### Update record
![image](https://github.com/scktom/ThickClient/assets/23421135/e75028a7-3bad-4608-906b-184dae3b5c23)

### Delete record
![image](https://github.com/scktom/ThickClient/assets/23421135/93075555-23ab-49f5-b6e0-81ef6ac4b202)
