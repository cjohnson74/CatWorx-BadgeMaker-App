# CatWorx BadgeMaker App
I used C# to build a console app that creates employee security badges for a rapidly expanding startup, CatWorx. I used the .NET framework to import libraries that let me read and write to the file system, query APIs, and generate images.

# The Fundementals
## Before starting on the CatWorx BadgeMaker App I started with the fundementals:

- Created a "Hello, World" App
- Explored the Program.cs File
  - Learned about Namespaces and the System namespace
- The Main() method being the entry point fo the application and is invoked when the program runs.

### C# Data Types
- Strings
- String Interpolations
- Numbers
- Math Operations
- Math Operators
- Booleans
- Data Type Conversions

### Data Structures
- Dictionaries
  - Populate a Dictionary
- Arrays
  - Declare an Array
- Lists
- Loops
  - For Loop

# CatWorx BadgeMaker Steps
## Storing Employee Data
### Learned how to:
- Interact with users via the command-line interface (CLI).
- Declare and call class methods.
- Create and instantiate a new class.
- Refactor the code along the way to keep the project organized, maintainable, and extensible.
### Approach:
1. Prompted the user and store their employee data.
2. Organized the code using methods with single responsibility.
3. Created a class to hold the employee objects.
4. Printed the employee information.

## Statically Write Data
### Learned how to:
- Use ``static`` to keep code neatly organized.
- Populate a CSV file with ``Util``.
- Manage memory with the ``using`` keyword.
### Approach:
1. Created a ``Util`` class, which is used to populate the CSV file.
2. Created the ``data`` folder to house the CSV file.
3. Imported the ``System.IO`` namespace in order to enable writing to a CSV file.

## Create the Badges
### Learned how to:
- Use pseudocode to break down each step ahead of time and outline your workflow.
- Research and use classes and methods to manipulate images and text.
- Convert objects into more usable data types.
- Designate placement and size of text or images using ``Rectangle``.
- Create a new file with ``Save()`` method.
### Approach:
1. Imported the badge template image file that worked as the background image.
2. Customized each employee's badge by adding information specific to each employee-namely, the employee's name, picture, and id number.
3. Added this new image file to the data folder.

## Download the Data
### Learned how to:
- Request data from an API (Random User Generator API).
- Convert JSON to C# data types.
- Create a new employee for each person that I fetch from the API.
### Approach:
1. Generated employee data by using the Random User Generator API.
2. Pseudocoded the steps.
3. Prepared the ``PeopleFetcher`` class.
4. Called the API.
5. Converted the JSON.
6. Created the employees.
7. Added the finishing touches.

# Reflection
I feel I did a great job implementing and working through dense concepts, syntax, and package installs. The application is now properly situated to receive a response from an API and produce security badges. I have successfully automated the badge creation process, and now CatWorx can spend more time focusing on their core products and services!

### Now that I have reached the end, I want to take a moment and reflect on some of the key tasks I accomplished using C#:
- Set up the development environment by installing a VS Code extension and the .NET Core SDK.
- Used namespaces to organize the code and import libraries from the .NET framework.
- Defined functions and classes by using C# syntax.
- Used the ``System.IO`` namespace to write to a CSV file.
- Imported the ``System.Drawing.Common`` package to use graphics tools to create the badge template background.
- Used the ``WebClient`` class to insert employee data into the badge template.

Although many differenece are evident between C# and JavaScript, there are also many similarities that reduced the learning curve, such as understanding the leveraging the object-oriented approach to programming.

With my newfound familiarity with C#, a new world of development possibilities has emerged. C# is exceptionally versatile. Along with the .NET framework and a few extensions, I can use it to create many different types of apps, imcluding mobile, web, desktop, cloud, and even gaming. By adding C# to my skill set, I have added a modern general-purpose language known for its speed and reliability with a vast community of resources and developers (including the backing of Microsoft!), which ensures a long and successful development existence.
