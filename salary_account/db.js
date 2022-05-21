const Pool = require('pg').Pool;
const pool = new Pool({
    user: "postgres",
    password: "root",
    port: 5000,
    database: "salary_account"
});



module.exports = pool;