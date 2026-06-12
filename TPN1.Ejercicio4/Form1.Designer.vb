<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdEjecutar = New Button()
        lblMostrar = New Label()
        txtNumero2 = New TextBox()
        txtNumero3 = New TextBox()
        txtNumero1 = New TextBox()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        Me.cmdEjecutar.Location = New Point(195, 128)
        Me.cmdEjecutar.Margin = New Padding(2, 2, 2, 2)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New Size(147, 61)
        Me.cmdEjecutar.TabIndex = 0
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lblMostrar
        ' 
        lblMostrar.AutoSize = True
        lblMostrar.Location = New Point(246, 101)
        lblMostrar.Margin = New Padding(2, 0, 2, 0)
        lblMostrar.Name = "lblMostrar"
        lblMostrar.Size = New Size(59, 15)
        lblMostrar.TabIndex = 1
        lblMostrar.Text = "Resultado"
        ' 
        ' txtNumero2
        ' 
        txtNumero2.Location = New Point(204, 59)
        txtNumero2.Name = "txtNumero2"
        txtNumero2.Size = New Size(128, 23)
        txtNumero2.TabIndex = 2
        ' 
        ' txtNumero3
        ' 
        txtNumero3.Location = New Point(351, 59)
        txtNumero3.Name = "txtNumero3"
        txtNumero3.Size = New Size(127, 23)
        txtNumero3.TabIndex = 3
        ' 
        ' txtNumero1
        ' 
        txtNumero1.Location = New Point(54, 59)
        txtNumero1.Name = "txtNumero1"
        txtNumero1.Size = New Size(127, 23)
        txtNumero1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(txtNumero1)
        Controls.Add(txtNumero3)
        Controls.Add(txtNumero2)
        Controls.Add(lblMostrar)
        Controls.Add(Me.cmdEjecutar)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblMostrar As Label
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents txtNumero3 As TextBox
    Friend WithEvents txtNumero1 As TextBox

End Class
