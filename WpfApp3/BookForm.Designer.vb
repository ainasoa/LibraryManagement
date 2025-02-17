<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AuthorGroupBox = New System.Windows.Forms.GroupBox()
        Me.PseudoTextBox = New System.Windows.Forms.TextBox()
        Me.PseudoLabel = New System.Windows.Forms.Label()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameLabel = New System.Windows.Forms.Label()
        Me.PageNumberLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.PageNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuthorGroupBox
        '
        Me.AuthorGroupBox.Controls.Add(Me.PseudoTextBox)
        Me.AuthorGroupBox.Controls.Add(Me.PseudoLabel)
        Me.AuthorGroupBox.Controls.Add(Me.LastnameTextBox)
        Me.AuthorGroupBox.Controls.Add(Me.Label1)
        Me.AuthorGroupBox.Controls.Add(Me.FirstnameTextBox)
        Me.AuthorGroupBox.Controls.Add(Me.FirstnameLabel)
        Me.AuthorGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorGroupBox.Location = New System.Drawing.Point(58, 151)
        Me.AuthorGroupBox.Name = "AuthorGroupBox"
        Me.AuthorGroupBox.Size = New System.Drawing.Size(386, 138)
        Me.AuthorGroupBox.TabIndex = 10
        Me.AuthorGroupBox.TabStop = False
        Me.AuthorGroupBox.Text = "A propos de l'Auteur"
        '
        'PseudoTextBox
        '
        Me.PseudoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PseudoTextBox.Location = New System.Drawing.Point(83, 105)
        Me.PseudoTextBox.Name = "PseudoTextBox"
        Me.PseudoTextBox.Size = New System.Drawing.Size(280, 22)
        Me.PseudoTextBox.TabIndex = 0
        '
        'PseudoLabel
        '
        Me.PseudoLabel.AutoSize = True
        Me.PseudoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PseudoLabel.Location = New System.Drawing.Point(20, 108)
        Me.PseudoLabel.Name = "PseudoLabel"
        Me.PseudoLabel.Size = New System.Drawing.Size(60, 16)
        Me.PseudoLabel.TabIndex = 1
        Me.PseudoLabel.Text = "Pseudo :"
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastnameTextBox.Location = New System.Drawing.Point(83, 70)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(280, 22)
        Me.LastnameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Prénom :"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(83, 38)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(280, 22)
        Me.FirstnameTextBox.TabIndex = 0
        '
        'FirstnameLabel
        '
        Me.FirstnameLabel.AutoSize = True
        Me.FirstnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameLabel.Location = New System.Drawing.Point(38, 41)
        Me.FirstnameLabel.Name = "FirstnameLabel"
        Me.FirstnameLabel.Size = New System.Drawing.Size(42, 16)
        Me.FirstnameLabel.TabIndex = 1
        Me.FirstnameLabel.Text = "Nom :"
        '
        'PageNumberLabel
        '
        Me.PageNumberLabel.AutoSize = True
        Me.PageNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageNumberLabel.Location = New System.Drawing.Point(19, 47)
        Me.PageNumberLabel.Name = "PageNumberLabel"
        Me.PageNumberLabel.Size = New System.Drawing.Size(116, 16)
        Me.PageNumberLabel.TabIndex = 7
        Me.PageNumberLabel.Text = "Nombre de page :"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(97, 15)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(40, 16)
        Me.TitleLabel.TabIndex = 8
        Me.TitleLabel.Text = "Titre :"
        '
        'PageNumberTextBox
        '
        Me.PageNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageNumberTextBox.Location = New System.Drawing.Point(138, 44)
        Me.PageNumberTextBox.Name = "PageNumberTextBox"
        Me.PageNumberTextBox.Size = New System.Drawing.Size(124, 22)
        Me.PageNumberTextBox.TabIndex = 4
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(140, 12)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(280, 22)
        Me.TitleTextBox.TabIndex = 5
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(206, 304)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(89, 27)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Enregistrer"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(317, 304)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 27)
        Me.CloseButton.TabIndex = 12
        Me.CloseButton.Text = "Fermer"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(58, 81)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(77, 16)
        Me.DescriptionLabel.TabIndex = 9
        Me.DescriptionLabel.Text = "Desciption :"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(138, 78)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(282, 67)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 345)
        Me.Controls.Add(Me.AuthorGroupBox)
        Me.Controls.Add(Me.PageNumberLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PageNumberTextBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BookForm"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Formulaire du livre"
        Me.AuthorGroupBox.ResumeLayout(False)
        Me.AuthorGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AuthorGroupBox As Forms.GroupBox
    Friend WithEvents PseudoTextBox As Forms.TextBox
    Friend WithEvents PseudoLabel As Forms.Label
    Friend WithEvents LastnameTextBox As Forms.TextBox
    Friend WithEvents Label1 As Forms.Label
    Friend WithEvents FirstnameTextBox As Forms.TextBox
    Friend WithEvents FirstnameLabel As Forms.Label
    Friend WithEvents PageNumberLabel As Forms.Label
    Friend WithEvents TitleLabel As Forms.Label
    Friend WithEvents PageNumberTextBox As Forms.TextBox
    Friend WithEvents TitleTextBox As Forms.TextBox
    Friend WithEvents SaveButton As Forms.Button
    Friend WithEvents CloseButton As Forms.Button
    Friend WithEvents DescriptionLabel As Forms.Label
    Friend WithEvents DescriptionTextBox As Forms.TextBox
End Class
