﻿'*************************** Module Header ******************************'
' Module Name:  HtmlSubmit.cs
' Project:	    VBWebBrowserAutomation
' Copyright (c) Microsoft Corporation.
' 
' This class HtmlSubmit represents an HtmlElement with the tag "input" and its 
' type is "submit".
' 
' This source is subject to the Microsoft Public License.
' See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
' All other rights reserved.
' 
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'*************************************************************************'

Imports System.Security.Permissions

Public Class HtmlSubmit
    Inherits HtmlInputElement

    ''' <summary>
    ''' This parameterless constructor is used in deserialization.
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Initialize an instance of HtmlSubmit. This constructor is used by 
    ''' HtmlInputElementFactory.
    ''' </summary>
    <PermissionSetAttribute(SecurityAction.LinkDemand, Name:="FullTrust")>
    Public Sub New(ByVal element As HtmlElement)
        MyBase.New(element.Id)
    End Sub

End Class