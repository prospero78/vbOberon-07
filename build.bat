echo off
cls
chcp 65001
c:\Windows\Microsoft.NET\Framework64\v4.0.30319\vbc.exe .\src\oc.vb
echo press any key . . .
move oc.exe .\bin\oc.exe
