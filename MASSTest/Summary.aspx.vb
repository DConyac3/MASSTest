Imports System.Data.DataTableExtensions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim dt As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dt = CType(Session("db"), DataTable)
        GridView1.DataSource = dt
        GridView1.DataBind()

    End Sub

    Protected Sub CalcPageButton_Click(sender As Object, e As EventArgs) Handles CalcPageButton.Click

        Response.Redirect("Calculate.aspx")

    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        dt.Clear()
        Response.Redirect("Summary.aspx")

    End Sub
End Class