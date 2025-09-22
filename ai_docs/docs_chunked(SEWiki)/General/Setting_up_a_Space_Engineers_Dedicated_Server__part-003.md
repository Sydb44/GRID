
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

## Plugins Management

[![](https://spaceengineers.wiki.gg/images/thumb/4/42/Dedicated_Server_UI_-_Plugins_Management.png/400px-Dedicated_Server_UI_-_Plugins_Management.png?9e2c7e)](https://spaceengineers.wiki.gg/wiki/File:Dedicated_Server_UI_-_Plugins_Management.png)

You can use plugins management for server side plugins setup. Add plugin assembly and then select plugin.

## Remote Management

[![](https://spaceengineers.wiki.gg/images/thumb/2/20/Dedicated_Server_UI_Remote_Managment.png/398px-Dedicated_Server_UI_Remote_Managment.png?f33d3e)](https://spaceengineers.wiki.gg/wiki/File:Dedicated_Server_UI_Remote_Managment.png)

Remote Client helps you with the administering of your server without connecting to it. There is a monitoring tab with information about simulation speed and game play state. Admin tools tab is similar to [Admin Screen](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen") (alt-F10). You can see global server chat, connected, banned or kicked players, list of all grids, characters, floating objects, planets and asteroids.

**Standalone executable** There is standalone version of Remote Client in the Dedicated Server directory. You can start it by executing VRageRemoteClient.exe file. Standalone version has more features like Profiles or Notifications.

[![](https://spaceengineers.wiki.gg/images/thumb/3/36/Standalone_remote_managment.png/398px-Standalone_remote_managment.png?fb9c42)](https://spaceengineers.wiki.gg/wiki/File:Standalone_remote_managment.png)

Standalone remote management

[![](https://spaceengineers.wiki.gg/images/thumb/0/09/Ds-6_orig.png/398px-Ds-6_orig.png?c76eff)](https://spaceengineers.wiki.gg/wiki/File:Ds-6_orig.png)

Standalone Remote Management

## Command Line Tool

You can run SpaceEngineersDedicated.exe with the following arguments:

*   `-console` skips instance selection dialog, dedicated server configuration dialog, and goes directly to console application.
*   `-noconsole` will run without black console window.
*   `-path <path>` will load config and store all files in path specified ("D:\\Whatever\\Something" in example).
*   `-ignorelastsession` ignores last automatic save of the world and uses values from config file.
*   `-session:<worldPath>` overrides last session with this world path.
*   `-maxPlayers <num>` overrides maximum players that can be in session.
*   `-ip <ip>` overrides ip address of dedicated server stored in config file.
*   `-port <num>` overrides port value stored in config file.
*   `-plugin <filepath>` loads a .dll as a plugin for DS (requires a password for game client).
*   `-eos` forces use of EOS network.
*   `-np <key:value>` sets optional network parameters for EOS network only, see [SpaceEngineers-Dedicated.cfg](#SpaceEngineers-Dedicated.cfg) for keys and defaults.
*   `-selectInstance <name>`
*   `-checkAlive`
*   `-start`

The _<param>_ means you're required to replace it by something (don't include < and >), for more on this: [Command Line Interface: Command description syntax](https://en.wikipedia.org/wiki/Command-line_interface#Command_description_syntax).

  
Can also use `taskkill /IM SpaceEngineersDedicated.exe` (not as an argument to anything) to stop the dedicated server correctly, saving the world etc.  
To stop it immediately add argument `/f`, which will kill the server without asking to stop and without saving the world.

## Changing data directory on dedicated server

To change data directory for dedicated server, mklink command may be used.

1.  Make sure 'D:\\Something\\DirForData' exists
2.  Make sure 'C:\\ProgramData\\SpaceEngineersDedicated' does not exists
3.  Run command: mklink /J C:\\ProgramData\\SpaceEngineersDedicated D:\\Something\\DirForData

More information [here](http://msdn.microsoft.com/en-us/library/windows/desktop/aa365006%28v=vs.85%29.aspx) (see Junction)

## Router and Firewall Settings

1.  **Static IP:** If you intend to run a game that people from all over the Internet can connect to, you will need a static public IP address. Your internet service provider should tell you whether you have one or not. Without the static IP address, you will be able to host a dedicated server on your LAN, but people from outside the LAN won’t be able to connect to it.
2.  **Port forwarding:** The game uses UDP protocol to communicate. The default listen port is 27016, but this can be changed in the config tool. In order for people to be able to reach your server, you will have to configure your router to forward all incoming UDP traffic on port 27016 (or any other that you have specified) to the computer where your dedicated server is running.
3.  **Firewall settings:** Make sure to set the firewall on your server computer to allow incoming UDP traffic on the listen port.

Note: If you don't know how to open ports go to [http://portforward.com/](http://portforward.com/)

## How to find your group ID

If you want to find your Group ID, this is a way how to do it:

1.  First you have to be a member of the group
2.  On the group's page (e.g. [http://steamcommunity.com/groups/rps](http://steamcommunity.com/groups/rps)), click "Invite Friends"
3.  On the new page that will open, you can find your Group ID (long number in bold) in the page's URL: [http://steamcommunity.com/id/pikacc/friends/?invitegid=](http://steamcommunity.com/id/pikacc/friends/?invitegid=) **103582791429554934**
