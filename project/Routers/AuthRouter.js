const Router = require('express')
const router = new Router()
const AuthController = require('../Controllers/AuthController')
const {check} = require('express-validator')

router.post('/registration', [
    check('username', 'Имя не может быть пустым').notEmpty(),
    check('password', 'пароль должен быть более 4 и меньше 18 символов').isLength({min:4, max:18})
], AuthController.registration)
router.post('/login', AuthController.login)
router.get('/users', AuthController.getUsers)

module.exports = router