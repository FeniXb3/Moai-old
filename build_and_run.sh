#!/bin/bash
[[ -d Moai/Release ]] || mkdir Moai/Release
mcs -out:Moai/Release/Moai.exe Moai/*.cs
wait
mono Moai/Release/Moai.exe