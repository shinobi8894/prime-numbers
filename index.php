<?php
// A school method based PHP program to
// check if a number is prime
 
// function check whether a number
// is prime or not
function isPrime($n)
{
    // Corner case
    if ($n <= 1)
        return false;
 
    // Check from 2 to n-1
    for ($i = 2; $i < $n; $i++)
        if ($n % $i == 0)
            return false;
 
    return true;
}
 
// Driver Code
if(isPrime(11))
    echo("true");
else
    echo("false");
 
?>