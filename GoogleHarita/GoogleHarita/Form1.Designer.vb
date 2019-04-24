<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HaritaForm1
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SplitContainerGH = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adresTextBox1 = New System.Windows.Forms.TextBox()
        Me.sehirTextBox2 = New System.Windows.Forms.TextBox()
        Me.ulkeTextBox3 = New System.Windows.Forms.TextBox()
        Me.adreseGitButton1 = New System.Windows.Forms.Button()
        Me.GHWebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.SplitContainerGH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerGH.Panel1.SuspendLayout()
        Me.SplitContainerGH.Panel2.SuspendLayout()
        Me.SplitContainerGH.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SplitContainerGH
        '
        Me.SplitContainerGH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerGH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerGH.IsSplitterFixed = True
        Me.SplitContainerGH.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerGH.Name = "SplitContainerGH"
        '
        'SplitContainerGH.Panel1
        '
        Me.SplitContainerGH.Panel1.Controls.Add(Me.adreseGitButton1)
        Me.SplitContainerGH.Panel1.Controls.Add(Me.ulkeTextBox3)
        Me.SplitContainerGH.Panel1.Controls.Add(Me.sehirTextBox2)
        Me.SplitContainerGH.Panel1.Controls.Add(Me.adresTextBox1)
        Me.SplitContainerGH.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainerGH.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerGH.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainerGH.Panel2
        '
        Me.SplitContainerGH.Panel2.Controls.Add(Me.GHWebBrowser1)
        Me.SplitContainerGH.Size = New System.Drawing.Size(800, 428)
        Me.SplitContainerGH.SplitterDistance = 275
        Me.SplitContainerGH.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Şehir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ülke"
        '
        'adresTextBox1
        '
        Me.adresTextBox1.Location = New System.Drawing.Point(17, 35)
        Me.adresTextBox1.Name = "adresTextBox1"
        Me.adresTextBox1.Size = New System.Drawing.Size(233, 20)
        Me.adresTextBox1.TabIndex = 3
        '
        'sehirTextBox2
        '
        Me.sehirTextBox2.Location = New System.Drawing.Point(17, 75)
        Me.sehirTextBox2.Name = "sehirTextBox2"
        Me.sehirTextBox2.Size = New System.Drawing.Size(233, 20)
        Me.sehirTextBox2.TabIndex = 4
        '
        'ulkeTextBox3
        '
        Me.ulkeTextBox3.Location = New System.Drawing.Point(17, 116)
        Me.ulkeTextBox3.Name = "ulkeTextBox3"
        Me.ulkeTextBox3.Size = New System.Drawing.Size(233, 20)
        Me.ulkeTextBox3.TabIndex = 5
        '
        'adreseGitButton1
        '
        Me.adreseGitButton1.Location = New System.Drawing.Point(92, 154)
        Me.adreseGitButton1.Name = "adreseGitButton1"
        Me.adreseGitButton1.Size = New System.Drawing.Size(75, 23)
        Me.adreseGitButton1.TabIndex = 6
        Me.adreseGitButton1.Text = "Adrese Git"
        Me.adreseGitButton1.UseVisualStyleBackColor = True
        '
        'GHWebBrowser1
        '
        Me.GHWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GHWebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.GHWebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.GHWebBrowser1.Name = "GHWebBrowser1"
        Me.GHWebBrowser1.Size = New System.Drawing.Size(521, 428)
        Me.GHWebBrowser1.TabIndex = 0
        '
        'HaritaForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainerGH)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "HaritaForm1"
        Me.Text = "GoogleHaritalar"
        Me.SplitContainerGH.Panel1.ResumeLayout(False)
        Me.SplitContainerGH.Panel1.PerformLayout()
        Me.SplitContainerGH.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerGH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerGH.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SplitContainerGH As SplitContainer
    Friend WithEvents adreseGitButton1 As Button
    Friend WithEvents ulkeTextBox3 As TextBox
    Friend WithEvents sehirTextBox2 As TextBox
    Friend WithEvents adresTextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GHWebBrowser1 As WebBrowser
End Class
