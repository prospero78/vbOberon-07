'Модуль размечает исходник на отдельные куски-слова

'Содержит координату слова в исходном тексте
Public Class тКоорд
   ' Позиция в строке
   Dim _цПоз as integer = -1
   Public ReadOnly Property цПоз as integer
      Get
         return Me._цПоз
      End Get
   End Property
   Public Sub цПоз_Уст(цЗнач_ As Integer)
   If Me._цПоз == -1 Then
      Me._цПоз = цЗнач_
   Else
      модКонсоль.Ошибка_Печать("тКоорд.цПоз_Уст(): позиция уже установлена")
      Environment.Exit(1)
   End Sub
   
End Class


'содержит исходный текст
Public class тИсходник
   Public ReadOnly стрИсходник As String ' исходный текст для экземпляра класса
   Dim стрИсхТекущ As String ' исходный текст для экземпляра класса
   Public Sub New(стр_ As String)
      Me.коорд = New тКоорд()
      Me.стрИсходник = стр_ + vbCrLf + vbCrLf
      Me.тхтИсхТекущ = стр_ + vbCrLf + vbCrLf
      Console.WriteLine("тИсходник.New() " + стр_)
   End Sub
End class


Public Module модРазметка
	Public слова As New тСлова
	Public txtSrc As тИсходник ' исходник разбитый построчно
	' Настраивает модуль перед началом работы
   Public Sub 0. Настроить()
         слова = New тСлова()
         txtSrc = New туИсход(модФайл.txtFileO7 + "  ") ' хвост нужен, чтобы гарантированно не обрезать тег
      End Sub
   ' =================== Разметка =======================
	Public Sub Разметить()
         слова.Нарезать(txtSrc)
      End Sub
	
	Public Sub Разметить()
		' нарезать колбасу из исходника с присвоением координат
		Console.WriteLine("Разметка тегов")
		модСлова.Лексемы_Разметить()
		Console.WriteLine("All tags:" + Str(модСлова.слова.длина))
		Dim луЛекс As туСлово = модСлова.слова.уПервЛекс
		Dim i As Integer = 0
		Do While Not IsNothing(луЛекс.уСлед)
			Console.Write(Str(i) + ")" + луЛекс.стрСлово + vbTab)
			i += 1
			слова.Дальше()
		Loop
		modLexer.Lexer_Run()
		Console.Read()
		Console.WriteLine("_end_")
		End Sub
End Module