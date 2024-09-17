
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

namespace DemoMVC.#pragma warning disable format
{
    public class ApplicationDbcontext :Dbcontext
    {
        public ApplicationDbcontext(Dbcontext0ptions<ApplicationDbcontext> options) : base(options)
        {
            public DbSet<Sinh vien> Student {get; set;}
        }
    }
}


