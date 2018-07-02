'
' Проверка комментариев в Visual Basic.Net
'
'
Module main

Sub Main()
	Console.Clear()
	Console.Title = "Компилятор Oberon-07"
	модКонсоль.Сплэш_Печать()
	модАргументы.Парам_Получ()
	If модАргументы.стрРезульт <> "err" Then
			модФайл.Init()	 'создаёт необходимые структуры в модуле
			модФайл.Исх_Загрузить()
		End If
	If модФайл.sRes <> "err" Then
			модРазметка.Разметить()
			'Console.Write("Для просмотра результата запустите ""out.exe"" ")
		End If
	Console.Read()
End Sub

End Module
