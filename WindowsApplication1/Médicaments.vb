Public Class Médicaments

    Private Sub Médicaments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDDataSet.Médicaments'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.MédicamentsTableAdapter.Fill(Me.BDDataSet.Médicaments)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If MessageBox.Show(" Vous Voulez Vraiment Supprimer Ce patient ", " Suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                MédicamentsBindingSource.RemoveCurrent()
                MédicamentsTableAdapter.Update(BDDataSet.Médicaments)


            End If
        Catch es As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
       
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show(" Voulez Vous Vraiment Enregistrer ces Modfifications  ", " modification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            MédicamentsBindingSource.EndEdit()
            MédicamentsTableAdapter.Update(BDDataSet.Médicaments)
            MessageBox.Show(" Votre Modification à Bien Effectué")
        End If
    End Sub

    Private Sub MEdToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEdToolStripButton.Click
        Try
            Me.MédicamentsTableAdapter.MEd(Me.BDDataSet.Médicaments, Nom_MédicamentToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MédicamentsBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MédicamentsBindingSource.MoveNext()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Me.MédicamentsTableAdapter.MEd(Me.BDDataSet.Médicaments, TextBox20.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub
End Class