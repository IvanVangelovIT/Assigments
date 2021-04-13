namespace CsvFile.Web.Controllers
{
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CsvFile.Data;
    using CsvFile.Data.Models;
    using CsvFile.Web.Models;
    using CsvHelper;
    using CsvHelper.Configuration;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //TODO Move logic to separate service
        [HttpPost]
        public async Task<IActionResult> Create(IFormFile upload)
        {
            if (upload.FileName.EndsWith(".csv"))
            {

                var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";", Encoding = Encoding.UTF8 };

                using (var streamReader = new StreamReader(upload.OpenReadStream()))
                {
                    using (var csvReader = new CsvReader(streamReader, config))
                    {
                        csvReader.Context.RegisterClassMap<OffersClassMap>();
                        var records = csvReader.GetRecords<Offer>().ToList();

                        await this._context.AddRangeAsync(records);
                        await this._context.SaveChangesAsync();
                    }
                }
            }

            return this.Ok(".csv File is stored in database");
        }

        //TODO Move OffersClassMap
        public class OffersClassMap : ClassMap<Offer>
        {
            public OffersClassMap()
            {
                Map(row => row.offerId).Name("offerId").Convert(row => int.Parse(row.Row.GetField("offerId").Replace(",", "")));
                Map(row => row.monthlyFee).Name("monthlyFee").Convert(row => int.Parse(row.Row.GetField("monthlyFee").Replace(",", "")));
                Map(row => row.newContractsForMonth).Name("newContractsForMonth").Convert(row => int.Parse(row.Row.GetField("newContractsForMonth").Replace(",", "")));
                Map(row => row.sameContractsForMonth).Name("sameContractsForMonth").Convert(row => int.Parse(row.Row.GetField("sameContractsForMonth").Replace(",", "")));
                Map(row => row.CancelledContractsForMonth).Name("CancelledContractsForMonth").Convert(row => int.Parse(row.Row.GetField("CancelledContractsForMonth").Replace(",", "")));
            }
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
}
