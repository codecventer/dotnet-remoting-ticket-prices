## .NET Remoting Project
This project demonstrates how to create a .NET Remoting application. This project consists of three folders - namely, XmlReader, XmlReaderServer and XmlReaderClient. An XML file (Tickets.xml) that is used by the project is also included.

In short, the XmlReader folder contains the application which will provide the data to be displayed on the user's side. The XmlReader folder contains the server application that allows us to run a local server in order to retrieve data from the previously mentioned application. Lastly, the XmlReaderClient provides the user with a console application whereby chosen data can be returned to and displayed.

## Motivation
The main motivation to publish this project would be to demonstrate the components involved in .NET Remoting and to provide a simple yet informative example. In this project, a user can select which trip prices they would like to view.

## Code style
[![js-standard-style](https://img.shields.io/badge/code%20style-standard-brightgreen.svg?style=flat)](https://github.com/feross/standard)

## Tech/framework used
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)
- [Visual Studio](https://visualstudio.microsoft.com/)

## Getting Started
After cloning the application, ensure that the Tickets.xml file is located on your C: drive or located in a sub-directory in your C: drive, e.g C:\AssessmentsFolder\Tickets.xml - please take note of the file paths used throughout all three applications.

Open the XmlReader application in Visual Studio and press CTRL + F5 to build the project. This will provide you with a .dll file with will be used throughout the rest of the project.

Next, open the XmlReaderServer application. At the top menu, click Project and the Add Reference. Click on Browse and navigate your way to the XmlReader\bin\Debug folder where you will find the XmlReader.dll file - click on add. Now, click on Project then Add Reference once again, this time adding the System.Runtime.Remoting assembly.

Finally, open the XmlReaderClient application. Add the XmlReader.dll and System.Runtime.Remoting assembly as per the XmlReaderServer application.

## How to use?
To run the application, open the XmlReaderServer application and press F5 or CTRL + F5 to run the server.

Next, open the XmlReaderClient application and press F5 or CTRL + F5 to run the application.

Now you can simply follow the prompts and select which trip prices you would like to view.

## Authors
- [Christiaan Venter](https://github.com/codecventer)
