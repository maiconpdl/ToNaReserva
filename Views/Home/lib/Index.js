function ativaTabPosto(){
    document.getElementById('ex1-tab-1').classList.remove('active');
    document.getElementById('ex1-tabs-1').classList.remove('active');
    document.getElementById('ex1-tabs-1').classList.add('hide');
    document.getElementById('ex2-tab-2').classList.add('disabled');
    document.getElementById('ex2-tabs-2').classList.add('active');
    document.getElementById('ex2-tabs-2').classList.add('show');
    document.getElementById('ex1-tab-1').classList.remove('disabled');

}

function ativaTabUsuario(){
    
    document.getElementById('ex2-tab-2').classList.remove('active');
    document.getElementById('ex2-tabs-2').classList.remove('active');
    document.getElementById('ex2-tabs-2').classList.add('hide');
    document.getElementById('ex1-tab-1').classList.add('disabled');
    document.getElementById('ex1-tabs-1').classList.add('active');
    document.getElementById('ex1-tabs-1').classList.add('show');
    document.getElementById('ex2-tab-2').classList.remove('disabled');
    

}
