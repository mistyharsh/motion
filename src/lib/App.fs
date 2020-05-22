namespace App

open Preact
open Preact.Html

module App =

    let document = Browser.Dom.document

    let elm = document.createElement "div"
    let _ = document.body.appendChild elm

    let AppNode = div [ Id "hello"] [ str "welcome text" ]

    let x = render AppNode elm
