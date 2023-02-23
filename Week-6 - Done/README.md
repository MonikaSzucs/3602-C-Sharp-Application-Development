# Class 6 notes

## CRUD
- admin - has full permissions which can delete, set permissions etc has full rights

## ADO.NET
- sqlConnection
- sqlCommand
- SqlDataReader
- Connection String

## Working with SQL Data
- Select
- Order By
- Nullable Columns


## Use single quotes for database

## To search for info in SQL
### Example 1

```
/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [SongId]
      ,[Artist]
      ,[Title]
      ,[Length]
  FROM [TigerDB].[dbo].[Song]
SELECT * from song WHERE Title LIKE '%re%'
```

## List of all actors in table only once
SELECT distinct 

- add USE [TestMonika] at the top of the script the in that database you create you need to right click and refresh

right click table > script table as > then pick any option


## Insert statement

```
USE [Sales]
GO

INSERT INTO [dbo] [Song]
        ([Artist], [Title], [Length])
    VALUES
        ('Artist1', 'Title2', 30)

GO

SELECT * from song
```

### In Class
- we will mostly be doing `SELECT` for us


## UPDATE
```
USE [Sales]
GO

UPDATE [dbo] [Song]
    SET     [Title] = 'New Title',
            [Length] = 100
    WHERE   SongId = 2
GO
```

# When we release
- install packages or powershell scripts we will create
- Whatever data in the database you need to create scripts where I can put the transact sequence  in database scripts 
- whoever deploy out to production they will take the scripts and run it as part of the release


# Tables
- last column is created by or changed by which is in most production table so you know who updated or changed the table

## Connection string
- never in the code 
- could be in config file

## using keyword in sql connection for c#
- it ends it right away nicely too

```
using (sqlConnection....)
```

## using the @
- loses special characters and allows for multiline comment

```
string query = @"SELECT...
                FROM Song
                ORDER BY...."
```

When you say conn.Open()
- the conenction to database is checked
- if you cannot connect to the database based on connection string then it raises an error.
- no code about the conn.Open() doesn't do anything
- It is only exectuted when you call cmd.ExecuteReader()

reader.Read()
- read returns the next row 
- once you ahve the row it will return an array so then you can access them through the index or through the name of the field
- dont use index with number its better with name of field

Index:
```
reader[0]
```
Name of field:
```
reader["Title"]
```

## The reason for IsDBNull(2) 
- you have to check if the second element if it is null 


## Clause
ORDER BY
GROUP BY
WHERE Artist = @artist - the @ is used in the query string

# When you develop the website
- never get the input from the user, you never want to plug in the text quntity or else it will be an SQL injection attack

## Conditional Operator
Null Condition ?
Null Coalescing ??

Instead of writing if and else statements you can just write
```
nameLength = name?.Length ?? 0;
```

## Three tier architecture
1. databse
2. repository (data access layer)
3. UI

## In main
- the command line arguements must be teated in the main
- do a try catch in the main then pass over to the other class as in example ADOexample
- in the catch of the main you can do Console.WriteLine
- errors should not be hard coarded

- log the error in a file in the catch then 
- raise all the errors in the main's catch block. Then it will show an error to the user GUI


## Console.Title = ""
- is the only thing you can switch


## Assignment 5
- due the week after Sunday.


SELECT  ... DISTINCT FROM Products ...
Then based on selection it will dispaly that ocmpany name, city, prov, postal code, hold etc


## 
```
' ' -> looking for char value
```
```
" " --> looking for a string value
```