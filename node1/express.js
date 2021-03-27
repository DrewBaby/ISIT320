const http = require('http');
const express = require('express');
const app = express();

// app.get ('/', (req,res)=>{

//     res.end('Payload');
// });


const publicRouter = require ('./routes/public');
const privateRouter = require ('./routes/private');
const publicFoo = require ('./routes/foo');

app.use ('/', publicRouter);
app.use ('/p', privateRouter);
app.use ('/f', publicFoo);

const server = app.listen(3000,()=>{   
    var port = server.address().port;
    var host = server.address().address;
    console.log (`Server is running on Socket ${host}${port}`);
    
      
});