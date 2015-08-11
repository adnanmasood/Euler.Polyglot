module Problem9

open System.IO

let isPythagoreanTri(numbers : int list) =
    match List.sort(numbers) with
    | [a; b; c] -> a*a + b*b = c*c
    | _ -> false
 
let getTri =
    seq {
        for a = 1 to 1000 do
            for b = 1 to 1000 do
                for c = 1 to 1000 do
                    if a + b + c = 1000 then yield [a; b; c]
    }
 
let pythagoreanTri = getTri |> Seq.filter isPythagoreanTri |> Seq.head
let product = pythagoreanTri |> Seq.fold (fun acc x -> acc * x) 1
