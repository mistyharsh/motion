﻿namespace Preact

open Fable.Core
open Fable.Core.JsInterop


type HtmlAttr =
    | Alt of string
    | Class of string
    | Disabled of bool
    | For of string
    | Href of string
    | Id of string
    | Name of string
    | Placeholder of string
    | Src of string
    | Title of string
    | Target of string
    | Type of string
    | Value of string

module Html =

    // TODO: Why this doesn't work
    // [<Import("h", "preact")>]
    // let private hh: tag: obj * props: obj * [<ParamList>] children: VDom seq -> VDom = jsNative

    [<Import("h", "preact")>]
    let inline private h (tag: obj) (props: obj) ([<ParamList>] children: VDom seq) : VDom = jsNative

    let inline private domEl (tag: string) (props: HtmlAttr seq) (children: VDom seq): VDom = h tag (keyValueList CaseRules.LowerFirst props) children

    let inline private voidEl (tag: string) (props: HtmlAttr seq) = h tag (keyValueList CaseRules.LowerFirst props) []

    [<Emit("$0")>]
    let text (text: string) : VDom = jsNative

    [<Emit("null")>]
    let none : VDom = jsNative

    let inline a props children = domEl "a" props children
    let inline abbr props children = domEl "abbr" props children
    let inline address props children = domEl "address" props children
    let inline article props children = domEl "article" props children
    let inline aside props children = domEl "aside" props children
    let inline audio props children = domEl "audio" props children
    let inline b props children = domEl "b" props children
    let inline bdi props children = domEl "bdi" props children
    let inline bdo props children = domEl "bdo" props children
    let inline big props children = domEl "big" props children
    let inline blockquote props children = domEl "blockquote" props children
    let inline body props children = domEl "body" props children
    let inline button props children = domEl "button" props children
    let inline canvas props children = domEl "canvas" props children
    let inline caption props children = domEl "caption" props children
    let inline cite props children = domEl "cite" props children
    let inline code props children = domEl "code" props children
    let inline colgroup props children = domEl "colgroup" props children
    let inline data props children = domEl "data" props children
    let inline datalist props children = domEl "datalist" props children
    let inline dd props children = domEl "dd" props children
    let inline del props children = domEl "del" props children
    let inline details props children = domEl "details" props children
    let inline dfn props children = domEl "dfn" props children
    let inline dialog props children = domEl "dialog" props children
    let inline div props children = domEl "div" props children
    let inline dl props children = domEl "dl" props children
    let inline dt props children = domEl "dt" props children
    let inline em props children = domEl "em" props children
    let inline fieldset props children = domEl "fieldset" props children
    let inline figcaption props children = domEl "figcaption" props children
    let inline figure props children = domEl "figure" props children
    let inline footer props children = domEl "footer" props children
    let inline form props children = domEl "form" props children
    let inline h1 props children = domEl "h1" props children
    let inline h2 props children = domEl "h2" props children
    let inline h3 props children = domEl "h3" props children
    let inline h4 props children = domEl "h4" props children
    let inline h5 props children = domEl "h5" props children
    let inline h6 props children = domEl "h6" props children
    let inline head props children = domEl "head" props children
    let inline header props children = domEl "header" props children
    let inline hgroup props children = domEl "hgroup" props children
    let inline html props children = domEl "html" props children
    let inline i props children = domEl "i" props children
    let inline iframe props children = domEl "iframe" props children
    let inline ins props children = domEl "ins" props children
    let inline kbd props children = domEl "kbd" props children
    let inline label props children = domEl "label" props children
    let inline legend props children = domEl "legend" props children
    let inline li props children = domEl "li" props children
    let inline main props children = domEl "main" props children
    let inline map props children = domEl "map" props children
    let inline mark props children = domEl "mark" props children
    let inline menu props children = domEl "menu" props children
    let inline meter props children = domEl "meter" props children
    let inline nav props children = domEl "nav" props children
    let inline noscript props children = domEl "noscript" props children
    let inline object props children = domEl "object" props children
    let inline ol props children = domEl "ol" props children
    let inline optgroup props children = domEl "optgroup" props children
    let inline option props children = domEl "option" props children
    let inline output props children = domEl "output" props children
    let inline p props children = domEl "p" props children
    let inline picture props children = domEl "picture" props children
    let inline pre props children = domEl "pre" props children
    let inline progress props children = domEl "progress" props children
    let inline q props children = domEl "q" props children
    let inline rp props children = domEl "rp" props children
    let inline rt props children = domEl "rt" props children
    let inline ruby props children = domEl "ruby" props children
    let inline s props children = domEl "s" props children
    let inline samp props children = domEl "samp" props children
    let inline script props children = domEl "script" props children
    let inline section props children = domEl "section" props children
    let inline select props children = domEl "select" props children
    let inline small props children = domEl "small" props children
    let inline span props children = domEl "span" props children
    let inline strong props children = domEl "strong" props children
    let inline style props children = domEl "style" props children
    let inline sub props children = domEl "sub" props children
    let inline summary props children = domEl "summary" props children
    let inline sup props children = domEl "sup" props children
    let inline table props children = domEl "table" props children
    let inline tbody props children = domEl "tbody" props children
    let inline td props children = domEl "td" props children
    let inline textarea props children = domEl "textarea" props children
    let inline tfoot props children = domEl "tfoot" props children
    let inline th props children = domEl "th" props children
    let inline thead props children = domEl "thead" props children
    let inline time props children = domEl "time" props children
    let inline title props children = domEl "title" props children
    let inline tr props children = domEl "tr" props children
    let inline u props children = domEl "u" props children
    let inline ul props children = domEl "ul" props children
    let inline var props children = domEl "var" props children
    let inline video props children = domEl "video" props children


    // Void element
    let inline area props = voidEl "area" props
    let inline ``base`` props = voidEl "base" props
    let inline br props = voidEl "br" props
    let inline col props = voidEl "col" props
    let inline embed props = voidEl "embed" props
    let inline hr props = voidEl "hr" props
    let inline img props = voidEl "img" props
    let inline input props = voidEl "input" props
    let inline keygen props = voidEl "keygen" props
    let inline link props = voidEl "link" props
    let inline menuitem props = voidEl "menuitem" props
    let inline meta props = voidEl "meta" props
    let inline param props = voidEl "param" props
    let inline source props = voidEl "source" props
    let inline track props = voidEl "track" props
    let inline wbr props = voidEl "wbr" props