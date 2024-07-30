using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Antonio K. Farias", "765.567.123.31", "kelson.antonio@pi.senai.br", "Duke");
        Cliente cliente2 = new Cliente(02, "Adriano R. Farias", "265.567.123.32", "Relson.antonio@pi.senai.br", "Luna");
        Cliente cliente3 = new Cliente(03, "Francisco N. Farias", "365.567.123.33", "nelson.antonio@pi.senai.br", "Tink");
        Cliente cliente4 = new Cliente(04, "Marcos W. Farias", "465.567.123.34", "welson.antonio@pi.senai.br", "Wink");
        Cliente cliente5 = new Cliente(05, "Amilton Q. Farias", "565.567.123.35", "Quelson.antonio@pi.senai.br", "HULK");

        // lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        // instancias do tipo fornecedor e atribui os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "Kp Pet S/A", "705.567.123.31", "kelson.antonio@pi.senai.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "215.567.123.32", "Relson.antonio@pi.senai.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "325.567.123.33", "nelson.antonio@pi.senai.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "435.567.123.34", "welson.antonio@pi.senai.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Tink Wink Dogs", "465.577.123.35", "contato@bff.br");

        // lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listafornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
