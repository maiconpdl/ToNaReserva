var estrelas = document.querySelectorAll('.estrela');
var estrelasNota = document.querySelectorAll('.estrelaNota');
//Valor da variável nota virá do BD.
var nota = 1;
document.addEventListener('click', function(e){

    var classEstrela = e.target.classList;
    if(!classEstrela.contains('ativo')){
        estrelas.forEach(function(estrela){
            estrela.classList.remove('ativo');

        });
        classEstrela.add('ativo');
        nota = e.target.getAttribute('data-avaliacao');
        mostraAvaliacao();
    }

});

function mostraAvaliacao(){

        estrelasNota.forEach(function(estrelaNota){
            if(estrelaNota.getAttribute('data-nota') == nota){
                estrelaNota.classList.add('ativo')
            }else{                
                estrelaNota.classList.remove('ativo');

            }
        });  
    
}

