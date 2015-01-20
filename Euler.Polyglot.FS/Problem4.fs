module Problem4

open System.Linq
 
let isPalindromic n =
    let charArray = n.ToString().ToCharArray()
    let revCharArray = Array.rev charArray
    charArray.SequenceEqual(revCharArray)
 
let numbers = [100..999]
let products = numbers |> List.collect (fun x -> numbers |> List.map (fun y -> x * y))
let maxPalindromic = products |> Seq.filter isPalindromic |> Seq.max