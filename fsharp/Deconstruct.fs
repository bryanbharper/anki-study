type A = int * int
type B = {FirstName:string; LastName:string}
type C = Circle of int | Rectangle of int * int

let a = (1,1)                                  // "construct"

let b = { FirstName="Bob"; LastName="Smith" }  // "construct"

let c = Circle 99                              // "construct"

let c' = Rectangle (2,1)                       // "construct"