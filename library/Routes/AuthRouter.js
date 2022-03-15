const express = require('express');
const bodyParser = require('body-parser');
const AuthController = require('../Controllers/AuthController')
const {check, body} = require('express-validator')
const AuthMiddleware = require('../MiddleWare/AuthMiddleWare')

const router = express.Router();
const urlencodedParser = bodyParser.urlencoded({extended: false});


router
    .get('/registration', function (req,res){
        res.render('../views/registration')
})

router.post('/registration', urlencodedParser, [
    check('username', 'Логин должен быть электронной почтой').isEmpty(),
    check('password', 'Пароль должен быть больше 4 и меньше 10 символов').isLength({min:4, max:10})
], AuthController.registration)

router.get('/login', function (req,res){
    res.render('../views/login');
})

router.post('/login', urlencodedParser, AuthController.login)

router.get('/after', AuthMiddleware, function (req,res){
    res.json({message:"Здесь должна быть сраница "})
})

module.exports = router