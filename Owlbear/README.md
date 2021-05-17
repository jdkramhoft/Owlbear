**How I set up local database**

This project uses EF core with SQLite to map and store data locally.
You want to set up migrations for this. First cd Owlbear to get to solution. Then I ran:

`dotnet add package Microsoft.EntityFrameworkCore.Design`

From here on to add new migrations and update the database file to reflect the schema:

`dotnet ef migrations add {name}`

`dotnet ef database update`

**Configuration**

TWITCH_CLIENT_ID, TWITCH_BEARER, and TWITTER_BEARER, etc. found in Utilities.NetUtils need to be set as environment variables.
