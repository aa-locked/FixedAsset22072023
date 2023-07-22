using FixedAsset.Data;
using FixedAsset.Models;
using Microsoft.AspNetCore.Mvc;

namespace FixedAsset.Controllers
{
    public class MtrlGrpController : Controller
    {
        private readonly FixedAssetDbContext _fixedAssetDbContext;

        public MtrlGrpController(FixedAssetDbContext fixedAssetDbContext)
        {
            _fixedAssetDbContext = fixedAssetDbContext;
        }

        public IActionResult CreateMtrlGrp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMtrlGrp(TFAMtrlGrp tFAMtrlGrp)
        {
            if(ModelState.IsValid)
            {
                _fixedAssetDbContext.Add(tFAMtrlGrp);
                _fixedAssetDbContext.SaveChanges();       
                return RedirectToAction("CreateMtrlGrp", "MtrlGrp");
            }
            return View();

        }
    }
}
