﻿// $begin{copyright}
//
// This file is part of WebSharper
//
// Copyright (c) 2008-2014 IntelliFactory
//
// Licensed under the Apache License, Version 2.0 (the "License"); you
// may not use this file except in compliance with the License.  You may
// obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
// implied.  See the License for the specific language governing
// permissions and limitations under the License.
//
// $end{copyright}

namespace WebSharper.UI.Next.Server

open System
open WebSharper.Web
open WebSharper.UI.Next
open WebSharper.Sitelets
open WebSharper.Sitelets.Content

module Doc =

    /// Converts a WebSharper INode to a Doc.
    val WebControl : INode -> Doc

[<Sealed>]
type Content =

    /// Converts a `Doc` to a sitelet Page.
    /// `Doc` values that correspond to HTML fragements are converted to full documents.
    static member Page : Doc -> Async<Content<'Action>>

    /// Converts a `Doc` to a sitelet Page.
    /// `Doc` values that correspond to HTML fragements are converted to full documents.
    [<Obsolete "Use Content.Page(...) instead">]
    static member Doc : Doc -> Async<Content<'Action>>

    static member inline Page
        : ?Body: #seq<#INode>
        * ?Head: #seq<#INode>
        * ?Title: string
        * ?Doctype: string
        -> Async<Content<'Action>>

    static member inline Page : Page -> Async<Content<'Action>>