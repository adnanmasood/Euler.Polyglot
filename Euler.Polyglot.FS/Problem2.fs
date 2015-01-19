namespace Euler.Polyglot.FS
open System

type Problem2() = 
    //member this.Total = [1..999] |> List.map (fun i -> if i % 5 = 0 || i % 3 = 0 then i else 0) |> List.sum
    let fibonacciSeq = Seq.unfold (fun (current, next) -> Some(current, (next, current + next))) (0, 1)
    let fibTotal =
        fibonacciSeq
        |> Seq.takeWhile (fun n -> n < 4000000)
        |> Seq.filter (fun n -> n % 2 = 0)
        |> Seq.sum
    
//Problem2();;