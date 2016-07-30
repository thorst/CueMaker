#!/usr/bin/python

# Import libs
import os
import sys
from os import walk

# Define path to search
# mypath is a literal string so you dont have to escape path
mypath = r"/home/pi/RetroPie/roms";
recursive = True

# Get input
trues = ("Y", "Yes", "True", "T", True)
if (sys.version_info > (3, 0)):
    #py3 code
    mypath = input("Please enter path to scan ["+mypath+"]:") or mypath
    trecursive = input("Search Recursive? ["+str(recursive)+"]:").strip().title() or recursive
    recursive = trecursive in trues 
else:
    #py2 code
    mypath = raw_input("Please enter path to scan ["+mypath+"]:") or mypath
    trecursive = raw_input("Search Recursive? ["+str(recursive)+"]:").strip().title() or recursive
    recursive = trecursive in trues 

# Define cue file
cue = r"""FILE "%FILENAME%.bin" BINARY
TRACK 01 MODE1/2352
INDEX 01 00:00:00"""

# For each (sub)folder
for (dirpath, dirnames, filenames) in walk(mypath):
    # For each file
    for file in filenames:
        # Get extension
        filename, file_extension = os.path.splitext(file)
        
        # If its a bin
        if file_extension.lower()==".bin":

            # Search for a cue
            if (filename + ".cue").lower() not in (name.lower() for name in filenames):

                # None found, create one
                savePath = os.path.join(dirpath,filename+ ".cue")
                fileHandle = open(savePath, "w")
                fileHandle.write(cue.replace("%FILENAME%", filename))
                fileHandle.close()

                # Output write
                print("Cue created: " + savePath)
    
    # If they dont want to go recursive, get out
    if not recursive:
        break
