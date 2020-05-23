namespace App

open Preact
open Preact.Html

module App =

    let document = Browser.Dom.document

    let elm = document.createElement "div"

    ignore <| document.body.appendChild elm


    type FirstCompProps =
        { [<CompiledName("class")>]
          className: string option
          title: string option
          children: VDom seq }


    let FirstComp = Of <| fun (props: FirstCompProps) ->
        let title = defaultArg props.title ""
        div [ Class "first-comp"; Title title ] props.children

    let RootComp = Of <| fun (props: obj) ->
        div [ Id "root" ] [
            text "welcome text";
            text "I like it";
            FirstComp
                { className = None
                  title = Some "world"
                  children = [
                    none
                    text "Nested children"
                    none
                    text "Second children"
                  ] }
            FirstComp
                { className = Some "another"
                  title = None
                  children = []
                }
        ]

    let _root = render (RootComp {| |}) elm
