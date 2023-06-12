<h1 align="center" id="title">Nokood Assignment</h1>

<p id="description">A web based project that handles trip reservations</p>

  
  
<h2>🧐 Features</h2>

Here're some of the project's best features:

*   Project build on Clean Architecture and DDD standers
*   Logging to SQL Server DB Using Serilog
*   Logs Dashboard using Serilog UI
*   Database Sql Server
*   Microsot Identity to manage the Identity Users
*   Authentication layer handled by JWT and custom Authentication services
*   CurrentUser service to access the current logged user across the project
*   Global Error Handling
*   Trips Seeds by Bogus
*   Reservation RESTFul Apis with pagination and Wrapped returns
*   Default Users seeding from Appsettings.Json
*   Custom Middlewares
*   Apis Validation handled by FluentValidation
*   Data Access Layer handled by EF Core with Code first approach
*   The Arch : https://github.com/amirelkassar/nokood/blob/master/Planning/ProjectPlanning.pdf

<h2>🛠️ Installation Steps:</h2>

<p>1. Clone the project from github</p>

```
git clone https://github.com/amirelkassar/nokood.git
```

<p>2. Or download it as a Zip file from the Clone Button</p>

<p>3. Navigato to "nokood/NokoodAssignment"</p>

<p>4. Open the "NokoodAssignment.sln" in visual studio</p>

<p>5. Navigate to "Presentation/NokoodAssignment.web" project and then to appseetings to update the db connection string</p>

<p>6. The DB connection strings should be updated in 3 places in the appsetting.json file</p>

<p>7. A-Under ConnectionStrings update Default value</p>

<p>8. B-Under ConnectionString update Logs value</p>

<p>9. C-Under Serilog .Args update Connectionstring value</p>

<p>10. Now set the startup project to NokoodAssignment.Web and run the project</p>

<p>11. It'll navigates to swagger dashboard .you can find the users appsettings.json file</p>

<p>12. User any one to call login using account/login API</p>

<p>13. Copy the returned token and press the authorize button on the right cornal</p>

<p>14. Type Bearer[space][the copied token]]</p>

```
Bearer token....
```

<p>15. Enjoy the rest of the Apis</p>
