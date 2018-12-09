Imports info.lundin.math
Imports System.IO
Imports System.Text
Imports System.Data.OleDb

Public Class Form1
    Dim a, b, h, ec, cs, q, w As Single
    Dim g As Graphics
    Dim integral(500), err(500), suma As Single

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        g = Graf.CreateGraphics
        q = tbRangoInicial.Text
        Do While q <= tbRangoFinal.Text
            Graf.Series(0).Points.AddXY(Math.Round(q, 1), f(q))
            q = q + 0.1
        Loop
        w = a
        Do While w <= b
            Graf.Series(1).Points.AddXY(Math.Round(w, 1), f(w))
            w = w + 0.1
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Salida.Rows.Clear()
        Graf.Series(0).Points.Clear()
        Graf.Series(1).Points.Clear()
        tbA.Text = ""
        tbB.Text = ""
        tbCS.Text = ""
        tbFuncion.Text = ""
        tbN.Text = ""
        tbRangoFinal.Text = ""
        tbRangoInicial.Text = ""
    End Sub

    Dim i, redon, n As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("e", 2.7183)
        parser.Values.Add("pi", 3.1416)
        Return parser.Parse(tbFuncion.Text)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lamda(50), ak(50) As Single
        Dim folder = "C:\"
        Dim CnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & folder & ";Extended Properties=""text;HDR=No;FMT=Delimited"";"
        Dim dt As New DataTable

        a = tbA.Text
        b = tbB.Text
        h = (b - a) / 2
        n = tbN.Text
        i = 0
        cs = tbCS.Text
        redon = cs + 2
        ec = 0.5 * 10 ^ (-cs)
        err(i) = 1

        Dim query = "select * from [BDCuadratura.csv] where f1 = " + n.ToString
        Using Adp As New OleDbDataAdapter(query, CnStr)
            Adp.Fill(dt)
            For i As Integer = 0 To dt.Rows.Count - 1
                lamda(i) = dt.Rows(i)(2)
                ak(i) = dt.Rows(i)(3)
            Next
        End Using

        suma = 0
        For k = 1 To n
            suma = suma + ak(k) * f((b + a) / 2 + (b - a) / 2 * lamda(k))
        Next
        integral(i) = h * suma
        Salida.Rows.Add(n, integral(i), err(i))

        Do While err(i) > ec
            n = n + 1
            i = i + 1
            dt.Clear()
            query = "select * from [BDCuadratura.csv] where f1 = " + n.ToString
            Using Adp As New OleDbDataAdapter(query, CnStr)
                Adp.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    lamda(i) = dt.Rows(i)(2)
                    ak(i) = dt.Rows(i)(3)
                Next
            End Using

            suma = 0
            For k = 1 To n
                suma = suma + ak(k - 1) * f(((b + a) / 2) + ((b - a) / 2) * lamda(k - 1))
            Next k

            integral(i) = h * suma
            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))
            Salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))
        Loop
    End Sub
End Class

