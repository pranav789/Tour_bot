var express = require('express');
var app = express();
var mongoose = require("mongoose");

app.use(express.json());

app.post('/api2/', function (req, res) {  
  var reply;
  
  mongoose.connect("mongodb://localhost/DBName");
  console.log(req.body);  
  var query = {$and:[{ "location": req.body.location}, {"class" : req.body.class}]};/// query on mongo
  var Schema = mongoose.Schema;
  Schema = {
        "location":String,
        "class":String,
        "text":String,
        "link":String,
        "title" : String,
        "button":String,
        "subtitle" : String
           }

  var collection = "testdbs"; //collection name
  var userModel;
  if (mongoose.models.userModel) {
    userModel = mongoose.model(collection);
  }
  else {
     userModel = mongoose.model(collection,Schema);}
  userModel.find(query,function(err,userObj){

    if(err){
      context.done();
      console.log(err);
      reply = err;
    }
    
    else{
      console.log("Found :",userObj);
      reply = userObj;
      res.send(reply);
      delete mongoose.connection.models[collection];
    }
  });

  console.log("Post Called ...");

});
app.post('/api3/', function (req, res) {  
  var reply;
  
  mongoose.connect("mongodb://localhost/DBName");
  console.log(req.body);  
  var query =  {"place" : req.body.place};/// query on mongo
  var Schema = mongoose.Schema;
  Schema = {
        "location":String,
        "class":String,
        "text":String,
        "link":String,
        "title" : String,
        "button":String,
        "subtitle" : String,
        "statepl":String  ,
        "place":String
           }
  
  var collection = "testdbs";
  var userModel;
  if (mongoose.models.userModel) {
    userModel = mongoose.model(collection);
  }
  else {
     userModel = mongoose.model(collection,Schema);}
  userModel.find(query,function(err,userObj){

    if(err){
      context.done();
      console.log(err);
      reply = err;
    }
    
    else{
      console.log("Found :",userObj);
      reply = userObj;
      res.send(reply);
      delete mongoose.connection.models[collection];
    }
  });

 
  console.log("Post Called ...");

});

var server = app.listen(8081, function () {

 var host = server.address().address
  var port = server.address().port
  console.log("Example app listening at http://%s:%s", host, port)
})