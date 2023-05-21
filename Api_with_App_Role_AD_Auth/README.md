# dotnet-6-minimal-api
#Refr- https://www.youtube.com/watch?v=5lRbtDSyjjs
# Use case:- We have API project exposing two endpoints with different roles, there are two apps which call API end points based on its role (Azure AD)
1. GetAllProduct- > Azure AD Apps only in the ReadWrite Role in the WEbAPI app can access that , see the code add attribute for Authorize and Role
2. GetProductById-> Both ReadWrite and ReadOnly Role of WEbAPI app can access
-> Install Nuget- Microsoft.Identity.Web , make some code change in program.cs to add Azure AD in services 
Steps:-
1. Create an API with these two actions
2. Create an App registration in AD (APIapp)-> Expose as API -> Set Application URI ID

-> Create two App role-> 
a. ReadOnlyRole  (Allowed member Type-> Application)
a. ReadWriteRole  (Allowed member Type-> Application)

3.  Add Azure AD in the app setting
For Client Apps
4. Create two App reg in Azure AD
a. ReadOnlyApp -> go to API permission -> Add permission -> My API -> Select APIapp (U created on top) -> Select ReadOnlyRole -> add permission> Click on Grant Admin Consent

b. Similarly for another client App-> Create App reg name=ReadWriteApp and Select ReadWriteRole

4. You can call this API via Web App or Postman or Swagger or any tool
Postman
1. Client App1 (ReadOnlyApp)-Get tenantId, clientId
Open Postman
1. We will get jwt token for this App
->Get Request -> Get endpoint of ReadOnly App (Overview-> Endpoint- V1 endpoint)
-> Body of the request , select radio button= x-www-form...
-> grant_type=client_credentials
-> client_id = 
-> resource= copy the api uri of your APiApp from App reg of ACtive direct (go to APIApp reg-> expose an API-> copy App ID URI)
-> client_secret = (create secret in the ReadOnlyApp)
>  click send and get the token

Now open New Get Request : https:localhost:port/api/Products/GetProductById/1
-> Headers
Add
-> Authorization = Bearer paste the above token -> send

2. Similary for other App roles (ReadWriteApp)

Also try other endpoint to see the accessibility







