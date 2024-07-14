using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;

public class Code5_12 {

    public static void Run() {

    }

    public class CreateUserModel : PageModel {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        public CreateUserModel(AppDbContext context, ILogger<CreateUserModel> logger) {
            _context = context;
            _logger = logger;
        }
        // …
    }

    public class AppDbContext : DbContext {

    }
}

