This is a simple app I made to keep track of my farm runs in Borderlands. I designed the app to accomplish just a couple tasks. Here are the key features I added and needed to have.
~~~
- Elapsed timer to keep track of total time spent farming "X"
- Track the name of the weapon/enemy you're currently farming and on what Mayhem level
- The amount of runs you've done
- The amount of drops     
- The amount of drops you've kept
- Automatically calculate the drop percentage based on runs and drops.
- Create a text file to help organize you're data    
- Includes a streamer mode that can be used with OBS to overlay run data in realtime (TEXT GDI+)
- CPU priority checkbox that pushes Borderlands process to High in windows task manager
- No need to focus the program in order to operate it's basic functions such as increase run count etc
- Access the Borderlands drop table created by the community 
~~~
This is all done without having to ever leave the game to manually increase your counter in a notepad or anything. When the program is open and running you can use key bindings (like window's print screen) to handle increase run counter, pausing timer, etc.

# How to use
---
1. UNZIP the program wherever you like (no need to install or anything it is self contained)
2. Click FARM NAME to input you're run name, adjust Mayhem level accordingly.
3. DROP TABLE hyperlink will take you to community google doc with current Borderlands 3 drop information
4. You can toggle STREAMER MODE on or off and it will automatically create a TEMPLOG.TXT. If you're using OBS add the text file to a TEXT GDI+ source and read from file.  
   - All your saves and config will be located in "Current Folder the program is in" + "\Logs\"  you can click the help text towards the bottom to see Keybindings which are.
5. Checking Increase CPU priority will set borderlands process priority to HIGH in windows task manager.  Just incase you need that extra FPS boost.

# Keybinds
---
#### These will work as long as the program is running
~~~
 - END: Starts and Pauses the Timer
 - HOME: Increases Run count
 - PGDOWN: Increases Drop count
 - PGUP: Increases Kept count
~~~
#### These will work when the program has focus
~~~
 - CTRL+S: manually saves current information    
 - CTRL+N: ceate a NEW save log    
 - CTRL+O: opens current active farm log 
~~~

## Requirements
---
- **[>= .NETFramework,Version v4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework)**

- **Currently only for Windows**


### Screenshots
---
![Example1](https://img.itch.zone/aW1hZ2UvNjI2MjkzLzYzOTcyNTUucG5n/original/QGM1cC.png)
![Example2](https://img.itch.zone/aW1hZ2UvNjI2MjkzLzMzMzgwMDgucG5n/original/t3mI7t.png)
