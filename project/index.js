const express = require('express')
const PORT = process.env.PORT || 5000
const AuthRouter = require('./Routers/AuthRouter')
const mongoose = require('mongoose')

const app = express()

app.use(express.json())
app.use('/auth', AuthRouter)

const start = async () => {
    try {
        await mongoose.connect(`mongodb+srv://user:user@cluster0.kxo8w.mongodb.net/myFirstDatabase?retryWrites=true&w=majority`)
        app.listen(PORT, () => console.log(`Server start on port ${PORT}`))
    } catch (e) {
        console.log(e)
    }
}
start()
  
