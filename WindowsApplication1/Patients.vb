Imports System.Data.SqlClient


Public Class Patients
  

  

    Private Sub Patients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDDataSet.patients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PatientsTableAdapter.Fill(Me.BDDataSet.patients)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PatientsBindingSource.AddNew()
        textbox1.Text = ""
        textbox2.Text = ""
        textbox3.Text = ""
        textbox4.Text = ""
        textbox4.Text = ""
        textbox5.Text = ""
        textbox6.Text = ""
        textbox7.Text = ""
        textbox8.Text = ""
        textbox9.Text = ""
        textbox10.Text = ""
        textbox11.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        textbox1.Enabled = True
        textbox2.Enabled = True
        textbox3.Enabled = True
        textbox4.Enabled = True
        textbox4.Enabled = True
        textbox5.Enabled = True
        textbox6.Enabled = True
        textbox7.Enabled = True
        textbox8.Enabled = True
        textbox9.Enabled = True
        textbox10.Enabled = True
        textbox11.Enabled = True

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        dateNaissance.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If RadioButton1.Checked = True Then
                Label100.Text = " Femme"
            ElseIf RadioButton2.Checked = True Then
                Label100.Text = "Homme"
            End If
            If textbox1.Text = "" Or
                textbox2.Text = "" Or
                textbox3.Text = "" Or
                textbox4.Text = "" Or
                textbox5.Text = "" Or
                textbox6.Text = "" Or
                textbox7.Text = "" Or
                textbox8.Text = "" Or
                textbox9.Text = "" Or
                textbox10.Text = "" Or
                 textbox11.Text = "" Or
                 Label100.Text = "" Then

                MessageBox.Show("Il Faut Remplir Tous Les champs")
            Else

                PatientsBindingSource.EndEdit()
                PatientsTableAdapter.Update(BDDataSet.patients)
                MessageBox.Show(" Bien Enregistrer ")

                textbox1.Enabled = False
                textbox2.Enabled = False
                textbox3.Enabled = False
                textbox4.Enabled = False
                textbox4.Enabled = False
                textbox5.Enabled = False
                textbox6.Enabled = False
                textbox7.Enabled = False
                textbox8.Enabled = False
                textbox9.Enabled = False
                textbox10.Enabled = False

                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
                dateNaissance.Enabled = False

            End If

        Catch ex As Exception
            MessageBox.Show("Ereur")
        End Try
    End Sub


    Private Sub textbox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        textbox1.Enabled = True
        textbox2.Enabled = True
        textbox3.Enabled = True
        textbox3.Enabled = True
        textbox5.Enabled = True
        textbox6.Enabled = True
        textbox7.Enabled = True
        textbox8.Enabled = True
        textbox9.Enabled = True
        textbox10.Enabled = True
        textbox11.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        dateNaissance.Enabled = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If MessageBox.Show(" Voulez Vous Vraiment Enregistrer ces Modfifications  ", " modification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            PatientsBindingSource.EndEdit()
            PatientsTableAdapter.Update(BDDataSet.patients)
            MessageBox.Show(" Votre Modification à Bien Effectué")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If MessageBox.Show(" Vous Voulez Vraiment Supprimer Ce patient ", " Suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                PatientsBindingSource.RemoveCurrent()
                PatientsTableAdapter.Update(BDDataSet.patients)


            End If
        Catch es As Exception

        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PatientsBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PatientsBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PatientsBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PatientsBindingSource.MoveFirst()
    End Sub

    Private Sub CINToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CINToolStripButton.Click
        Try
            Me.PatientsTableAdapter.CIN(Me.BDDataSet.patients, CINToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Me.PatientsTableAdapter.CIN(Me.BDDataSet.patients, TextBox20.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CINToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CINToolStripButton1.Click
        Try
            Me.PatientsTableAdapter.CIN(Me.BDDataSet.patients, CINToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class