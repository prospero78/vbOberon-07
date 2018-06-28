Public Module модКонсоль ' Цветная консоль компилятора

   Const стрКомпилятор As String = "|   Компилятор Oberon-07   2018 BSD-2  |"
   Const стрСборка     As String = "|   Сборка 0044    2018-06-28   21:56  |"
   Const стрАвтор      As String = "|   ООО ""КБК Техника""           (c)    |"
   Const стрРамка      As String = "+--------------------------------------+"

   Public Sub Инфо_Печать(ByRef стрИнфо As String) ' нужен для вывода информационных сообщений белыми буквами на синем фоне
      Static цветФона As System.ConsoleColor
      цветФона = Console.BackgroundColor
      Console.BackgroundColor = System.ConsoleColor.Blue
      Console.WriteLine(стрИнфо)
      Console.BackgroundColor = цветФона
   End Sub

   Public Sub Ошибка_Печать(ByRef стрОшибка As String) ' нужен для вывода сообщений об ошибках белыми буквами на красном фоне
      Static цветФона As System.ConsoleColor
      Static цветЛит As System.ConsoleColor
      цветФона = Console.BackgroundColor
      цветЛит = Console.ForegroundColor
      Console.BackgroundColor = System.ConsoleColor.Red
      Console.ForegroundColor = System.ConsoleColor.Yellow
      Console.WriteLine(стрОшибка)
      Console.BackgroundColor = цветФона
      Console.ForegroundColor = цветЛит
   End Sub

   Public Sub Сплэш_Печать() 'Первичная надпись при старте компилятора
      Console.WriteLine()
      Console.Write("                 ")
      Инфо_Печать(стрРамка)
      Console.Write("                 ")
      Инфо_Печать(стрКомпилятор)
      Console.Write("                 ")
      Инфо_Печать(стрСборка)
      Console.Write("                 ")
      Инфо_Печать(стрАвтор)
      Console.Write("                 ")
      Инфо_Печать(стрРамка)
      Console.WriteLine()
   End Sub

   End Module
