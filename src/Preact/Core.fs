namespace Preact

open Fable.Core

type VDom = interface end

[<AutoOpen>]
module Core =

    [<ImportMember("preact")>]
    let render (vDom: VDom) (node: Browser.Types.HTMLElement): obj = jsNative
