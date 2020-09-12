type A = int * int
type B = {FirstName:string; LastName:string}
type C = Circle of int | Rectangle of int * int

let a = (1,1)

let b = { FirstName="Bob"; LastName="Smith" }

let c = Circle 99

let c' = Rectangle (2,1)
