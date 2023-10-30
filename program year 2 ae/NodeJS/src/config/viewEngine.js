const path = require('path');

const configViewEngine = (app) => {
    app.set('views', path.join('./src', 'views'));
    app.set('view engine', 'html');
}

module.exports = configViewEngine;