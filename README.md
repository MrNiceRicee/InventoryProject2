# InventoryProject2
Hello! This is my semester project for the Inventory management for Enterprise Applications 1 (C# 1).


I've worked extensively on this project and this is the second iteration.
The basis still stays the same, it is still a game store browser.


Here is what the current functionality is.
Go to (Page) means its a single page transfer.
Open (Page) means it will open another form



Login Page:

-User have to register to log in. Go to Register Page.

-First time registered users, the username is auto populated.

-Once user has an account they are able to log in. Go to Welcome Page.
  
  
  
  
Register Page.

-Works normally like what you would expect.

-IGN (In game name) is what the user will be nicknamed as

-Username is the unique name that the user will be logged in

-Username has to be UNIQUE, cannot exist in the system

-Password has to be entered twice to work

-All the fields have a minimum length requirement

-Only goes to Login Page.

  
  
  
Welcome Page.

 This is the hub of everything
 
-Able to go to profile page. Go to ProfilePage.

-Able to Browse the Store. Open BrowseStore.

-Quick preview of the most popular games (based on units sold)

-Quick preview of the top rated games (based on ratings)

-Double Clicking on the Game Panel will open up the game page. Open GamePage.

-Single Click on Game title will open up the gamepage. Open Game Page.

-Go to Cart, which holds games that the user intends to buy. Open GameCart.

-User can also log out. Go to Login Page

  
  
  
Profile Page

-Hub for Personal information

-Shows user name

-Shows user funds

-Shows user library

-Double Clicking on the Game Panel will open up the game page. Open GamePage.

-Single Click on Game title will open up the gamepage. Open Game Page.

-Single Click on Home will go back to Welcome page. Go to WelcomePage.

  
  
  
Browse Store

-Search bar. Able to search by game title and game studio

-Genre, will search per genre AND genre filtering

-Radio buttons will be if user wants to include or exclude their owned games.

-Search will populate the panel with games

-Double Clicking on the Game Panel will open up the game page. Open GamePage.

-Single Click on Game title will open up the gamepage. Open Game Page.

  
  
  
Game Page

-Shows game Title, game studio and game description

-Game title, Game Studio, Game rating, game sold, game publish date are all randomized.

-Game description is also randomized, and not included in the game class.

-The button is initially labed as "Add to Cart", if user owns the game it changes to "Play Game"

-Play count will show is user owns game, and every play game click it increases.




Game cart

-Shows games that user intends to buy

-Hovering on game will change the color to red

-Double clicking on the game will remove it from the cart

-Buy button will show a confirmation page if user wants to buy the game.




Admin page

-Shows if user is an admin

-has Add, Edit and Remove game modes.

-has add, edit and remove user modes.

-Games are only searchable through gameIDs.

-Users are searchable through usernames.

  
