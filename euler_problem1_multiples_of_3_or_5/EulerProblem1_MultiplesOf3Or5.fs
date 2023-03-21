// Author: Adnan Masood
// License: MIT
// Problem Statement: https://projecteuler.net/problem=1
// Github: https://github.com/adnanmasood/Euler.Polyglot
// REPL: https://replit.com/@AdnanMasood?path=folder/100DaysOfEuler

open System

let mutable sum = 0
for i in 1 .. 999 do
    // Check if i is a multiple of 3 or 5
    if i % 3 = 0 || i % 5 = 0 then
        // Add i to the sum if it's a multiple of 3 or 5
        sum <- sum + i

printfn "%d" sum
