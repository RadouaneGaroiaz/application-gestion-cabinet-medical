<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patients))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textbox11 = New System.Windows.Forms.TextBox()
        Me.textbox4 = New System.Windows.Forms.TextBox()
        Me.textbox6 = New System.Windows.Forms.ComboBox()
        Me.textbox5 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dateNaissance = New System.Windows.Forms.DateTimePicker()
        Me.textbox10 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textbox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textbox1 = New System.Windows.Forms.TextBox()
        Me.textbox9 = New System.Windows.Forms.TextBox()
        Me.textbox2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textbox8 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textbox7 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CINToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CINToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CINToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CINToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CINToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CINToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CINToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.CINToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDataSet = New WindowsApplication1.BDDataSet()
        Me.CINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrénomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateNaissanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationnalitéDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodePostaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelPortableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelFixeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsTableAdapter = New WindowsApplication1.BDDataSetTableAdapters.patientsTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.CINToolStrip.SuspendLayout()
        Me.CINToolStrip1.SuspendLayout()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.textbox11)
        Me.GroupBox1.Controls.Add(Me.textbox4)
        Me.GroupBox1.Controls.Add(Me.textbox6)
        Me.GroupBox1.Controls.Add(Me.textbox5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.textbox10)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.textbox3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.textbox1)
        Me.GroupBox1.Controls.Add(Me.textbox9)
        Me.GroupBox1.Controls.Add(Me.textbox2)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.textbox8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.textbox7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 616)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations Générales "
        '
        'textbox11
        '
        Me.textbox11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "E_mail", True))
        Me.textbox11.Enabled = False
        Me.textbox11.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox11.Location = New System.Drawing.Point(157, 545)
        Me.textbox11.Name = "textbox11"
        Me.textbox11.Size = New System.Drawing.Size(188, 26)
        Me.textbox11.TabIndex = 11
        '
        'textbox4
        '
        Me.textbox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "profession", True))
        Me.textbox4.Enabled = False
        Me.textbox4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox4.Location = New System.Drawing.Point(157, 303)
        Me.textbox4.Name = "textbox4"
        Me.textbox4.Size = New System.Drawing.Size(188, 26)
        Me.textbox4.TabIndex = 4
        '
        'textbox6
        '
        Me.textbox6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PatientsBindingSource, "Ville", True))
        Me.textbox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Ville", True))
        Me.textbox6.Enabled = False
        Me.textbox6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox6.FormattingEnabled = True
        Me.textbox6.Location = New System.Drawing.Point(157, 365)
        Me.textbox6.Name = "textbox6"
        Me.textbox6.Size = New System.Drawing.Size(188, 27)
        Me.textbox6.TabIndex = 5
        '
        'textbox5
        '
        Me.textbox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Nationnalité", True))
        Me.textbox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PatientsBindingSource, "Nationnalité", True))
        Me.textbox5.Enabled = False
        Me.textbox5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox5.FormattingEnabled = True
        Me.textbox5.Location = New System.Drawing.Point(157, 334)
        Me.textbox5.Name = "textbox5"
        Me.textbox5.Size = New System.Drawing.Size(188, 27)
        Me.textbox5.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 303)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 22)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Profession "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dateNaissance)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 68)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date De Naissance"
        '
        'dateNaissance
        '
        Me.dateNaissance.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientsBindingSource, "Date_Naissance", True))
        Me.dateNaissance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Date_Naissance", True))
        Me.dateNaissance.Enabled = False
        Me.dateNaissance.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateNaissance.Location = New System.Drawing.Point(134, 33)
        Me.dateNaissance.Name = "dateNaissance"
        Me.dateNaissance.Size = New System.Drawing.Size(183, 21)
        Me.dateNaissance.TabIndex = 0
        '
        'textbox10
        '
        Me.textbox10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Tel_Portable", True))
        Me.textbox10.Enabled = False
        Me.textbox10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox10.Location = New System.Drawing.Point(157, 515)
        Me.textbox10.Name = "textbox10"
        Me.textbox10.Size = New System.Drawing.Size(188, 26)
        Me.textbox10.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(331, 50)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sexe"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Font = New System.Drawing.Font("Cambria", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(224, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(83, 23)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Homme"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Font = New System.Drawing.Font("Cambria", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(103, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(79, 23)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Femme"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 22)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Ville"
        '
        'textbox3
        '
        Me.textbox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "CIN", True))
        Me.textbox3.Enabled = False
        Me.textbox3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox3.Location = New System.Drawing.Point(157, 41)
        Me.textbox3.Name = "textbox3"
        Me.textbox3.Size = New System.Drawing.Size(188, 26)
        Me.textbox3.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 22)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Code Postale"
        '
        'textbox1
        '
        Me.textbox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Nom", True))
        Me.textbox1.Enabled = False
        Me.textbox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox1.Location = New System.Drawing.Point(157, 73)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(188, 26)
        Me.textbox1.TabIndex = 1
        '
        'textbox9
        '
        Me.textbox9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "tel_Fixe", True))
        Me.textbox9.Enabled = False
        Me.textbox9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox9.Location = New System.Drawing.Point(157, 485)
        Me.textbox9.Name = "textbox9"
        Me.textbox9.Size = New System.Drawing.Size(188, 26)
        Me.textbox9.TabIndex = 9
        '
        'textbox2
        '
        Me.textbox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Prénom", True))
        Me.textbox2.Enabled = False
        Me.textbox2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox2.Location = New System.Drawing.Point(157, 104)
        Me.textbox2.Name = "textbox2"
        Me.textbox2.Size = New System.Drawing.Size(188, 26)
        Me.textbox2.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 426)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 22)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Adresse"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(28, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 22)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Prénom"
        '
        'textbox8
        '
        Me.textbox8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Adresse", True))
        Me.textbox8.Enabled = False
        Me.textbox8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox8.Location = New System.Drawing.Point(157, 426)
        Me.textbox8.Multiline = True
        Me.textbox8.Name = "textbox8"
        Me.textbox8.Size = New System.Drawing.Size(188, 54)
        Me.textbox8.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 22)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Nationnalité"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 22)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nom"
        '
        'textbox7
        '
        Me.textbox7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Code_Postale", True))
        Me.textbox7.Enabled = False
        Me.textbox7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox7.Location = New System.Drawing.Point(157, 396)
        Me.textbox7.Name = "textbox7"
        Me.textbox7.Size = New System.Drawing.Size(188, 26)
        Me.textbox7.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 22)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "CIN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 485)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 22)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Tel Fixe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 545)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "E-mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 515)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 22)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Tel Portable"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(532, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(221, 39)
        Me.Label21.TabIndex = 90
        Me.Label21.Text = "Gestion Patients"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(402, 185)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(939, 374)
        Me.GroupBox4.TabIndex = 91
        Me.GroupBox4.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CINDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.PrénomDataGridViewTextBoxColumn, Me.SexeDataGridViewTextBoxColumn, Me.DateNaissanceDataGridViewTextBoxColumn, Me.ProfessionDataGridViewTextBoxColumn, Me.NationnalitéDataGridViewTextBoxColumn, Me.VilleDataGridViewTextBoxColumn, Me.CodePostaleDataGridViewTextBoxColumn, Me.AdresseDataGridViewTextBoxColumn, Me.TelPortableDataGridViewTextBoxColumn, Me.TelFixeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(10, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(909, 339)
        Me.DataGridView1.TabIndex = 0
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
        Me.GroupBox5.Location = New System.Drawing.Point(402, 557)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(629, 119)
        Me.GroupBox5.TabIndex = 97
        Me.GroupBox5.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(29, 37)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(375, 22)
        Me.Label23.TabIndex = 90
        Me.Label23.Text = "Recherche par Numéro de Carte Nationale"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(481, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 22)
        Me.Label22.TabIndex = 113
        Me.Label22.Text = "Recherche"
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(483, 21)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(102, 56)
        Me.Button9.TabIndex = 112
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox20.Location = New System.Drawing.Point(98, 76)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(248, 26)
        Me.TextBox20.TabIndex = 90
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button7)
        Me.GroupBox6.Controls.Add(Me.Button8)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(402, 60)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(930, 108)
        Me.GroupBox6.TabIndex = 98
        Me.GroupBox6.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(793, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 22)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "Supprimer"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(690, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 22)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Modifier"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(587, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 22)
        Me.Label20.TabIndex = 109
        Me.Label20.Text = "Dernier"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(687, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 56)
        Me.Button2.TabIndex = 108
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(795, 21)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 56)
        Me.Button7.TabIndex = 107
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(579, 21)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(102, 56)
        Me.Button8.TabIndex = 106
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(480, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 22)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "Suivant"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(366, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 22)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Précédent"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(263, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 22)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Premier"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(363, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 56)
        Me.Button1.TabIndex = 102
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(471, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 56)
        Me.Button3.TabIndex = 100
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(141, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 22)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Enregistrer"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(145, 21)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 56)
        Me.Button5.TabIndex = 101
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(255, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 56)
        Me.Button4.TabIndex = 99
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 22)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Nouveau"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(37, 21)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 56)
        Me.Button6.TabIndex = 99
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Location = New System.Drawing.Point(1050, 560)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(282, 116)
        Me.GroupBox7.TabIndex = 99
        Me.GroupBox7.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(122, 59)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 43)
        Me.Label24.TabIndex = 85
        Me.Label24.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(28, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(221, 33)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "Total Des Patients "
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Sexe", True))
        Me.Label100.Location = New System.Drawing.Point(178, 28)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(0, 13)
        Me.Label100.TabIndex = 100
        '
        'Button10
        '
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(1084, 5)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(102, 56)
        Me.Button10.TabIndex = 108
        Me.Button10.UseVisualStyleBackColor = True
        '
        'CINToolStrip
        '
        Me.CINToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CINToolStripLabel, Me.CINToolStripTextBox, Me.CINToolStripButton})
        Me.CINToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.CINToolStrip.Name = "CINToolStrip"
        Me.CINToolStrip.Size = New System.Drawing.Size(1350, 25)
        Me.CINToolStrip.TabIndex = 109
        Me.CINToolStrip.Text = "CINToolStrip"
        Me.CINToolStrip.Visible = False
        '
        'CINToolStripLabel
        '
        Me.CINToolStripLabel.Name = "CINToolStripLabel"
        Me.CINToolStripLabel.Size = New System.Drawing.Size(30, 22)
        Me.CINToolStripLabel.Text = "CIN:"
        '
        'CINToolStripTextBox
        '
        Me.CINToolStripTextBox.Name = "CINToolStripTextBox"
        Me.CINToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'CINToolStripButton
        '
        Me.CINToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CINToolStripButton.Name = "CINToolStripButton"
        Me.CINToolStripButton.Size = New System.Drawing.Size(31, 22)
        Me.CINToolStripButton.Text = "CIN"
        '
        'CINToolStrip1
        '
        Me.CINToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CINToolStripLabel1, Me.CINToolStripTextBox1, Me.CINToolStripButton1})
        Me.CINToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.CINToolStrip1.Name = "CINToolStrip1"
        Me.CINToolStrip1.Size = New System.Drawing.Size(1350, 25)
        Me.CINToolStrip1.TabIndex = 110
        Me.CINToolStrip1.Text = "CINToolStrip1"
        Me.CINToolStrip1.Visible = False
        '
        'CINToolStripLabel1
        '
        Me.CINToolStripLabel1.Name = "CINToolStripLabel1"
        Me.CINToolStripLabel1.Size = New System.Drawing.Size(30, 22)
        Me.CINToolStripLabel1.Text = "CIN:"
        '
        'CINToolStripTextBox1
        '
        Me.CINToolStripTextBox1.Name = "CINToolStripTextBox1"
        Me.CINToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'CINToolStripButton1
        '
        Me.CINToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CINToolStripButton1.Name = "CINToolStripButton1"
        Me.CINToolStripButton1.Size = New System.Drawing.Size(31, 22)
        Me.CINToolStripButton1.Text = "CIN"
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "patients"
        Me.PatientsBindingSource.DataSource = Me.BDDataSet
        '
        'BDDataSet
        '
        Me.BDDataSet.DataSetName = "BDDataSet"
        Me.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CINDataGridViewTextBoxColumn
        '
        Me.CINDataGridViewTextBoxColumn.DataPropertyName = "CIN"
        Me.CINDataGridViewTextBoxColumn.HeaderText = "CIN"
        Me.CINDataGridViewTextBoxColumn.Name = "CINDataGridViewTextBoxColumn"
        Me.CINDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "Nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        Me.NomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrénomDataGridViewTextBoxColumn
        '
        Me.PrénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom"
        Me.PrénomDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.PrénomDataGridViewTextBoxColumn.Name = "PrénomDataGridViewTextBoxColumn"
        Me.PrénomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexeDataGridViewTextBoxColumn
        '
        Me.SexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe"
        Me.SexeDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.SexeDataGridViewTextBoxColumn.Name = "SexeDataGridViewTextBoxColumn"
        Me.SexeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateNaissanceDataGridViewTextBoxColumn
        '
        Me.DateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "Date_Naissance"
        Me.DateNaissanceDataGridViewTextBoxColumn.HeaderText = "Date_Naissance"
        Me.DateNaissanceDataGridViewTextBoxColumn.Name = "DateNaissanceDataGridViewTextBoxColumn"
        Me.DateNaissanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProfessionDataGridViewTextBoxColumn
        '
        Me.ProfessionDataGridViewTextBoxColumn.DataPropertyName = "profession"
        Me.ProfessionDataGridViewTextBoxColumn.HeaderText = "profession"
        Me.ProfessionDataGridViewTextBoxColumn.Name = "ProfessionDataGridViewTextBoxColumn"
        Me.ProfessionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NationnalitéDataGridViewTextBoxColumn
        '
        Me.NationnalitéDataGridViewTextBoxColumn.DataPropertyName = "Nationnalité"
        Me.NationnalitéDataGridViewTextBoxColumn.HeaderText = "Nationnalité"
        Me.NationnalitéDataGridViewTextBoxColumn.Name = "NationnalitéDataGridViewTextBoxColumn"
        Me.NationnalitéDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VilleDataGridViewTextBoxColumn
        '
        Me.VilleDataGridViewTextBoxColumn.DataPropertyName = "Ville"
        Me.VilleDataGridViewTextBoxColumn.HeaderText = "Ville"
        Me.VilleDataGridViewTextBoxColumn.Name = "VilleDataGridViewTextBoxColumn"
        Me.VilleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodePostaleDataGridViewTextBoxColumn
        '
        Me.CodePostaleDataGridViewTextBoxColumn.DataPropertyName = "Code_Postale"
        Me.CodePostaleDataGridViewTextBoxColumn.HeaderText = "Code_Postale"
        Me.CodePostaleDataGridViewTextBoxColumn.Name = "CodePostaleDataGridViewTextBoxColumn"
        Me.CodePostaleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdresseDataGridViewTextBoxColumn
        '
        Me.AdresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse"
        Me.AdresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.AdresseDataGridViewTextBoxColumn.Name = "AdresseDataGridViewTextBoxColumn"
        Me.AdresseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelPortableDataGridViewTextBoxColumn
        '
        Me.TelPortableDataGridViewTextBoxColumn.DataPropertyName = "Tel_Portable"
        Me.TelPortableDataGridViewTextBoxColumn.HeaderText = "Tel_Portable"
        Me.TelPortableDataGridViewTextBoxColumn.Name = "TelPortableDataGridViewTextBoxColumn"
        Me.TelPortableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelFixeDataGridViewTextBoxColumn
        '
        Me.TelFixeDataGridViewTextBoxColumn.DataPropertyName = "tel_Fixe"
        Me.TelFixeDataGridViewTextBoxColumn.HeaderText = "tel_Fixe"
        Me.TelFixeDataGridViewTextBoxColumn.Name = "TelFixeDataGridViewTextBoxColumn"
        Me.TelFixeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "E_mail"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E_mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 733)
        Me.Controls.Add(Me.CINToolStrip1)
        Me.Controls.Add(Me.CINToolStrip)
        Me.Controls.Add(Me.Label100)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Patients"
        Me.Text = "Gestion Patients"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.CINToolStrip.ResumeLayout(False)
        Me.CINToolStrip.PerformLayout()
        Me.CINToolStrip1.ResumeLayout(False)
        Me.CINToolStrip1.PerformLayout()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents textbox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents textbox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents textbox1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dateNaissance As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents textbox11 As System.Windows.Forms.TextBox
    Friend WithEvents textbox10 As System.Windows.Forms.TextBox
    Friend WithEvents textbox9 As System.Windows.Forms.TextBox
    Friend WithEvents textbox8 As System.Windows.Forms.TextBox
    Friend WithEvents textbox7 As System.Windows.Forms.TextBox
    Friend WithEvents textbox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents BDDataSet As WindowsApplication1.BDDataSet
    Friend WithEvents PatientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientsTableAdapter As WindowsApplication1.BDDataSetTableAdapters.patientsTableAdapter
    Friend WithEvents CINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrénomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateNaissanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfessionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationnalitéDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VilleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodePostaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdresseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelPortableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelFixeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents textbox6 As System.Windows.Forms.ComboBox
    Friend WithEvents CINToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CINToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CINToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CINToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CINToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CINToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CINToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CINToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
