'
' Проверока комментариев в Visual Basic.Net
'
'
Module main

Sub Main()
	Console.Clear()
	Console.Title = "Компилятор Oberon-07"
   модКонсоль.Сплэш_Печать()
   модАргументы.Парам_Получ()
   If модАргументы.стрРезульт <> "err" Then
         модФайл.Init()  'создаёт необходимые структуры в модуле
         модФайл.Исх_Загрузить()
      End If
End Sub

End Module
