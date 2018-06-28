echo off
chcp 65001   
cls
echo ===  Компиляция oc.exe  ===
c:\Windows\Microsoft.NET\Framework64\v4.0.30319\vbc.exe .\src\oc.vb /nologo /debug+ /optionexplicit+ /optioninfer+ /optionstrict+ /rootnamespace:oc /platform:x64 /utf8output+  /r:".\bin\модКонсоль.dll" /r:".\bin\модАргументы.dll" /r:".\bin\модФайл.dll" /t:exe /out:".\bin\oc.exe" /optimize+

