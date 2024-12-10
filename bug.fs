let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10, not 10 20 as one might expect

//The problem is that swap function is modifying the local copies of x and y, not the global variables x and y defined outside the function. 
//The swap function is changing the mutable values of x and y within its own scope. Therefore, the global variables x and y remain unchanged after calling the swap function. 