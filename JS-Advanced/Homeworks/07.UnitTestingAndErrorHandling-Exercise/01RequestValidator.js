function validator(object){
    const methods = ['GET', 'POST', 'DELETE', 'CONNECT'];
    const uriRegex = /^[a-zA-Z0-9.]+$/;
    const versions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
    const messageRegex = /^[^\<\>\\\&\'\"]+$/;

    if(!methods.some(m => m == object.method) || object.method == undefined){
        throw new Error('Invalid request header: Invalid Method');
    }

    if(!uriRegex.test(object.uri) || object.uri == undefined){
        if(object.uri != '*'){
            throw new Error('Invalid request header: Invalid URI');
        }
    }

    if(!versions.some(v => v == object.version) || object.version == undefined){
        throw new Error('Invalid request header: Invalid Version');
    }

    if(!messageRegex.test(object.message) || object.message == undefined){
        if(object.message != ''){
            throw new Error('Invalid request header: Invalid Message');
        }
    }

    return object;
}

console.log(validator({
    method: 'GET',
    uri: 'kkk jjjj',
    version: 'HTTP/0.8',
    message: ''
}
  ));