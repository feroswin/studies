const express = require('express');
const bodyParser = require('body-parser');

const router = express.Router();
const urlencodedParser = bodyParser.urlencoded({extended: false});



router.get('/', function (req,res){
    res.render('index')
})

router.post('/', urlencodedParser, function (req,res){
    console.log(req.body);
    res.render('index');
})


module.exports = router