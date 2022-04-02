# anino_exam
anino slot machine exam - Giselle Tan 
- Unity version: 2020.3.30f1
- System setup (main classes, controllers, objects)
1)	Controllers: Spin Controller, betValue script
2)	Objects:  9 symbols, 3x5 tiles on the slot machine, (Spin, Stop, Add Bet, Minus Bet) Buttons, Coin UI sprite, (Bet amount, Win amount, Player Coins) text value
- List of data sources and how to edit them
1)	Integer variables in Sprite Controller script
- a.	betAmt = bet amount from user input
- b.	payoutValue = total payout value based from all 20 lines and 3/4/5 streaks
- c.	totalWins = payout value * bet amount * 20 lines
2)	symbols value after spin button is triggered – will retrieve the name of the Image component under slot tiles 
3)	Payout lines in Sprite Controller script – call checkPayout(5 string combinations of symbols) function under CalculateWinsValue function
4)	Sprites images – can be replace the 9 symbols in the slot tiles object (image1, image2, image3, …)
- **Scalability of System**
- The results will accurately show the total wins once the stop button is triggered
- **Flexibility of System**
- The UI canvas and assets has been configured to be scalable in any screen sizes. Audio has been added to increase user interactions.
- **Use of MVC in the project**
- Constructing first the UI then planning/laying out the logic of the code that will impact some of the UI text/image assets. Once the code has been updated, it will start to retrieve the user input to transform the existing values.
- Possible Future Improvements to the Project:
1)	The reels will be centered in the row 2 or a pop up will show the combination created.
2)	Pop up showing that the player cannot spin due to insufficient amount and whenever players win.
3)	Scenes for menu selection and for tips/tutorial
4)	Improvement in UI sprites
5)	Online data/user login
6)	Bet value will not enter to negative value
7)	Sound effects for winning scene pop up and error scene when insufficient amount is entered, background music while app is open

