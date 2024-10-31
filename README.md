# box-filling-with-cubes
Algorithm to determine the minimum number of cubes needed to completely fill a box with given dimensions using a set of cubes with side lengths in powers of 2.

# Problem Description
Tis program aims to solve the problem of filling a given box with cubes of specific sizes. The box has integer dimensions: 'length x width x height', and a set of cubes are provided with side lengths that are power of 2, such as 1x1x1, 2x2x2, 4x4x4, etc.

# Input
- The input file contains one or more lines.
- Each line specifies a problem, with the first three integers representing the box dimensions.
- The subsequent numbers represents available cubes in a list form, where each position corresponds to a specific cube size ( from smallest to largest).

For Example:
2 3 4 5 6
This specifies a box with dimensions 2x3x4 and cube counts:
- 5 cubes of 1x1x1
- 6 cubes of 2x2x2

  ### Output
  The program will output the smallest number of cubes needed to fill each box. If it's nto possible to fill a box completely with provided cubes, then it will output '-1' for that case.
  
### Examples
Given a file `problems.txt` with the following content: 
10 10 10 2000 10 10 10 900 4 4 8 10 10 1
Expected output:
1000 -1 9

## Running the Program
1. Clone this repository.
2. Ensure you have C# Dev Kit extension (for VSCode) or Visual Studio installed.
3. Run the program using: dotnet run

  
