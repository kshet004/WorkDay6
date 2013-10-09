Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim currentyear As Integer
        Dim currentpopulation As Double

        currentyear = 2012
        currentpopulation = 7000

        Do While (currentpopulation > 6)
            currentyear = currentyear - 50
            currentpopulation = currentpopulation / 2
        Loop

        MessageBox.Show("The year is " & currentyear, "Error")

    End Sub

End Class
