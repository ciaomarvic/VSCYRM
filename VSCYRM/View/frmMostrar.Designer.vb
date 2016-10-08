<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrar
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.lblHoraCap = New System.Windows.Forms.Label()
        Me.lblJornada = New System.Windows.Forms.Label()
        Me.TimerCloser = New System.Windows.Forms.Timer(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CEDULA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(145, 127)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(49, 13)
        Me.lblCedula.TabIndex = 1
        Me.lblCedula.Text = "0000000"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EMPLEADO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(78, 174)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(116, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "NOMBRE COMPLETO"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(137, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "JORNADA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "HORARIO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VSCYRM.My.Resources.Resources.Mini_Base
        Me.PictureBox1.Location = New System.Drawing.Point(53, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(200, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "HORA REGISTRADA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Location = New System.Drawing.Point(48, 286)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(34, 13)
        Me.lblHorario.TabIndex = 8
        Me.lblHorario.Text = "00:00"
        Me.lblHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoraCap
        '
        Me.lblHoraCap.AutoSize = True
        Me.lblHoraCap.Location = New System.Drawing.Point(246, 286)
        Me.lblHoraCap.Name = "lblHoraCap"
        Me.lblHoraCap.Size = New System.Drawing.Size(34, 13)
        Me.lblHoraCap.TabIndex = 9
        Me.lblHoraCap.Text = "00:00"
        Me.lblHoraCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJornada
        '
        Me.lblJornada.AutoSize = True
        Me.lblJornada.Location = New System.Drawing.Point(112, 225)
        Me.lblJornada.Name = "lblJornada"
        Me.lblJornada.Size = New System.Drawing.Size(114, 13)
        Me.lblJornada.TabIndex = 10
        Me.lblJornada.Text = "ENTRADA - MAÑANA"
        '
        'TimerCloser
        '
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Location = New System.Drawing.Point(13, 12)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(0, 13)
        Me.lblClose.TabIndex = 11
        '
        'frmMostrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(354, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblJornada)
        Me.Controls.Add(Me.lblHoraCap)
        Me.Controls.Add(Me.lblHorario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMostrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHorario As Label
    Friend WithEvents lblHoraCap As Label
    Friend WithEvents lblJornada As Label
    Friend WithEvents TimerCloser As Timer
    Friend WithEvents lblClose As Label
End Class
