function generateFeed(flines){
var lines = flines.split("\n");

var feedbody;
var indline;

for (i=1;i<lines.length;i++){

indline = lines[i].split("|");

//name|workouttype|distance|duration|sdatetime|pace|shoes
feedbody+="<div class=\"panel panel-default\">  <div class=\"panel-heading\">  <h3 class=\"panel-title\"> " + indline[0] + "</h3> <br>  </div>  <div class=\"panel-body\"> <b> Type: </b> " + indline[1] + " <br> <b> Distance: </b> " + indline[2] + " miles <br> <b> Duration: </b>" + indline[3] + " minutes <br> <b> Pace: </b> " + indline[5] + " <br> <b> Shoes: </b> " + indline[6] + " <br> <b> Notes: </b>" + indline[7];

feedbody+="</div>  <div class=\"panel-footer\">  " + indline[4] + " </div>  </div>";
}
document.getElementById('feed').innerHTML=feedbody;
}

function getList(){
var client = new XMLHttpRequest();
client.open('GET', 'data/workouts.txt');
client.onreadystatechange = function() {
   generateFeed(client.responseText);
}
client.send();
}