using MemberManagement.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MM_Entities.Entities;
using MM_Services.Interface;
using System;
using System.IO;
using System.Net.Http.Headers;

namespace MemberManagement.Controllers
{
    public class MembersDapperController : Controller
    {
        private readonly IService<Member> _memberManager;
        private readonly IHostingEnvironment _hostingEnvironment;

        public MembersDapperController(IService<Member> memberManager, IHostingEnvironment hostingEnvironment)
        {
            _memberManager = memberManager;
            _hostingEnvironment = hostingEnvironment;
        }

        public ActionResult Index()
        {
            var data = _memberManager.ListAll();

            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            foreach (var item in data)
            {
                if (!string.IsNullOrEmpty(item.MemberImage))
                    item.MemberImage = Path.Combine(baseUrl, "Images", item.MemberImage);
                else
                    item.MemberImage = Path.Combine(baseUrl, "Images", "404.png");
            }
            return View(data);
        }

        #region Add Member  

        public ActionResult Add()
        {
            return View("Form", new MemberModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(MemberModel model)
        {
            if (ModelState.IsValid)
            {
                var fileName = "";
                if (Request.Form.Files.Count > 0)
                {
                    var file = Request.Form.Files[0];
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    var newPath = Path.Combine(webRootPath, "images");
                    if (!Directory.Exists(newPath)) Directory.CreateDirectory(newPath);

                    if (file.Length > 0)
                    {
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var fullPath = Path.Combine(newPath, fileName);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                }

                var member = new Member()
                {
                    MemberFirstName = model.MemberFirstName,
                    MemberLastName = model.MemberLastName,
                    MemberImage = fileName,
                    CreatedDateTime = DateTime.Now,
                    MemberTitle = model.MemberTitle,
                    IsActive = model.IsActive,
                    UpdatedDateTime = DateTime.Now
                };

                _memberManager.Create(member);
                return RedirectToAction("Index", "Member");
            }
            return View("Form", model);
        }

        #endregion

        #region Edit Member  

        public ActionResult Edit(int MemberId)
        {
            var memberEntity = _memberManager.GetById(MemberId);
            var memberModel = new MemberModel
            {
                MemberID = memberEntity.MemberID,
                MemberFirstName = memberEntity.MemberFirstName,
                MemberLastName = memberEntity.MemberLastName,
                MemberImage = memberEntity.MemberImage,
                CreatedDateTime = memberEntity.CreatedDateTime,
                MemberTitle = memberEntity.MemberTitle,
                IsActive = memberEntity.IsActive,
                UpdatedDateTime = memberEntity.UpdatedDateTime
            };
            return View("Form", memberModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MemberModel model)
        {
            if (ModelState.IsValid)
            {
                var fileName = model.MemberImage ?? "";
                if (Request.Form.Files.Count > 0)
                {
                    var file = Request.Form.Files[0];
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    var newPath = Path.Combine(webRootPath, "images");
                    if (!Directory.Exists(newPath)) Directory.CreateDirectory(newPath);

                    if (file.Length > 0)
                    {
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var fullPath = Path.Combine(newPath, fileName);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                }

                var member = new Member()
                {
                    MemberID = model.MemberID,
                    MemberFirstName = model.MemberFirstName,
                    MemberLastName = model.MemberLastName,
                    MemberImage = fileName,
                    MemberTitle = model.MemberTitle,
                    IsActive = model.IsActive,
                    UpdatedDateTime = DateTime.Now
                };

                _memberManager.Update(member);
                return RedirectToAction("Index", "MembersDapper");
            }
            return View("Form", model);
        }

        #endregion

        #region Delete Member  

        public ActionResult Delete(int MemberId)
        {
            var memberEntity = _memberManager.Delete(MemberId);
            return RedirectToAction("Index", "Member");
        }

        #endregion
    }
}
