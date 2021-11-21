const {Schema} = require('mongoose')
const mongoose = require("mongoose");

const Role = new Schema({
    value: {type: String, unique: true, default: 'USER'}
})

module.exports = mongoose.model('Role', Role)