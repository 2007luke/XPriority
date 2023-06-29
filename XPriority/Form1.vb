Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Process As New Process()
        Dim x As Integer = 0
        ListBox1.Items.Clear()
        For Each Process In Process.GetProcesses(My.Computer.Name)
            ListBox1.Items.Add(Process.ProcessName)
            'ListView1.Items(x).SubItems.Add(Process.Id)
            'ListView1.Items(x).SubItems.Add(FormatNumber(Math.Round(Process.PrivateMemorySize64 / 1024), 0) + " K")
            x += 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim itemText As String
        itemText = ListBox1.SelectedItem.ToString

        For Each Process As Process In Process.GetProcessesByName(itemText)

            Process.PriorityClass = ProcessPriorityClass.AboveNormal

        Next
    End Sub
End Class
