using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using ToNaReserva.Models;

namespace ToNaReserva.Controllers;

public class HomeController : Controller
{
    private readonly Contexto _contexto;
    private readonly ILogger<HomeController> _logger;

    public static Usuario usuarioLogado = new Usuario();
    private static Posto postoLogado = new Posto();
    public HomeController(ILogger<HomeController> logger, Contexto contexto)
    {
        _logger = logger;
        _contexto = contexto;
        
        
    }

    public async Task<IActionResult> Index()
    {       
        if(usuarioLogado.tipo == "Cliente"){
                        
                        ViewData["Cliente"] = "Cliente";
                    }
                else{
                    if(usuarioLogado.tipo == "Posto"){
                    
                    ViewData["Posto"] = "Posto";
                    }
                }  
        return View(await _contexto.Postos.ToListAsync());
        
    }

    public async Task<IActionResult> Posto(){
        ViewBag.Cliente = usuarioLogado.tipo;
        ViewBag.Posto = usuarioLogado.tipo; 
            return View(await _contexto.Postos.Where(p => p.usuarioid == usuarioLogado.id).ToListAsync());
            
        }


    public IActionResult Privacy()
    {
        return View();
    }

    
    public IActionResult CadastroUsuario()
    {
        ViewBag.Posto = "";
        ViewBag.Cliente = "";
        return View();
    }
        public async Task<IActionResult> CadastroPosto()
    {
            return View();   
        
    }
    public IActionResult login()
    {
        ViewBag.Cliente = "";
        ViewBag.Posto = "";
        ViewBag.Alerta = "";
        return View();
    }

        public IActionResult cadastroPrecos()
    {
        ViewBag.Cliente = usuarioLogado.tipo;
        ViewBag.Posto = usuarioLogado.tipo;
        return View();
    }

    public IActionResult cadastroProdutos()
    {
        ViewBag.Cliente = usuarioLogado.tipo;
        ViewBag.Posto = usuarioLogado.tipo;
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> CadastroUsuario(Usuario usuario){
        if(ModelState.IsValid){
            
            await _contexto.Usuarios.AddAsync(usuario);
            await _contexto.SaveChangesAsync();
             return RedirectToAction(nameof(login));
        }
        return View(usuario);
    }


    [HttpPost]
    public async Task<IActionResult> VerificaUsuario(string email,string senha){
        List<Usuario> user = await _contexto.Usuarios.ToListAsync();
       
        if(ModelState.IsValid){
        foreach(var u in user){
            if((u.email == email)&&(u.senha == senha)){
            usuarioLogado = u;
            
               
                //return View("Index");
                return RedirectToAction(nameof(Index));
                
                
            }
            
        }
        List<Posto> postos = await _contexto.Postos.Where(p => p.usuarioid == usuarioLogado.id).ToListAsync();
        foreach(var p in postos){
            postoLogado = p;
        }
        ViewBag.Alerta = "Usuario ou senha invalidos!";
        return View("login");
        }
        return View("login");
    }

    [HttpPost]
    public async Task<IActionResult> CadastroPosto(Posto posto){
        ViewBag.Cliente = usuarioLogado.tipo;
        ViewBag.Posto = usuarioLogado.tipo;
        posto.usuarioid = usuarioLogado.id;
        if(ModelState.IsValid){
            await _contexto.Postos.AddAsync(posto);
            await _contexto.SaveChangesAsync();
             return RedirectToAction(nameof(Index));

        }
        return View(posto);
    }

    [HttpGet]
    public async Task<IActionResult> CadastrasPrecos(){
        return View(await _contexto.Postos.FindAsync(postoLogado.id));
    }
    [HttpPost]
    public async Task<IActionResult> CadastroPrecos(Posto posto){
        if(ModelState.IsValid){
            _contexto.Postos.Update(posto);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(posto);
    }

    [HttpPost]
    public async Task<IActionResult> CadastroProdutos(Produto produto){
        ViewBag.Cliente = usuarioLogado.tipo;
        ViewBag.Posto = usuarioLogado.tipo;
        List<Posto> postos = await _contexto.Postos.Where(p => p.usuarioid == usuarioLogado.id).ToListAsync();
        foreach(var p in postos){
            
            produto.postoid = p.id;

        }
        if(ModelState.IsValid){
            await _contexto.Produtos.AddAsync(produto);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(produto);
    }





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
