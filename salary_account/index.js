const express = require('express');
const router = require('./routes/route')
const app = express();
const port = 5000;

app.set('view engine', 'ejs');
app.set('views', './views');
app.use(express.static('public'));
app.use(express.json());

app.use('/api', router)

app.listen(port , () => {
    console.log('Server start on port', port);
})