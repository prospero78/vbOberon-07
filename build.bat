echo off
chcp 6501
c:\Windows\Microsoft.NET\Framework64\v4.0.30319\vbc.exe oc.vb
echo press any key . . .
move oc.exe ./bin
