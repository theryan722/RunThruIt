function generateFeed(){
var lines = getList.split("\n");

}

function getList(){
var client = new XMLHttpRequest();
client.open('GET', '../data/workouts.txt');
client.onreadystatechange = function() {
  return client.responseText;
}
client.send();
}

<div class="panel panel-default">
				<div class="panel-heading">
					<h3 class="panel-title">
						[Name]
					</h3>
				</div>
				<div class="panel-body">
					<strong>Type:</strong>
					<div>
						<strong>Distance:</strong>
					</div>
					<div>
						<strong>Duration:</strong>
					</div>
					<div>
						<strong>Pace:</strong>
					</div>
					<div>
						<strong>Shoes:</strong>
					</div>
				</div>
				<div class="panel-footer">
					[Time/Date]
				</div>
			</div>