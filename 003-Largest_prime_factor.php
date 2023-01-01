<?php

function isPrime($number)
{
    foreach (range(2, $number - 1) as $i) {
        if ($number % $i == 0) {
            return false;
        }
    }
    return true;
}

function largestPrimeFactor($max){
    $x = intval(sqrt($max));
    while($x){
        if($max%$x==0){
            if(isPrime($x)){
                return $x;
            }
        }
        $x--;
        
    }
}

echo largestPrimeFactor(600851475143);