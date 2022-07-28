Imports System.Data.SqlClient

Public Class Rendez_vous
   




 

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        RendezvousBindingSource.AddNew()
        textbox1.Text = ""
        textbox2.Text = ""
        textbox3.Text = ""
        textbox4.Text = ""
        textbox4.Text = ""
        textbox5.Text = ""
        textbox6.Text = ""
        textbox7.Text = ""
        textbox7.Text = ""


        textbox1.Enabled = True
        textbox2.Enabled = True
        textbox3.Enabled = True
        textbox4.Enabled = True
        textbox4.Enabled = True
        textbox5.Enabled = True
        textbox6.Enabled = True
        textbox7.Enabled = True
        textbox7.Enabled = True


        DateTimePicker1.Enabled = True
    End Sub

    Private Sub Rendez_vous_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDDataSet._Rendez_vous'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Rendez_vousTableAdapter.Fill(Me.BDDataSet._Rendez_vous)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If textbox1.Text = "" Or
                textbox2.Text = "" Or
                textbox3.Text = "" Or
                textbox4.Text = "" Or
                textbox5.Text = "" Or
                TextBox6.Text = "" Or
                textbox7.Text = "" Then



                MessageBox.Show("Il Faut Remplir Tous Les champs")
            Else

                RendezvousBindingSource.EndEdit()
                Rendez_vousTableAdapter.Update(BDDataSet._Rendez_vous)
                MessageBox.Show(" Bien Enregistrer ")

                textbox1.Enabled = False
                textbox2.Enabled = False
                textbox3.Enabled = False
                textbox4.Enabled = False
                textbox4.Enabled = False
                textbox5.Enabled = False
                TextBox6.Enabled = False
                textbox7.Enabled = False
                textbox7.Enabled = False


                DateTimePicker1.Enabled = False

            End If

        Catch ex As Exception
            MessageBox.Show("Ereur")
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If MessageBox.Show(" Vous Voulez Vraiment Supprimer Ce Rendez_Vous ", " Suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                RendezvousBindingSource.RemoveCurrent()
                Rendez_vousTableAdapter.Update(BDDataSet._Rendez_vous)


            End If
        Catch es As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button10.Click
        textbox1.Enabled = True
        textbox2.Enabled = True
        textbox3.Enabled = True
        textbox3.Enabled = True
        textbox5.Enabled = True
        TextBox6.Enabled = True
        textbox7.Enabled = True
        
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Me.Rendez_vousTableAdapter.CIN(Me.BDDataSet._Rendez_vous, CINToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CINToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CINToolStripButton.Click
        Try
            Me.Rendez_vousTableAdapter.CIN(Me.BDDataSet._Rendez_vous, CINToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        RendezvousBindingSource.MoveFirst()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RendezvousBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RendezvousBindingSource.MoveNext()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        RendezvousBindingSource.MoveLast()
    End Sub
End Class