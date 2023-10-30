require('dotenv').config();

const express = require('express')
const app = express()

/* process.env la enviroment variable, them vao de cho cac bien nhu la cong hay
host name co the bi doi khi sang may khac, dung cho cac bien ko co dinh
*/
const port = process.env.PORT || 3001;
const hostname = process.env.HOST_NAME;

const config = require('./src/config/viewEngine');
const router = require('./src/route/web');




//config template engine
config(app);

//static file config
app.use(express.static(path.join(__dirname, 'public')));

//route hay la dieu huong trang
app.use(router);


app.listen(port, hostname, () => {
    console.log(`Example on port ${port}`)             
})