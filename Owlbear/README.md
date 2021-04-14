﻿**How to set up local database**

This project uses EF core with SQLite to map and store data locally.
You want to set up migrations for this. First cd Owlbear to get to solution. Then I ran:

`dotnet add package Microsoft.EntityFrameworkCore.Design`

From here on to add new migrations and update the database file to reflect the schema:

`dotnet ef migrations add {name}`

`dotnet ef database update`


