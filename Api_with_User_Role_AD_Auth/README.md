# dotnet-6-minimal-api
#Refr- https://www.youtube.com/watch?v=5lRbtDSyjjs
# Use case:- We have API project exposing two endpoints
1. GetAllProduct- > Azure AD Users only in the Manager Group can access that , see the code add attribute for Authorize and Role
2. GetProductById-> Any AD user can access that
-> Install Nuget- Microsoft.Identity.Web , make some code change in program.cs to add Azure AD in services 
Steps:-
1. Create an API with these two actions
2. Create an App registration in AD (WebAPIRegistration)-> Expose as API -> Set Application URI ID
-> Add a scope= api.scope with admin and user consent
-> Create App role-> Manager  (Allowed member Type-> User and Groups)
-> Go to AD-> Enterprise App-> Select App just created(WebAPIRegistration) -> Assign User and groups-> Add User/Group-> Select any user and assign
3.  Add Azure AD in the app setting

4. You can call this API via Web App or Postman or Swagger
Postman
1. Add one more App registration for Postman (PostManAPIRegistration)
-> Authentication -> Add a platform -> SinglePage App -> Redirect URL=https://oauth.pstmn.io/v1/browser-callback 
or https://oauth.pstmn.io/v1/callback and select check box for Access Token and ID token -> Configure
-> 

Now Go to Poastman -> Get Request
-> Authroization -> outh 2.0
-> Add authorization data to -> Request Headers
-> Auth URL -> PostManAPIRegistration -> overview->Endpoints-> copy OAuth 2.0 autho endpoint v2
-> ClientId 
->TenantID
-> Scope= Go to the WebAPIRegistration -> Expose as API -> copy scope 
-> Get New Access Token
->  Send ->Login with Manger User and normal user and check both API GET endpoints


For Src code , you can also refer-
https://github.com/AzureTeachNet/AzureTeachTutorials/tree/Angular_WebAPI_AzureAD_Authentication_Authorization/WebApiAngularAdDemo



