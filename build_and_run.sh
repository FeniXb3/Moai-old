#!/bin/bash
[[ -d Release ]] || mkdir Release
mcs -out:Release/Moai.exe *.cs
wait
mono Release/Moai.exe