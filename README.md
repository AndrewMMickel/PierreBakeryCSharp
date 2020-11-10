# _Numbers To Words_

#### _Numbers to Words, 10/28/2020_

#### By _Andrew Mickel_

## Description

_This program will ask a user to input a number for the amount of bread they'd like, then do it again for pastries. The inputted number will be transformed and outputted as a price, with discounts on buying multiple loafs of bread (Buy 2 get one free) and pastries (3 for $5)._

## Setup/Installation Requirements

* _Clone this repository._
* _Open repository in your preferred code builder program. (This was built in VS Code)_
* _Check both of the .csproj files to ensure the proper framework under the "PropertyGroup" and "TargetFramework". I am using netcoreapp2.2. Your version may be newer_
* _If the framework does not match above, update the version of your netcoreapp by changing the numbers. For example if you are using netcoreapp 3.1, change netcoreapp2.2 to netcoreapp3.1_
* _In the terminal, cd into the PierreBakery.Tests folder_
* _Type in the terminal "dotnet restore"_
* _To run the program, type cd into the "PierreBakery" directory and type dotnet run in the terminal_
* _The program should now be running_

## SPECS

* _Multiplies the inputted total by 5 (the price of the bread)._
* _Subtracts modulo three of the inputted number, thus finding the amount that is divisible by 3._
* _This number is divided by three, finding the total number of bread slices that can subtracted from the total._
* _The number of slices is subtracted from the total._
* _Multiplies inputted number by 3 (the price of the pastries)._

## Known Bugs

_No known bugs at the this time._

## Support and contact details

_Please check the .csproj files to ensure the proper framework you are running and change if necessary as described in the Setup section_

_Any known issues, please reach out to Andrew Mickel at andrew.m.mickel@gmail.com._

## Technologies Used

* _C#_
* _VS Code_

## License

Copyright (c) 2020, **_Andrew Mickel_**_

This software is licensed under the MIT license.