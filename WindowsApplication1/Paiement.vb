Public Class Paiement

    Private Sub Paiements_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDDataSet.Paiement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PaiementTableAdapter.Fill(Me.BDDataSet.Paiement)

    End Sub

    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PaiementBindingSource.AddNew()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
       

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
       

        
        datetimepicker2.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
          
            If TextBox1.Text = "" Or
                TextBox2.Text = "" Or
                TextBox3.Text = "" Or
                TextBox4.Text = "" Or
                TextBox5.Text = "" Or
                TextBox6.Text = "" Or
                TextBox7.Text = "" Then

                MessageBox.Show("Il Faut Remplir Tous Les champs")
            Else

                PaiementBindingSource.EndEdit()
                PaiementTableAdapter.Update(BDDataSet.Paiement)
                MessageBox.Show(" Bien Enregistrer ")

                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = False
                TextBox6.Enabled = False
                TextBox7.Enabled = False



                DateTimePicker2.Enabled = False

            End If

        Catch ex As Exception
            MessageBox.Show("Ereur")
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If MessageBox.Show(" Vous Voulez Vraiment Supprimer Ce patient ", " Suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                PaiementBindingSource.RemoveCurrent()
                PaiementTableAdapter.Update(BDDataSet.Paiement)


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
       
        DateTimePicker2.Enabled = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If MessageBox.Show(" Voulez Vous Vraiment Enregistrer ces Modfifications  ", " modification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            PaiementBindingSource.EndEdit()
            PaiementTableAdapter.Update(BDDataSet.Paiement)
            MessageBox.Show(" Votre Modification à Bien Effectué")
        End If
    End Sub

    Private Sub CINToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CINToolStripButton.Click
        Try
            Me.PaiementTableAdapter.CIN(Me.BDDataSet.Paiement, CINToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Me.PaiementTableAdapter.CIN(Me.BDDataSet.Paiement, TextBox20.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PaiementBindingSource.MoveFirst()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PaiementBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PaiementBindingSource.MoveNext()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PaiementBindingSource.MoveLast()
    End Sub
End Class