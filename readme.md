# Development

## Software Development Project

The program was created using the Visual Basic language of Visual Studio with the purpose of acting as an interface for Mach3 and laser control. The Visual Studio project can be found at the following GitHub link:

[GitHub - PSA Laser Program](https://github.com/jorgeedribeiro2001/psa_laser_program)

### Prerequisites

To ensure the proper functioning of the program, an internet connection is necessary to connect to the Azure server. It is not necessary to install "SQL Server 2022 Express" for the database, as integration with Azure can be done through database services offered by the platform. Azure offers various managed database services, such as Azure SQL Database, which can be used to store and manage program data. These services are accessed via an internet connection, eliminating the need to install a local database. Therefore, to use the database with the program, simply ensure a stable internet connection to connect to the Azure server.

After installing Mach3, some additional procedures are necessary to ensure its proper functioning. Follow these steps:

1. Check if ActiveX is running in Windows Services.
2. Locate the Mach3 installation folder and run the file mach3.reg.

This will help configure Mach3 correctly on the system.
3. Run Mach3 as an administrator to ensure all necessary permissions are granted.

It is important to note that Mach3 must always be open in the background for the program to function properly.

You can configure SQL Server to include the database provided in the installation folder named "data server.mdf" as a backup method. This way, if the Azure-hosted database becomes unavailable, you will have an alternative method. If you are working with the project in Visual Studio, simply right-click on this file in the root of the program to access it. Make sure to keep this backup updated to ensure data availability in case of Azure server failures.

Remember that these instructions are general and may vary depending on the operating system and specific versions of the programs.

C. Patoilo, D. Marques, J. Fitas, J. Ribeiro Report PSA Degree

[GitHub - PSA Laser Program](https://github.com/jorgeedribeiro2001/psa_laser_program)

### Identification of Features

This program includes the following features:

1. Manual control mode for the Laser:
    - Allows manual adjustment of equipment settings in real-time.

2. Logging of laser usage hours and users:
    - Stored in a SQL database hosted in the Microsoft Azure cloud.
    - Improves equipment maintenance control and user management.

3. Live video streaming tool:
    - Allows real-time monitoring of the cutting process, facilitating adjustments during work.

4. Database for storing user-generated programs:
    - Allows reloading programs to continue work later, increasing productivity by saving reconfiguration time.

5. History of each user:
    - Allows the administrator to view all steps taken by each worker, enabling quality control of the work performed.

6. Addition of templates with rectangles with rounded corners, slots, and holes:
    - Possibility to create patterns on the x and y axes in the holes, increasing flexibility and agility in project creation.

These features enhance the efficiency and practicality of the Laser control system, resulting in better control and management of work performed, as well as increased productivity and work quality.

C. Patoilo, D. Marques, J. Fitas, J. Ribeiro Report PSA Degree

### Program Organisation / Interface

The program is subdivided into various Forms, and the structure is presented in Figure 2.15.

#### Initial Window

This is the opening window of the program, where the user can authenticate or enter as a guest and select the type of machine they will work with. This window also allows access to the application settings. The visual of the window can be seen in Figure 2.16.

#### Application Settings Window

This window allows managing users, checking user history, and viewing the total usage time of the laser and milling machine.

To access this window, the user needs to authenticate as an administrator. To do this, simply select the username "admin" and the password "123" on the Initial Window (Figure 2.16), and then click "Definitions".

This window presents three pages: "User Definitions", "User History", and "Machine Time Management". On the "User Definitions" page (Figure 2.17), the administrator can add, delete, or modify application users. On the "User History" page (Figure 2.18), the administrator can view the entire history of actions performed by users in the application. On the "Machine Time Management" page (Figure 2.19), the administrator can check the elapsed time for each percentage power interval of the laser and the milling machine's working time, allowing better maintenance control. The administrator also has the option to reset the time at any moment.

#### CNC Milling Machine Control Window

This window (Figure 2.20) was reused from a previous work, with only minor changes, such as adding history records, a timer to record time, and a button to access the video camera.

#### Laser Machine Control Window - Manual Mode

This window (Figure 2.21) provides the user with the ability to move the machine's axes, as well as adjust the laser head motor focus in increments ranging from 0.001 mm to 1 mm. To perform this operation, the user only needs to select the desired increment size and then use a simple click to move in the positive or negative direction.

#### Laser Machine Control Window - Automatic Mode

This window (Figure 2.22) is the most complex of all, as it offers the user a wide range of features. In addition to allowing the loading of programs into Mach3, it also enables the creation of programs from templates.

#### Database Stored Programs Window

This window (Figure 2.23) offers the functionality of viewing stored programs, allowing the user to filter by project, user who performed the storage, and name. Additionally, it is possible to reload these programs into Mach3.

### Database

It was essential to create a database for the program since it is necessary to store user information, their history, and saved programs.

In this project, we chose to use an SQL database hosted on a Microsoft Azure server, allowing the synchronized use of the application on any computer. Additionally, we decided to create a second database that will be attached to the root of the program to ensure an alternative option in case the service is terminated. For this, just change the database path in the Visual Studio project.

We decided to create a functional dependency diagram (DFD) to normalize the database. The DFD is a graphical representation that identifies the dependencies between table attributes, aiding in the normalization process.

Normalization is a set of techniques for organizing data and reducing redundancies. It aims to eliminate anomalies, inconsistencies, and improve data integrity. By creating a DFD, relationships between attributes and the best way to organize tables are identified, avoiding unnecessary data duplication. This results in a more efficient database for storing, retrieving, and manipulating information.

Figure 2.25 represents the functional dependency diagram.

It is noted that the universal relationship R(Username, Time, Name, Password, Comments, Log, NameProgram, Project, Comments, G-Code) is not normalized because the relationship determinants are not candidate keys of the relationship, hence normalization follows.

Figure 2.25: Normalized Functional Dependency Diagram of Sub-Relations

It can be stated that all sub-relations are now normalized. Next, the necessary tables were created: For the first sub-relation, table gcode programs, for the second sub-relation, user history, and the third, table users.

C. Patoilo, D. Marques, J. Fitas, J. Ribeiro Report PSA Degree

## Development
- Software Development Project
- Prerequisites
- Identification of Features
- Program Organisation / Interface
- Database
```
