namespace Euler.Polyglot.FS

type Problem1() = 
    member this.Total = [1..999] |> List.map (fun i -> if i % 5 = 0 || i % 3 = 0 then i else 0) |> List.sum

//Problem1();;