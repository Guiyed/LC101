'use strict'; // This is not neccesary but it makes the Javascript more reliable

  // --- Everything here runs Before the document loads ---

$(document).ready(function(){
  // --- Everything here runs AFTER the document loads ----

  /*
  // #box Examples
  // <div id="box"></div>
  // <div class="boxes"></div>

  // Vanilla JS
  document.getElementById('box');
  document.getElementsByClassName('boxes')[0];

  // jQuery
  $('#box')
  $('.boxes')[0]
  */
  
  /* You have to declare Variables (middle ground)
  var     // is dynamic
  let     // is dynamic 
  const   // is constant
  
  var banana;
  banana=2;
  banana="apple";   // ALLOWED

  let foo;
  foo=2;
  foo="apple";      // ALLOWED

  const bar = "hello";
  bar = "bye";      // NOT ALLOWED
  */

  
  //$('.counterbox').text("Hello");
  //$('.counterbox').html("<span style='color:red'>Hello</span>");

  let number =0;
  let number2 =0;
  $('.counterbox').html(number);
  $('.counterbox2').html(number2);
  $('.counterbox3').html(number+number2);
  //$('#count').text("Hello");

  $('#count').css('background-color','teal');
  $('#count').css('color','white');
  $('#count').css('border','0');
  
  $('#count').click(function(){
    number++;
    console.log('the button was clicked');
    console.log(number);
    $('.counterbox').html(number);
    $('.counterbox3').html(number+number2);

  });

  $('#count2').click(function(){
    number2++;
    console.log('the button was clicked');
    console.log(number2);
    $('.counterbox2').html(number2);
    $('.counterbox3').html(number+number2);

  });

  /*$('#count').click();
  $('#count').on();
  $('#count').mouseover();
  $('#count').mouse leave();
*/






});

