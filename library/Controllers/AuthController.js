const User = require('../Models/User');
const bcrypt = require('bcryptjs');
const jwt = require('jsonwebtoken');
const mongoose = require("mongoose");
const {validationResult} = require ('express-validator')
const {secret} = require ('../config')

const generateAccessToken = (id, username) => {
    const payload = {
        id,
        username
    }
    return jwt.sign(payload, secret, {expiresIn: '24h'})
}


class AuthController {
    async registration (req,res) {
        try {
            const errors = validationResult(req)
            if (!errors.isEmpty()) {
                return res.status(400).json({message: "Ошибка при регистрации", errors})
            }
            const {email, password} = req.body;
            const candidate = await User.findOne({email});
            if (candidate)
                return res.status(400).json({message:"Пользователь с таким именем уже существует"});
            const hashPassword = bcrypt.hashSync(password, 8);
            const user = new User({email, password: hashPassword});
            await user.save();
            return res.redirect('/auth/registration');
        }catch (e) {
            console.log(e);
        }
    }
    async login (req,res) {
        try {
            const {email, password} = req.body;
            const user = await User.findOne({email})
            if (!user){
                return res.status(400).json({message:`Пользователь ${email} не найден`})
            }
            const validPassword = bcrypt.compareSync(password, user.password)
            if (!validPassword){
                return res.status(400).json({message:`Введен неверный пароль`})
            }
            const token = generateAccessToken(user._id, user.email)
            return res.json({token})
        }catch (e) {
            console.log(e);
        }
    }
}

module.exports = new AuthController()




