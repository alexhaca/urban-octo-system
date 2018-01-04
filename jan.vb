' Caesars Pizza Program
        ' Alex Haagensen Casas
        ' 04/01/2018

        Dim Choice As String
        Dim Again As String
        Dim TopCount As Integer
        TopCount = 0
        Dim Index As Integer
        Index = 0
        Dim ShopOpen As Boolean
        ShopOpen = True
        Dim EndOrder As Boolean
        EndOrder = False

        'I think I realised this next list of declarations wasn't necessary
        Dim Cheese As Integer
        Cheese = 10
        Dim Ham As Integer
        Ham = 10
        Dim Pepperoni As Integer
        Pepperoni = 10
        Dim Pineapple As Integer
        Pineapple = 10
        Dim Mushroom As Integer
        Mushroom = 10
        Dim CherryTomatoes As Integer
        CherryTomatoes = 10
        Dim Chicken As Integer
        Chicken = 10
        Dim Peppers As Integer
        Peppers = 10
        Dim Olives As Integer
        Olives = 10
        Dim Jalapenos As Integer
        Jalapenos = 10

        Dim ToppingsArray(Cheese, Ham, Pepperoni, Pineapple, Mushroom, CherryTomatoes, Chicken, Peppers, Olives, Jalapenos) As Integer

        ToppingsArray(Cheese) = 0
        ToppingsArray(Ham) = 1
        ToppingsArray(Pepperoni) = 2
        ToppingsArray(Pineapple) = 3
        ToppingsArray(Mushroom) = 4
        ToppingsArray(CherryTomatoes) = 5
        ToppingsArray(Chicken) = 6
        ToppingsArray(Peppers) = 7
        ToppingsArray(Olives) = 8
        ToppingsArray(Jalapenos) = 9



        Console.WriteLine("Welcome to the pizza order program. Your options of toppings are listed with their identification numbers to the left of them, and how much of it we have left to the right.")
        Console.WriteLine("For example, if you wish to add Pepperoni to your order, it will be displayed as: '2 Pepperoni 10'. Enter ID '2' and make sure we have it in stock by looking at the number to the right")

        Console.WriteLine(ToppingsArray(0))
        Console.WriteLine(ToppingsArray(1))
        Console.WriteLine(ToppingsArray(2))
        Console.WriteLine(ToppingsArray(3))
        Console.WriteLine(ToppingsArray(4))
        Console.WriteLine(ToppingsArray(5))
        Console.WriteLine(ToppingsArray(6))
        Console.WriteLine(ToppingsArray(7))
        Console.WriteLine(ToppingsArray(8))
        Console.WriteLine(ToppingsArray(9))

        Dim Order As IDataRecord
        Dim Number As Integer
        Dim Base As String
        Dim Topping(0, 1, 2, 4) Of String









        Console.ReadLine()
