module Problem4

open System
 
let findFactorsOf(n:int64) =
    let upperBound = int64(Math.Sqrt(double(n)))
    [2L..upperBound] |> Seq.filter (fun x -> n % x = 0L)
 
let isPrime(n:int64) = findFactorsOf(n) |> Seq.length = 0
 
let findMaxPrimeFactorOf(n:int64) =
    let upperBound = int64(Math.Sqrt(double(n)))
 
    [2L..upperBound]
    |> Seq.filter (fun x -> n % x = 0L)
    |> Seq.filter isPrime
    |> Seq.max
 
let maxPrime = findMaxPrimeFactorOf(600851475143L)
//val maxPrime : int64 = 6857L