'Модуль выполняет необходимые операции с файлами
Imports System.IO ' для File

Public Module модФайл
   Dim оМодуль As клсАрг
   Public стрИсходник As String = "" ' содержимое исходного файла Оберон-07
   Public sRes As String = ""
   Public Sub Init()
      оМодуль = модАргументы.оМодуль
   End Sub

   Public Sub Исх_Загрузить()
      If Not File.Exists(оМодуль.стрЗнач) Then
         модКонсоль.Ошибка_Печать("Файл " + оМодуль.стрЗнач + " не существует или ошибка в имени")
         sRes = "err"
         Exit Sub
      Else
         ' Open the stream and read it back. 
         Using sr As StreamReader = File.OpenText(оМодуль.стрЗнач)
            стрИсходник = sr.ReadToEnd()
         End Using
      End If
   End Sub
End Module