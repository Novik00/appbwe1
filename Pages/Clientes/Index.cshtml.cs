using appbwe1.Data;
using appbwe1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _ctx;
        public IndexModel(AppDbContext ctx)
        {
            _ctx=ctx;
        } 
        public List<Cliente> Clientes { get; set;}
        public void OnGet() //se ejecuta al cargar la página
        {
            Clientes = _ctx.Clientes.ToList();
        }
    }
}
