<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox2 = New ComboBox()
        ListBox1 = New ListBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 59)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(237, 29)
        ComboBox1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(237, 31)
        TextBox1.TabIndex = 1
        TextBox1.Text = "ComboBox Title One"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 121)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(237, 31)
        TextBox2.TabIndex = 2
        TextBox2.Text = "ComboBox Title Two"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(12, 158)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(237, 29)
        ComboBox2.TabIndex = 3
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 21
        ListBox1.Location = New Point(308, 60)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(236, 214)
        ListBox1.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(308, 22)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(237, 31)
        TextBox3.TabIndex = 5
        TextBox3.Text = "ListBox Title One"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(585, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 32)
        Button1.TabIndex = 6
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(585, 70)
        Button2.Name = "Button2"
        Button2.Size = New Size(188, 32)
        Button2.TabIndex = 7
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(ListBox1)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
