Refer- https://www.youtube.com/watch?v=2cWIxn-LOp8
1. Add one Web App .net core 6.0
2. Add Microsoft.identity.Web.UI
3. Program.cs
add some code for adding ad auth and calling Authentication in the middleware pipeline
4. Create Azure AD app registration with Redirect URI: https://localhost:7286/signin-oidc, also in authentication section, select two checkboxes for 
Access Token and ID token
5. Mention its detail in the Appsetting.json AzureAD {}

Run the App

or follow
https://www.youtube.com/watch?v=bn1ljitiCrE for .net 5.0 Web App