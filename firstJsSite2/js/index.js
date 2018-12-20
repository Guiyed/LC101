'use strict';

// Everything here runs before the document loads

$(document).ready(function(){
    // Everything here runs AFTER the document loads

    let number = 0;
    $('.counterbox').html( number );
    $('.button#add').click( function(){
        number += 1;
    } );

    $('.button#remove').click( function(){
        if( number <= 1 ){
            number = 0;
        }else{
            number -= 1;
        }
    } );

    $('.button#reset').click( function(){
        number = 0;
    } );

    $('.button').click( function(){
        $('.counterbox').html( number );
    } );
});
