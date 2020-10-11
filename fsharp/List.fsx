let list1 = [ 2; 3; 4 ]
let list2 = [ 5; 6; 7 ]
let list3 = [ 1; 1; 1; 2; 2; 3 ]
let array1 = [| 1; 2; 3 |]
let asyncList = list1 |> List.map async.Return
