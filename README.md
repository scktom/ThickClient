# ThickClient
This code writed Hungarian language. The program for need a SQL Server run. I wrote TSQL script for every querries in database.

## Adatbázis => Database
This folder included the database file.

### Tables connection
![image](https://github.com/scktom/ThickClient/assets/23421135/6e019313-6945-41b4-b79d-6c7c969462cb)

## App.config
This is file setting the database connection. Will set the database conncection information in connectionString.

## Beadando/Adatbazis/Manager
This is files managing the database connection and Select, Add, Update, Delete functions for the table records.

## Beadando/Adatbazis/Rekordok
This is files represented all class for every once table in database. The HashCode file is return the input string data convert to SHA1 coding.

## Beadando
* All form is the desinged GUI. 
* First need login the database. Belépés => Login, Regisztrálás => Register.
* After the login loaded the database and showing records for selected table.
* The code is calling to rigth Manager and Rerkordok files for functions. Add => Hozzáadás, Update => Szerkesztés. The delete need select record ID and click the Törlés button.

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
