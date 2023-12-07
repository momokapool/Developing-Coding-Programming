const express = require('express');
const router = express.Router();
const {getHomepage, getCreateUser, postCreateUser, getUpdateUser} = require('../controller/homeControl.js');




router.get('/xyz', (req, res) => {
    res.send('Hello World! and mE MAY BEO')
})

router.get('/', getHomepage);

router.get('/create', getCreateUser);
router.get('/update/:id', getUpdateUser);

router.post('/create-user', postCreateUser);




module.exports = router;