namespace Construct.Map

type E<'a> = 
    | E of 'a

module E =
    let rtn x = E x

    let bind (binder: 'a -> E<'b>) (e: E<'a>): E<'b> =
        let (E a) = e
        binder a

    let apply eF e =
        let map f = f >> rtn |> bind
        eF |> bind (fun f -> map f e)

    // let map (f: 'a -> 'b): E<'a> -> E<'b> = 
