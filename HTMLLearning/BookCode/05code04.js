var count = 0;
function incCount(){
  count += 1;
  return count;
}

function countIt(){
  $("#counter").html(incCount);
}
