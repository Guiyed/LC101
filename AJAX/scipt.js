'use strict';

$(document).ready(function(){

  //Always have to send this argumets
  //$.ajax({ url:"", type:"", success:, error:});

  $.ajax({ 
    url:"https://jsonplaceholder.typicode.com/photos", 
    type:"Get", 
    //headers: {},
    success: function(data){
      //console.log(data);

      //for (let i = 0; i < data.length; i++){
      for (let i = 0; i < 100; i++){
        //console.log( data[i]);
        //console.log( data[i].title);
        //$("#gallery").html(data[i].title);
        //$("#gallery").append("<h2>" + data[i].title + "</h2>" + "<br>");
        
        $("#gallery").append(`
          <div class="gallery_item">
            <h5> ${data[i].title}</h5>
            <img src="${ data[i].thumbnailUrl}">
          </div>
        `);
      }

    }, 
    error:function(er){
      console.log(er);
    },
  });

    


});
