namespace Construct.Apply

type E<'a> = 
    | E of 'a

module E =
    let rtn x = E x

    let map (f: 'a -> 'b) (e: E<'a>): E<'b> = 
        let (E a) = e
        a |> f |> rtn

    let bind (binder: 'a -> E<'b>) (e: E<'a>): E<'b> =
        let (E a) = e
        binder a

    // let apply (ef: E<'a -> 'b>) (e: E<'a>): E<'b> =

    // let apply' (ef: E<'a -> 'b>): E<'a> -> E<'b> =
