const express = require('express');
const router = express.Router();
const {getHomepage} = require('../controller/homeControl');


router.get('/xyz', (req, res) => {
    res.send('Hello World! and mE MAY BEO')
})

router.get('/abc', (req, res) => {
    res.render('start.html')
})

router.get('/', getHomepage);


module.exports = router;