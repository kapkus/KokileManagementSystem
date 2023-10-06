## KokileManagementSystem
This WinForms desktop application was done for my dad to simplify some work tasks. It operates on local sqlite database file but can be placed on network file server, then you just change database path in program to point to it.

### Key features
* perform CRUD operations on database
* user-friendly interactive interface to read barcode
* automated word document filling out with data
* ability to save preferences through config 

### Database
Since I don't want to share private database of company barcodes, I have created a [python script](https://github.com/kapkus/KokileManagementSystem/blob/main/fill_database.py) which populates database with all possible variations of given pattern. Or you can just download the [release](https://github.com/kapkus/KokileManagementSystem/releases/tag/1.0.0) with filled database.

While I was designing user ability to create database I encountered on a problem that insertion of big amounts of records from schema file was too slow, so i decided to place ready .db file as an embedded resource
