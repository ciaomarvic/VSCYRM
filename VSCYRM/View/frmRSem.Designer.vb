<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRSem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(57, 18)
        Me.dtpFecIni.MinDate = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecIni.TabIndex = 1
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(224, 18)
        Me.dtpFecFin.MinDate = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(102, 20)
        Me.dtpFecFin.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(103, 49)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Location = New System.Drawing.Point(185, 49)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmRSem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 85)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.dtpFecIni)
        Me.Name = "frmRSem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Semanal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
End Class
