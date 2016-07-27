#!/usr/bin/python

import os
from os import walk

dirpath = "C:\Users\thorst02\Desktop\binsearch"
f = []
for (dirpath, dirnames, filenames) in walk(mypath):
    f.extend(filenames)
    break