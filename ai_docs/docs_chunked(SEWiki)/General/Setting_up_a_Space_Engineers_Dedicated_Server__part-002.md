3.  Click “Continue to server configuration”.
4.  Here you can set variety of options. They work the same way as in the game.
5.  Give your server a name.
6.  Press “Save and start” and you are ready to play.

**Setup as a service:**

1.  Run SpaceEngineersDedicated.exe as Administrator.
2.  Press the “Add new instance” button.
3.  Give your service a name (must be unique system-wide).
4.  Choose the service you just created from the list of server instances.
5.  Set up your game the same way as when running it as a foreground process.
6.  Pay attention to ports in “Server settings” and make sure each port is only used by one server instance.

## User Interface

[![](https://spaceengineers.wiki.gg/images/0/0e/Dedicated_Server_User_Interface.png?d3499f)](https://www.spaceengineersgame.com/uploads/2/1/9/6/21961362/ds-1_orig.png)

Dedicated Server User Interface

### 1\. Server List

*   Here you can see the list of the server instances. There’s always one instance named “Local/Console” and optionally several other instances with custom names.
*   The “Local/Console” instance is run on foreground as a standard application and is always there, while the other instances that the user creates are run in the background as Windows services.

### 2\. Global Configuration

*   Here you can set, whether the game log files should have dates appended to them and whether the server should automatically send the log files to Keen Software House upon crash.

### 3\. Service Management

*   This message is shown when the application is not run with administrator permissions.
*   If you want to create or manage the server as a service you need administrator rights. The button “Run as Admin” will restart the application with administrator rights.

### 4\. Buttons

"Add new instance"

Creates a new instance of the dedicated server as a Windows service.

"Remove instance"

Continue to server configuration - Starts server instance configuration utility for the selected instances.

"Continue to server configuration"

Starts server instance configuration utility for the selected instances.

"Exit"

Closes the configuration utility

## Server Management

[![](https://spaceengineers.wiki.gg/images/thumb/0/03/Dedicated_Server_User_Interface_-_Server_Management.png/400px-Dedicated_Server_User_Interface_-_Server_Management.png?40d261)](https://spaceengineers.wiki.gg/wiki/File:Dedicated_Server_User_Interface_-_Server_Management.png)

Dedicated Server User Interface - Server Management, page 1

**1\. Connect to Steam**

Some of the features of the UI are using Steam to help users to fill correct values. You can connect to Steam to get your friends and mods lists. To be able to use this you have to be logged into Steam on that machine.

**2\. Features**

There are 4 main features on the UI:

*   Server Settings
*   Plugins - Server plugin management
*   Remote Client
*   Console - Console output for running server

**3\. New game / Saved worlds option**

Lets you choose between starting a new world generated from a scenario, or loading a previously saved world.

The previously saved worlds are loaded either from the “AppData\\Roaming\\SpaceEngineersDedicated\\Saves” folder in your home directory (e.g. “C:\\Users\\John.Doe”) or from the “ProgramData\\SpaceEngineersDedicated” folder in the system root. To be able to play a local world that you previously created and saved on the dedicated server, copy it from your save game directory “AppData\\Roaming\\SpaceEngineers\\Saves” to the respective SpaceEngineersDedicated folder.

**4\. Game settings**

Scenario - Can only be chosen for the “New game” option.

Other settings work as you know them from the game with the added bonus that you can set the numerical options to any value you want. (Warning: Values out of the range allowed by the game user interface are not tested and officially unsupported. They can seriously affect the game experience and performance)

**5\. Server settings**

**General**

*   Listen IP - Address of network interface that the server will listen on. This can be set to “0.0.0.0” (which is the default value) to listen on all interfaces, which should work fine in most cases
*   Port – Number of the port that the server will listen on
*   Server name - Name that will be shown in the server list
*   World name - Name of the world, which shows up in the server list
*   Steam Group ID – If set to non-zero value, the dedicated server will only be visible for the given Steam group
*   Password - Password for the server, if you need protected private server
*   Remote API - Remote API for controlling server with VRage Remote Client
    *   Host
    *   Port
    *   Security key
*   Server Description - here the owner can provide a description for visitors to recognise the server
*   Verbose network logging
*   Console Compatibility
*   Network Type
    *   Steam
    *   EOS
*   Enable Chat Anti-spam
    *   Spam Message Timeout
    *   Spam Message Time
    *   Spam Messages Timeout

[![](https://spaceengineers.wiki.gg/images/thumb/d/d4/Space_Engineers_dedicated_server_page_2.png/400px-Space_Engineers_dedicated_server_page_2.png?cebd18)](https://spaceengineers.wiki.gg/wiki/File:Space_Engineers_dedicated_server_page_2.png)

Dedicated Server User Interface - Server Management, page 2

**Users**

You can select Admins, Banned and Reserved slots users on this tab. You can use your friends list or from history of the world.

Note: By “Steam ID” we mean the unique numerical identifier for a Steam account in the 64-bit format. Your Steam ID in this format can be found in the game log after running the game with Steam logged-in to your Steam account (see above) or using external tools like [http://steamid.co/](http://steamid.co/) or [http://steamidfinder.ru/](http://steamidfinder.ru/)

**Mods**

You can select Active Mods on this tab. You can use your Subscribed Mods list from Steam.

**MotD - Message of the Day**

You can fill Message of the Day and Message of the Day URL on this tab. This message will show up to every player, when connected to the server.

You can use variables in the content of the MotD. Use the context menu of the text field to insert a variable of your choice. This variable will be replaced by actual value, when it shows to the player.

**Maintenance**

You can set up Auto Restart and Auto Update features on this tab.

**6\. Configuration and Server controls**

*   Save config - Saves the configuration for the current server instance
*   Edit config - Opens the current instance’s configuration file in a text editor for manual editing
*   Save & start - Saves the current configuration and starts the server
*   Restart – Restarts the server
*   Stop – Stops the server
*   Back to instances - Returns to the screen with the list of server instances
*   Exit - Closes the configuration utility (but not the dedicated server, if it is running as a service)
*   Setup Actions - this feature can Stop/Restart server with delay and chat message on the server.
