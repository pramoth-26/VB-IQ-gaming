Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub finish_MouseEnter(sender As Object, e As EventArgs) Handles finish.MouseEnter
        MessageBox.Show("COMPLETED SUCCESSFULLY")
        Timer1.Enabled = False
        Label6.Text = 60
    End Sub

    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label13.MouseEnter, Label125.MouseEnter, Label124.MouseEnter, Label123.MouseEnter, Label122.MouseEnter, Label121.MouseEnter, Label120.MouseEnter, Label119.MouseEnter, Label118.MouseEnter, Label117.MouseEnter, Label116.MouseEnter, Label115.MouseEnter, Label114.MouseEnter, Label113.MouseEnter, Label112.MouseEnter, Label111.MouseEnter, Label110.MouseEnter, Label109.MouseEnter, Label108.MouseEnter, Label107.MouseEnter, Label106.MouseEnter, Label105.MouseEnter, Label104.MouseEnter, Label103.MouseEnter, Label102.MouseEnter, Label101.MouseEnter, Label100.MouseEnter, Label99.MouseEnter, Label98.MouseEnter, Label97.MouseEnter, Label96.MouseEnter, Label95.MouseEnter, Label94.MouseEnter, Label93.MouseEnter, Label92.MouseEnter, Label91.MouseEnter, Label90.MouseEnter, Label89.MouseEnter, Label88.MouseEnter, Label87.MouseEnter, Label86.MouseEnter, Label85.MouseEnter, Label84.MouseEnter, Label83.MouseEnter, Label82.MouseEnter, Label81.MouseEnter, Label80.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label31.MouseEnter, Label29.MouseEnter, Label14.MouseEnter, Label10.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label2.MouseEnter, Label1.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = Label6.Text - 1
        If Label6.Text = 0 Then
            Timer1.Enabled = False
            MessageBox.Show("yours time over")
            Label6.Text = 60
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Timer1.Enabled = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = False
        Label6.Text = 60
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label30.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label39.Visible = False
        Label40.Visible = False
        Label41.Visible = False
        Label42.Visible = False
        Label126.Visible = False
        Label127.Visible = False
        Label128.Visible = False
        Label129.Visible = False
        Label130.Visible = False
        Label131.Visible = False
        Label132.Visible = False
        Label133.Visible = False
        Label134.Visible = False
        Label135.Visible = False
        Label136.Visible = False
        Label137.Visible = False


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label30.Visible = True
        Label32.Visible = True
        Label33.Visible = True
        Label34.Visible = True
        Label39.Visible = True
        Label40.Visible = True
        Label41.Visible = True
        Label42.Visible = True
        Label126.Visible = True
        Label127.Visible = True
        Label128.Visible = True
        Label129.Visible = True
        Label130.Visible = True
        Label131.Visible = True
        Label132.Visible = True
        Label133.Visible = True
        Label134.Visible = True
        Label135.Visible = True
        Label136.Visible = True
        Label137.Visible = True

    End Sub


End Class
