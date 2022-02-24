const express = require('express');

const IndexRouter = require('./Routes/index')

const app = express();
const port = 3000;
const DB_URL = 'mongodb+srv://user:5841495@library.rrbzq.mongodb.net/myFirstDatabase?retryWrites=true&w=majority'

app.use(express.json());

// движок шаблонизатора
app.set('view engine', 'ejs');

// подключение шаблонов
app.set('/views', express.static('views'));

// радача статики (сss, png и т.д)
app.use('/public', express.static('public'))

// Маршруты сайта

//Главная страница
app.use('/', IndexRouter)


app.listen(port, () => {
    console.log(`Example app listening on port ${port}`)
})