const express = require('express');
const router = express.Router();
const {getHomepage, CreateUsser} = require('../controller/homeControl');




router.get('/xyz', (req, res) => {
    res.send('Hello World! and mE MAY BEO')
})

router.get('/abc', (req, res) => {
    res.render('start.ejs')
})

router.get('/', getHomepage);

router.post('/create-user', CreateUsser);




module.exports = router;