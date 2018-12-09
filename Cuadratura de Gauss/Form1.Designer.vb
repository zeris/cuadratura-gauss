<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbA = New System.Windows.Forms.TextBox()
        Me.tbB = New System.Windows.Forms.TextBox()
        Me.tbFuncion = New System.Windows.Forms.TextBox()
        Me.tbN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbCS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.Graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tbRangoFinal = New System.Windows.Forms.TextBox()
        Me.tbRangoInicial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dame el valor de a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dame el valor de b"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(203, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(510, 119)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(649, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dame la funcion"
        '
        'tbA
        '
        Me.tbA.Location = New System.Drawing.Point(15, 50)
        Me.tbA.Name = "tbA"
        Me.tbA.Size = New System.Drawing.Size(100, 20)
        Me.tbA.TabIndex = 6
        '
        'tbB
        '
        Me.tbB.Location = New System.Drawing.Point(145, 50)
        Me.tbB.Name = "tbB"
        Me.tbB.Size = New System.Drawing.Size(100, 20)
        Me.tbB.TabIndex = 7
        '
        'tbFuncion
        '
        Me.tbFuncion.Location = New System.Drawing.Point(282, 50)
        Me.tbFuncion.Name = "tbFuncion"
        Me.tbFuncion.Size = New System.Drawing.Size(100, 20)
        Me.tbFuncion.TabIndex = 8
        '
        'tbN
        '
        Me.tbN.Location = New System.Drawing.Point(407, 50)
        Me.tbN.Name = "tbN"
        Me.tbN.Size = New System.Drawing.Size(100, 20)
        Me.tbN.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Dame el valor de n"
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(68, 169)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(343, 267)
        Me.Salida.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "n"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Integral"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Error"
        Me.Column3.Name = "Column3"
        '
        'tbCS
        '
        Me.tbCS.Location = New System.Drawing.Point(539, 50)
        Me.tbCS.Name = "tbCS"
        Me.tbCS.Size = New System.Drawing.Size(100, 20)
        Me.tbCS.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(543, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cifras significativas"
        '
        'btnGraficar
        '
        Me.btnGraficar.Location = New System.Drawing.Point(336, 119)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(75, 23)
        Me.btnGraficar.TabIndex = 14
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = True
        '
        'Graf
        '
        ChartArea2.Name = "ChartArea1"
        Me.Graf.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Graf.Legends.Add(Legend2)
        Me.Graf.Location = New System.Drawing.Point(491, 169)
        Me.Graf.Name = "Graf"
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Función"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series4.Color = System.Drawing.Color.Red
        Series4.Legend = "Legend1"
        Series4.Name = "Área"
        Me.Graf.Series.Add(Series3)
        Me.Graf.Series.Add(Series4)
        Me.Graf.Size = New System.Drawing.Size(381, 267)
        Me.Graf.TabIndex = 15
        Me.Graf.Text = "Grad"
        '
        'tbRangoFinal
        '
        Me.tbRangoFinal.Location = New System.Drawing.Point(797, 50)
        Me.tbRangoFinal.Name = "tbRangoFinal"
        Me.tbRangoFinal.Size = New System.Drawing.Size(100, 20)
        Me.tbRangoFinal.TabIndex = 19
        '
        'tbRangoInicial
        '
        Me.tbRangoInicial.Location = New System.Drawing.Point(667, 50)
        Me.tbRangoInicial.Name = "tbRangoInicial"
        Me.tbRangoInicial.Size = New System.Drawing.Size(100, 20)
        Me.tbRangoInicial.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(797, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Valor final a graficar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(664, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Valor inicial a graficar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 448)
        Me.Controls.Add(Me.tbRangoFinal)
        Me.Controls.Add(Me.tbRangoInicial)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Graf)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.tbCS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbN)
        Me.Controls.Add(Me.tbFuncion)
        Me.Controls.Add(Me.tbB)
        Me.Controls.Add(Me.tbA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Cuadratura de Gauss"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbA As TextBox
    Friend WithEvents tbB As TextBox
    Friend WithEvents tbFuncion As TextBox
    Friend WithEvents tbN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents tbCS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGraficar As Button
    Friend WithEvents Graf As DataVisualization.Charting.Chart
    Friend WithEvents tbRangoFinal As TextBox
    Friend WithEvents tbRangoInicial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
