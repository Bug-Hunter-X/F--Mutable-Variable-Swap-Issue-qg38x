# F# Mutable Variable Swap Issue

This example demonstrates a common issue in F# when working with mutable variables and function scope.
The `swap` function intends to swap the values of two mutable variables, but due to scoping issues, it doesn't modify the original variables.
The solution demonstrates how to correctly swap mutable variables, addressing the scope issue.

## Bug
The `bug.fs` file contains the code demonstrating the issue. The `swap` function appears to swap `x` and `y`, but the original variables remain unchanged after the function call.

## Solution
The `bugSolution.fs` file demonstrates the correct approach using the `swap` function which correctly swaps the values of the global variables x and y.