Imports System
Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.BaseImpl
Imports FilterReportParameter.Module.BusinessObjects

Namespace FilterReportParameter.Module.DatabaseUpdate
    ' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppUpdatingModuleUpdatertopic.aspx
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim name As String = "Test1"
            Dim theObject As DemoClass = ObjectSpace.FindObject(Of DemoClass)(CriteriaOperator.Parse("Name=?", name))
            If theObject Is Nothing Then
                theObject = ObjectSpace.CreateObject(Of DemoClass)()
                theObject.Name = name
                CreateParameters()
                theObject.Parameter = ObjectSpace.FindObject(Of DemoParameter)(CriteriaOperator.Parse("Name=?", "Param 102"))
            End If
            name = "Test2"
            theObject = ObjectSpace.FindObject(Of DemoClass)(CriteriaOperator.Parse("Name=?", name))
            If theObject Is Nothing Then
                theObject = ObjectSpace.CreateObject(Of DemoClass)()
                theObject.Name = name
                theObject.Parameter = ObjectSpace.FindObject(Of DemoParameter)(CriteriaOperator.Parse("Name=?", "Param 202"))
            End If
        End Sub
        Private Sub CreateParameters()
            For i As Integer = 0 To 999
                Dim obj As DemoParameter = ObjectSpace.CreateObject(Of DemoParameter)()
                obj.Name = "Param " & i
                obj.Category = "Category " & i Mod 10
                'if (i / 1000 == 0)
                '{
                '    ObjectSpace.CommitChanges();
                '}
            Next i
        End Sub
    End Class
End Namespace
