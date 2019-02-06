using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using InstantScratchIts.Web.Data;

namespace InstantScratchIts.Web.Services
{
    public class InstantGameService
    {
        readonly AppDbContext _context;
        readonly ILogger _logger;
        public InstantGameService(AppDbContext context, ILoggerFactory factory)
        {
            _context = context;
            _logger = factory.CreateLogger<InstantGameService>();
        }
    }
}