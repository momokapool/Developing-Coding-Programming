require('dotenv').config();

const express = require('express')
const app = express()
const port = process.env.PORT || 3001;
const hostname = process.env.HOST_NAME;
/* process.env la enviroment variable, them vao de cho cac bien nhu la cong hay
host name co the bi doi khi sang may khac, dung cho cac bien ko co dinh
*/


//static file config
app.use(express.static(path.join(__dirname, 'public')));

app.set('view engine', 'html')

app.get('/', (req, res) => {
    res.send('Hello World! and mE MAY BEO')
})

app.get('/abc', (req, res) => {
    res.render('start.html')
})



app.listen(port, hostname, () => {
    console.log(`Example on port ${port}`)             
})