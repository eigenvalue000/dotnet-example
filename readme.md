# Dotnet Example

## DevOps
main - This is the production branch. This is what is deployed and is what the user can see. The feature/dotnet-example-STAGING
branch is merged into the main branch only after STAGING has been tested.

feature/dotnet-example-DEV - This is the development branch. Merge the current feature or bugfix branch that you are working on
into this branch for the first round of testing to be performed by the developer only.

feature/dotnet-example-UAT - This is the User Acceptance Testing branch. Merge the current feature or bugfix branch that you are
working on into this branch for the second round of testing to be performed by a business analyst and a test user.

feature/dotnet-example-STAGING - This is the pre-deployment branch. After the feature or bugfix has passed testing in UAT,
merge the feature or bugfix branch into STAGING to perform the final round of testing to ensure that the changes
work with the production branch.

feature/name - This is the format for a feature branch. Every feature branch will have a name corresponding to that feature.
For example, if you are working on a new feature that adds a login page to an application, you might name the feature branch
feature/login-page.

bugfix/\<Ticket-Name\>-Description - This is the format for a bugfix branch. Every bugfix branch will have the ticket name followed by
a description of the bug. An example of a bugfix branch would be bugfix/\<TCKT-3896\>-Fix-RoundOff-Errors-In-Calculator where the 
ticket number is \<TCKT-3896\> and the description is Fix-RoundOff-Errors-In-Calculator. Of course, you may want to choose
a shorter description.