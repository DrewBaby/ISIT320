const http = require('http');
let serveEntry = (response) =>{
    response.writeHead(200,{"content-type":"text/html"});
    response.write("<h2> This is the Entry point for this app. </h2>");
    response.write("<a href='/nextpage'> Next Page </a>");
    response.end();
}

let serveNextPage = (response) =>{
    response.writeHead(200,{"content-type":"text/html"});
    response.write("<h2> This is the Next Page of this app. </h2>");    
    response.end();
}

let send404Error = (response) =>{
    response.writeHead(404,{"content-type":"text/html"});
    response.write("<h2> What you asked for doesn't exist, yet. </h2>");    
    response.write("<a href='/'> Main Page </a>");
    response.end();
}


let onRequest = (request,response) =>{
    if (request.method == 'GET' && request.url == '/') {
        serveEntry (response);
    }
    else if (request.method == 'GET' && request.url == '/nextpage') {
        console.log ('Next page population');
        serveNextPage(response);
    }
    else {
        console.log ('Error response');
        send404Error (response)

    }
    console.log ('User made a Request');
    console.log (request.url);
    console.log (request.method);
    console.log (response.statusCode);
    console.log (response.socket.remoteAddress);
    response.end ();

}

const server = http.createServer (onRequest)
server.on('clientError',(err,socket)=>{
    socket.end ('HTTP/1.1 400 Bad Request\r\n\r\n');
});

server.listen(3000,'127.0.0.1'); 