namespace Preact

open Fable.Core
open Fable.Core.JsInterop

type VDom = interface end

type 'a FunctionComponent = 'a -> VDom

[<AutoOpen>]
module Core =

    [<ImportMember("preact")>]
    let inline render (vDom: VDom) (node: Browser.Types.HTMLElement): obj = jsNative


    [<Import("h", "preact")>]
    let inline private h (tag: 'a FunctionComponent) (props: 'a) : VDom = jsNative


    let inline Of (comp: 'a FunctionComponent): 'a FunctionComponent = h comp
