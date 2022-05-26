function validar(){
    var usuario = formLogin.usuario.value;
    var senha = formLogin.senha.value;
    let user = document.getElementById('usuario');
    let password = document.getElementById('senha');
    if(usuario == ""){
       user.style.cssText = 
       'border: solid;' +
       'border-color: red';
       if(senha == ""){
        password.style.cssText = 
        'border: solid;' +
        'border-color: red';
        return false;
     }
        user.focus();
        return false;
    }else{
        user.style.border = "none";
        if(senha == ""){
            password.style.cssText = 
            'border: solid;' +
            'border-color: red';
            password.focus();
            return false;
         }
        }
        
        
        window.location.href = 'Paginas/Index.html';
    
}
