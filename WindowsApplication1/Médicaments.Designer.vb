<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Médicaments
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Médicaments))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomMédicamentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitéDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MédicamentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDataSet = New WindowsApplication1.BDDataSet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MédicamentsTableAdapter = New WindowsApplication1.BDDataSetTableAdapters.MédicamentsTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MEdToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Nom_MédicamentToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Nom_MédicamentToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.MEdToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MédicamentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.MEdToolStrip.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 226)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste Des Médicaments"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomMédicamentDataGridViewTextBoxColumn, Me.QuantitéDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MédicamentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(5, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(750, 191)
        Me.DataGridView1.TabIndex = 0
        '
        'NomMédicamentDataGridViewTextBoxColumn
        '
        Me.NomMédicamentDataGridViewTextBoxColumn.DataPropertyName = "Nom Médicament"
        Me.NomMédicamentDataGridViewTextBoxColumn.HeaderText = "Nom Médicament"
        Me.NomMédicamentDataGridViewTextBoxColumn.Name = "NomMédicamentDataGridViewTextBoxColumn"
        Me.NomMédicamentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantitéDataGridViewTextBoxColumn
        '
        Me.QuantitéDataGridViewTextBoxColumn.DataPropertyName = "Quantité"
        Me.QuantitéDataGridViewTextBoxColumn.HeaderText = "Quantité"
        Me.QuantitéDataGridViewTextBoxColumn.Name = "QuantitéDataGridViewTextBoxColumn"
        Me.QuantitéDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MédicamentsBindingSource
        '
        Me.MédicamentsBindingSource.DataMember = "Médicaments"
        Me.MédicamentsBindingSource.DataSource = Me.BDDataSet
        '
        'BDDataSet
        '
        Me.BDDataSet.DataSetName = "BDDataSet"
        Me.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(557, 90)
        Me.GroupBox3.TabIndex = 85
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 22)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Quantité"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MédicamentsBindingSource, "Quantité", True))
        Me.TextBox2.Location = New System.Drawing.Point(287, 55)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(239, 25)
        Me.TextBox2.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 22)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Nom de médicament"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MédicamentsBindingSource, "Nom Médicament", True))
        Me.TextBox1.Location = New System.Drawing.Point(287, 18)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 25)
        Me.TextBox1.TabIndex = 88
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(204, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(178, 39)
        Me.Label21.TabIndex = 84
        Me.Label21.Text = "Médicaments"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Controls.Add(Me.Button7)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(761, 108)
        Me.GroupBox6.TabIndex = 125
        Me.GroupBox6.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(626, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 22)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Supprimer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(518, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 22)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Modifier"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(511, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 56)
        Me.Button2.TabIndex = 108
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(628, 17)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 56)
        Me.Button7.TabIndex = 107
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(400, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 22)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "Suivant"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(276, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 22)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Précédent"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(273, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 56)
        Me.Button1.TabIndex = 102
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(391, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 56)
        Me.Button3.TabIndex = 100
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(148, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 22)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Enregistrer"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(152, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 56)
        Me.Button5.TabIndex = 101
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MédicamentsTableAdapter
        '
        Me.MédicamentsTableAdapter.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 22)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Nouveau"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(34, 18)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 56)
        Me.Button6.TabIndex = 127
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(598, 109)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 56)
        Me.Button4.TabIndex = 108
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MEdToolStrip
        '
        Me.MEdToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nom_MédicamentToolStripLabel, Me.Nom_MédicamentToolStripTextBox, Me.MEdToolStripButton})
        Me.MEdToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MEdToolStrip.Name = "MEdToolStrip"
        Me.MEdToolStrip.Size = New System.Drawing.Size(785, 25)
        Me.MEdToolStrip.TabIndex = 128
        Me.MEdToolStrip.Text = "MEdToolStrip"
        Me.MEdToolStrip.Visible = False
        '
        'Nom_MédicamentToolStripLabel
        '
        Me.Nom_MédicamentToolStripLabel.Name = "Nom_MédicamentToolStripLabel"
        Me.Nom_MédicamentToolStripLabel.Size = New System.Drawing.Size(109, 22)
        Me.Nom_MédicamentToolStripLabel.Text = "Nom_Médicament:"
        '
        'Nom_MédicamentToolStripTextBox
        '
        Me.Nom_MédicamentToolStripTextBox.Name = "Nom_MédicamentToolStripTextBox"
        Me.Nom_MédicamentToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'MEdToolStripButton
        '
        Me.MEdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MEdToolStripButton.Name = "MEdToolStripButton"
        Me.MEdToolStripButton.Size = New System.Drawing.Size(35, 22)
        Me.MEdToolStripButton.Text = "MEd"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.TextBox20)
        Me.GroupBox5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(18, 516)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(755, 106)
        Me.GroupBox5.TabIndex = 129
        Me.GroupBox5.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(120, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(318, 22)
        Me.Label23.TabIndex = 90
        Me.Label23.Text = "Recherche par Nom de médicament"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(642, 78)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 22)
        Me.Label22.TabIndex = 113
        Me.Label22.Text = "Recherche"
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(643, 19)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(102, 56)
        Me.Button9.TabIndex = 112
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox20.Location = New System.Drawing.Point(140, 64)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(273, 26)
        Me.TextBox20.TabIndex = 90
        '
        'Médicaments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 634)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.MEdToolStrip)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label21)
        Me.Name = "Médicaments"
        Me.Text = "Médicaments"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MédicamentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.MEdToolStrip.ResumeLayout(False)
        Me.MEdToolStrip.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents BDDataSet As WindowsApplication1.BDDataSet
    Friend WithEvents MédicamentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MédicamentsTableAdapter As WindowsApplication1.BDDataSetTableAdapters.MédicamentsTableAdapter
    Friend WithEvents NomMédicamentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantitéDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MEdToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Nom_MédicamentToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Nom_MédicamentToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents MEdToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
End Class
