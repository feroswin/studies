const express = require('express');
const mongoose = require('mongoose')
const AuthRouter = require('./Routes/AuthRouter')
const path = require('path')

const app = express();
const port = 3000;
const DB_URL = 'mongodb+srv://user:5841495@library.rrbzq.mongodb.net/myFirstDatabase?retryWrites=true&w=majority'

app.use(express.json());
// движок шаблонизатора
app.set('view engine', 'ejs');

// подключение шаблонов
app.set('views', path.join(__dirname, 'views'));

// радача статики (сss, png и т.д)
app.use('/public', express.static(path.join(__dirname, 'public')));

// Маршруты сайта

//Главная страница
app.use('/Auth', AuthRouter);

const start = async () => {
    try {
        mongoose.connect(DB_URL);
        app.listen(port, () => {
            console.log(`Example app listening on port ${port}`);
        })
    }
    catch (e) {
        console.log(e);
    }
}
start()