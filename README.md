This program creates folders or files in batch, it also supports a custom syntax for placing the file/folder number wherever the user wants.

It is intended to be used with the NSIS script and a right click context menu. It will not work when launched standalone (it requires argument for destination). I can't remember how to actually build the installer with NSIS though.

Usage instructions:
Right click in an empty space in a folder, and select "Create Multiple Files or Folders"
In the "Name" box you can put the name of your file or folder. Use the radio buttons to select what you wants
If you tick "custom formatting" you will need to have an asterisk(*) somewhere in the "Name" box. All instances of asterisks will be replaced by the file/folder's number.
Click go