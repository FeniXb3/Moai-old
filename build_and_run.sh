#!/bin/bash
mcs -out:Moai.exe *.cs
wait
mono Moai.exe