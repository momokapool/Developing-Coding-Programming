const connection = require('../config/database.js')

const getHomepage = (req, res) => {
    connection.connect(function (err) {
        if (err) throw err
        console.log("Connected!");
        connection.query(`SELECT * FROM Users`, function (err, result) {
            if (err) throw err;
            console.log(result);
        });
    });
    return res.render('start.ejs')
}


//render ra file frontend input, phai viet dung thu tu req truoc res sau
const getCreateUser = (req, res) => {
    return res.render('create_user.ejs')
}

//create new user
const postCreateUser = (req, res) => {
    let name = req.body.name;
    let city = req.body.city;
    let email = req.body.email;

    console.log(">>> req.body", name, city, email);
    //res.send("tin chuan chua a");

    //var query = `INSERT INTO Users (email, name, city) VALUES (?, ?, ?)`[email, name, city],;

    connection.connect(function (err) {
        if (err) throw err
        console.log("Connected!");
        connection.query(`INSERT INTO Users (email, name, city) VALUES (?, ?, ?)`, [email, name, city], function (err, result) {
            if (err) throw err;
            console.log("1 record inserted");
            res.send('ok');
        });
    });
}



module.exports = {
    getHomepage, getCreateUser, postCreateUser
}

