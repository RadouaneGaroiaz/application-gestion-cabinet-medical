Public Class Ordonnance

    Private Sub Ordonnance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDDataSet.Ordonnance'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.OrdonnanceTableAdapter.Fill(Me.BDDataSet.Ordonnance)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OrdonnanceBindingSource.AddNew()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
       
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If RadioButton1.Checked = True Then
                Label100.Text = " Femme"
            ElseIf RadioButton2.Checked = True Then
                Label100.Text = "Homme"
            End If
            If TextBox1.Text = "" Or
                TextBox2.Text = "" Or
                TextBox3.Text = "" Or
                TextBox4.Text = "" Or
                TextBox5.Text = "" Or
                TextBox6.Text = "" Or
                TextBox7.Text = "" Or
                 Label100.Text = "" Then

                MessageBox.Show("Il Faut Remplir Tous Les champs")
            Else

                OrdonnanceBindingSource.EndEdit()
                OrdonnanceTableAdapter.Update(BDDataSet.Ordonnance)
                MessageBox.Show(" Bien Enregistrer ")

                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = False
                TextBox6.Enabled = False
                TextBox7.Enabled = False
               

                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
                DateTimePicker1.Enabled = False

            End If

        Catch ex As Exception
            MessageBox.Show("Ereur")
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If MessageBox.Show(" Vous Voulez Vraiment Supprimer Ce patient ", " Suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                OrdonnanceBindingSource.RemoveCurrent()
                OrdonnanceTableAdapter.Update(BDDataSet.Ordonnance)


            End If
        Catch es As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox3.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
      
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If MessageBox.Show(" Voulez Vous Vraiment Enregistrer ces Modfifications  ", " modification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            OrdonnanceBindingSource.EndEdit()
            OrdonnanceTableAdapter.Update(BDDataSet.Ordonnance)
            MessageBox.Show(" Votre Modification à Bien Effectué")
        End If
    End Sub

    Private Sub CINToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CINToolStripButton.Click
        Try
            Me.OrdonnanceTableAdapter.CIN(Me.BDDataSet.Ordonnance, CINToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Me.OrdonnanceTableAdapter.CIN(Me.BDDataSet.Ordonnance, TextBox20.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OrdonnanceBindingSource.MoveFirst()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OrdonnanceBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OrdonnanceBindingSource.MoveNext()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        OrdonnanceBindingSource.MoveLast()
    End Sub
End Class