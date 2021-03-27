const express = require('express');
const router = express.Router();
router.get('/',(req,res)=>{

    res.send('<H1>Public View </H1> <p>  <a href="</p>">Private </a> </p><p><a href="</p>">Foo</a> </p>');

});


module.exports = router;
