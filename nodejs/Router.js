import Router from 'express'
import PostController from './Controllers/PostController.js'


const router = new Router()

router.post('/registration', PostController.create)
router.get('/posts', PostController.getAll)
router.get('/posts/:id', PostController.getOne)
router.put('/users', PostController.update)
router.delete('/users/:id', PostController.delete)


export default router
