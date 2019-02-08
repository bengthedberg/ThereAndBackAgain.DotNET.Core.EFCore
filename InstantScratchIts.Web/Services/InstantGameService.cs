using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using InstantScratchIts.Web.Data;
using InstantScratchIts.Web.Models;
using System.Linq;
using System;

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

        public ICollection<InstantGamesSummaryViewModel> GetInstantGames()
        {
            return _context.InstantGames
                .Where(r => !r.IsDeleted)
                .Select(x => new InstantGamesSummaryViewModel
                {
                    Id = x.InstantGameId,
                    GameNo = x.GameNo,
                    Name = x.Name,
                    TicketAmount = x.TicketAmount,
                })
                .ToList();
        }

        public InstantGameDetailViewModel GetInstantGameDetail(int id)
        {
            return _context.InstantGames
                .Where(x => x.InstantGameId == id)
                .Where(x => !x.IsDeleted)
                .Select(x => new InstantGameDetailViewModel
                {
                    Id = x.InstantGameId,
                    GameNo = x.GameNo,
                    Name = x.Name,
                    TicketAmount = x.TicketAmount,
                    Jurisdictions = x.Jurisdiction
                    .Select(region => new InstantGameDetailViewModel.Region
                    {
                        Name = region.Name,
                        Allocation =region.Allocation
                    })
                })
                .SingleOrDefault();
        }

        public UpdateInstantGameCommand GetInstantGameForUpdate(int id)
        {
            return _context.InstantGames
                .Where(x => x.InstantGameId == id)
                .Where(x => !x.IsDeleted)
                .Select(x => new UpdateInstantGameCommand
                {
                    Name = x.Name,
                    GameNo = x.GameNo,
                    TicketAmount = x.TicketAmount,
                })
                .SingleOrDefault();
        }

        public void UpdateInstantGame(UpdateInstantGameCommand cmd)
        {
            var game = _context.InstantGames.Find(cmd.Id);
            if (game == null) { throw new Exception("Unable to find the instant game"); }
            if (game.IsDeleted) { throw new Exception("Unable to update a deleted instant game"); }

            cmd.UpdateInstantGame(game);
            _context.SaveChanges();
        }
    }
}