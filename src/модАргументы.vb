'Модуль парсит параметры командной строки
Public Class клсАрг 'Описывает структуру аргументов
		Public стрАрг As String = ""
		Public стрЗнач As String = ""
	End Class

Public Module модАргументы
		Public стрАрг As String = System.Environment.CommandLine
		Public мАрг() As String = Split(стрАрг, " ")
		Public оПуть As клсАрг	 'Указатель на путь к компилятору
		Public оМодуль As клсАрг 'Указатель на модуль для компиляции
		Public цЧислоАрг As Integer = 0 'Число распознанных опций компилятора
		Public стрРезульт As String = "" ' результат разбора строки параметров

		Public Sub Парам_Получ()
			Static цАргЧисло As Integer = 0
			Dim i As Integer = 0
			оПуть	  = New клсАрг()
			оМодуль = New клсАрг()
			'Перечисление списка параметров
			цАргЧисло = мАрг.Length
			i = 0
			Do While i < цАргЧисло
				If Len(мАрг(i)) > 0 Then
					If i = 0 Then 'Указатель на сам компилятор
						оПуть.стрАрг = "path_oc"
						оПуть.стрЗнач = мАрг(i)
					End If
					If Mid(мАрг(i), 1, 3) = "/m:" Then
						оМодуль.стрАрг = "module"
						оМодуль.стрЗнач = Mid(мАрг(i), 4)
					End If
					цЧислоАрг += 1
				End If
				i += 1
			Loop
			If цЧислоАрг < 2 Then ' аргументов недостаточно
				модКонсоль.Ошибка_Печать("Нет параметров для работы")
				модПомощь.Помощь_Показать()
				стрРезульт = "err"
				Exit Sub
			Else
				Console.WriteLine("Командная строка:  <" + стрАрг + ">")
				Console.WriteLine("Число аргументов: <" + Str(мАрг.Length) + ">")
				Console.WriteLine(оПуть.стрАрг + ": " + оПуть.стрЗнач)
				Console.WriteLine(оМодуль.стрАрг + ":	" + оМодуль.стрЗнач)
			End If
		End Sub
	End Module
