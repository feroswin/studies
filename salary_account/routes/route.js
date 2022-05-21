const Router = require('express')
const router = new Router();
const controller = require('../controllers/auth_controller')



router.get('/registration', ((req, res) => {
    res.render('registration')
}))
router.post('/registration', controller.registration)



router.get('/login', ((req, res) => {
    res.render('login')
}))
router.post('/login', controller.login);



router.get('/logout', ((req, res) => {
    res.render('logout')
}))
router.post('/logout')


router.get('/refresh');

module.exports = router;