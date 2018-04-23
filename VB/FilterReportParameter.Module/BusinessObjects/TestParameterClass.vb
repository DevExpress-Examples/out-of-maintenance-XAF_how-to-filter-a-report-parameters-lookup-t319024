Imports System
Imports System.Linq
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.Persistent.BaseImpl

Namespace FilterReportParameter.Module.BusinessObjects
    <DefaultClassOptions, DefaultProperty("Name")> _
    Public Class DemoParameter
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Name() As String
            Get
                Return GetPropertyValue(Of String)("Name")
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", value)
            End Set
        End Property
        Public Property Category() As String
            Get
                Return GetPropertyValue(Of String)("Category")
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Category", value)
            End Set
        End Property
    End Class
End Namespace
