// Author: Adnan Masood
// License: MIT
// Problem Statement: https://projecteuler.net/problem=1
// Github: https://github.com/adnanmasood/Euler.Polyglot
// REPL: https://replit.com/@AdnanMasood?path=folder/100DaysOfEuler

fn main() {
    let mut sum = 0;
    for i in 1..1000 {
        // Check if i is a multiple of 3 or 5
        if i % 3 == 0 || i % 5 == 0 {
            // Add i to the sum if it's a multiple of 3 or 5
            sum += i;
        }
    }
    println!("{}", sum);
}
