Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ccount As Integer
        Dim acount As Integer
        Dim ccost As Double
        Dim acost As Double
        Dim dcost As Double
        Dim rate As Double
        Dim tiptax As Integer
        Dim deposit As Double
        Dim totalacost As Double
        Dim totalccost As Double
        Dim totaldessert As Double
        Dim totalfood As Double
        Dim balance As Double
        Dim tiptax1 As Decimal
        Dim tiptax2 As Decimal


        ccount = TextBox1.Text
        acount = TextBox2.Text
        acost = TextBox3.Text
        ccost = acost * 0.6
        dcost = TextBox4.Text
        rate = TextBox5.Text
        tiptax = TextBox6.Text
        deposit = TextBox7.Text


        tiptax1 = tiptax * 0.01
        totalacost = acount * acost
        totalccost = ccount * ccost
        totaldessert = acount + ccount * dcost
        totalfood = totalacost + totalccost + totaldessert
        tiptax2 = totalfood * tiptax1
        balance = (totalfood + rate + tiptax2) - deposit
        Button6.Visible = True
        Button7.Visible = True
        ListBox1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        ListBox1.Items.Add("                                Caswell Catering and Convention Service")
        ListBox1.Items.Add("                                              Final Bill")
        ListBox1.Items.Add("")

        ListBox1.Items.Add("                                           Number of adults:     " & acount)
        ListBox1.Items.Add("                                         Number of children:     " & ccount)
        ListBox1.Items.Add("                             Cost per adult without dessert:     " & Format(acost, "currency"))
        ListBox1.Items.Add("                             Cost per child without dessert:     " & Format(ccost, "currency"))
        ListBox1.Items.Add("                                           Cost per dessert:     " & Format(dcost, "currency"))
        ListBox1.Items.Add("                                                   Room Rate:    " & Format(rate, "currency"))
        ListBox1.Items.Add("                                           Tip and tax rate:     " & Format(tiptax1, "fixed"))
        ListBox1.Items.Add("")

        ListBox1.Items.Add("                                  Toal cost for adult meals:     " & Format(totalacost, "currency"))
        ListBox1.Items.Add("                                  Toal cost for child meals:     " & Format(totalccost, "currency"))
        ListBox1.Items.Add("                                     Toal cost for dessert:      " & Format(totaldessert, "currency"))
        ListBox1.Items.Add("                                     Toal food cost:             " & Format(totalfood, "currency"))
        ListBox1.Items.Add("                                    Plus tip and tax:            " & Format(tiptax2, "currency"))
        ListBox1.Items.Add("                                       Plus room fee:            " & Format(rate, "currency"))
        ListBox1.Items.Add("                                        less deposit:            " & Format(deposit, "currency"))
        ListBox1.Items.Add("                                         Balance due:            " & Format(balance, "currency"))

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ListBox2.Items.Add("------------------------------------------------------------------------------------------------------")
        ListBox2.Items.Add("     Child   Adult   Adult   Dessert     Room    Tip             ")
        ListBox2.Items.Add("Data    Count   Count   Cost    Cost        Rate    Tax     Deposit ")
        ListBox2.Items.Add("------------------------------------------------------------------------------------------------------")
        ListBox2.Items.Add("  1      7      23      12.75   1.00       $ 45.00   18%     $ 50.00")
        ListBox2.Items.Add("  2      3      54      13.50   1.25       $ 65.00   19%     $ 40.00")
        ListBox2.Items.Add("  3     15      24      12.00   0.00       $ 45.00   18%     $ 75.00")
        ListBox2.Items.Add("  4      2       71     11.15   1.50       $  0.00    6%     $  0.00")
        ListBox2.Items.Add("------------------------------------------------------------------------------------------------------")


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Have a Great Day!")

        End
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("The purpose of this program is to Produce Customer's bills." & ControlChars.NewLine & " This pogram will ask for the number of adults" & ControlChars.NewLine & " it will also ask for number of children, after number is entered " & ControlChars.NewLine & " it will then asked for dessert cost, Room Rate, Tip and Tax" & ControlChars.NewLine & " cost as well as Deposit in the same manner.", MsgBoxStyle.Information, "Purpose")
    End Sub



    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim userinput As Integer
        Dim userinput1 As Integer
        Dim userinput2 As Double
        Dim userinput3 As Double
        Dim userinput4 As Double
        Dim userinput5 As Integer
        Dim userinput6 As Double

        GroupBox1.Visible = True
        Button1.Visible = True
        ListBox2.Visible = False


        userinput = InputBox("Enter number of Children")
        TextBox1.Text = userinput

        userinput1 = InputBox("Enter number of Adults")
        TextBox2.Text = userinput1

        userinput2 = InputBox("Enter cost for Adults")
        TextBox3.Text = userinput2

        userinput3 = InputBox("Enter Dessert Cost")
        TextBox4.Text = userinput3

        userinput4 = InputBox("Enter Room Rate")
        TextBox5.Text = userinput4

        userinput5 = InputBox("Enter Tips/Tax")
        TextBox6.Text = userinput5

        userinput6 = InputBox("Enter Deposit Ammount")
        TextBox7.Text = userinput6

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox("To use this program click (Start Order)" & ControlChars.NewLine & "then answer the following questions.", MsgBoxStyle.Information, "Direction")

        Label8.Visible = True
        Button3.Visible = True

    End Sub

   
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Dim userinput As Integer
        Dim userinput1 As Integer
        Dim userinput2 As Double
        Dim userinput3 As Double
        Dim userinput4 As Double
        Dim userinput5 As Integer
        Dim userinput6 As Double

        GroupBox1.Visible = True
        ListBox2.Visible = False


        userinput = InputBox("Enter number of Children")
        TextBox1.Text = userinput

        userinput1 = InputBox("Enter number of Adults")
        TextBox2.Text = userinput1

        userinput2 = InputBox("Enter cost for Adults")
        TextBox3.Text = userinput2

        userinput3 = InputBox("Enter Dessert Cost")
        TextBox4.Text = userinput3

        userinput4 = InputBox("Enter Room Rate")
        TextBox5.Text = userinput4

        userinput5 = InputBox("Enter Tips/Tax")
        TextBox6.Text = userinput5

        userinput6 = InputBox("Enter Deposit Ammount")
        TextBox7.Text = userinput6

        MsgBox("Click Calculate To See Total Bill")

        Button1.Visible = True


    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ListBox1.Items.Clear()
        ListBox2.Visible = True
        Button2.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button1.Visible = False
        ListBox1.Visible = False
        GroupBox1.Visible = False

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ListBox1.Items.Clear()
        ListBox2.Visible = True
        Button2.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button1.Visible = False
        ListBox1.Visible = False
        GroupBox1.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PrintForm1.Print()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
End Class
