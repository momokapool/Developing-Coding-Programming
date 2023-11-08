const getHomepage = (req, res) =>{
    return res.render('start.ejs')
}

const CreateUsser = (req, res) =>{
    console.log(">>> req.body", req.body);
    res.send("tin chuan chua a");
}

module.exports = {
    getHomepage, CreateUsser
}

