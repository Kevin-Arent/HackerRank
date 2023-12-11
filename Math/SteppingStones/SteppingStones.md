
# Stepping Stones Game Problem

## Problem Statement

Bob plays a game called "Stepping Stones" where he can move to certain blocks if he can reach the Nth block in a specific pattern of moves.

## Input Format

- The first line of input contains an integer `T` denoting the number of times Bob plays this game.
- Each of the next `T` lines contains a single integer `N` denoting the Nth block.

## Output Format

- If Bob is able to reach Nth block, print "Go On Bob" with the number of moves required to reach the Nth block, separated by a space.
- If Bob is not able to reach the Nth block, print "Better Luck Next Time".

## Constraints

\[
1 \leq T \leq 10^5
\]
\[
1 \leq N \leq 10^{18}
\]

## Sample Input

```
1
2
```

## Sample Output

```
Better Luck Next Time
```

## Explanation

Bob can jump to the 1st Block. From here, he is allowed to make a move to the 3rd Block only. So, he cannot step onto the 2nd Block.


