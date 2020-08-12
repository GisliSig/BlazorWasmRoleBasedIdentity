# BlazorWasmRoleBasedIdentity
How to use role based authentication with the default Blazor Wasm Identity template

# How to setup
- Open the project
- First, update the database by opening the Package Manager Console, ensure that the Default Project is BlazorWasmRoleBasedIdentity.Server and execute this to initialize the database
EntityFrameworkCore\Update-Database -Context ApplicationDbContext
- Open the database in sql server object explorer, open a new query on the database and run the sql command in the BlazorWasmRoleBasedIdentity.Server/data/seeddata.sql
That adds seed data to the database (if someone can add a migration to it, that would be awesome I have never used EF core and I do not plan on it in the nearest future :) )

# Information
there are two users,
admin@superduperagency.com
user@superduperagency.com

both have the password ASDFasdf1234$

Both users can view secret agents, but only the admin can create or edit secret agents. There are policies and roles used for authentication both on the client and the server side.
