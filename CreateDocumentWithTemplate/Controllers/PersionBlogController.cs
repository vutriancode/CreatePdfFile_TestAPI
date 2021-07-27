using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrapeCity.Documents.Word;
using GrapeCity.Documents.Word.Layout;
using System.IO.Compression;
using CreateDocumentWithTemplate.contract;
using CreateDocumentWithTemplate.Models;

namespace CreateDocumentWithTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersionBlogController : ControllerBase
    {
        private IRepositoryWrapper _repositoryWrapper;
        public PersionBlogController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        [HttpGet]
        public IEnumerable<PersionBlog> GetAll()
        {
            return _repositoryWrapper.PersionBlogRepository.FindAll();
        }
        [HttpGet("{id}")]
        public PersionBlog GetById(Guid id) {
            return _repositoryWrapper.PersionBlogRepository.FindByID(id);
        }
        [HttpPost]
        public ActionResult Create(PersionBlog persionBlog)
        {
            try
            {
                _repositoryWrapper.PersionBlogRepository.Create(persionBlog);
                GcWordDocument doc = new GcWordDocument();
                doc.Load("Resources\\PersionBlog.docx");
                var itineraryData = new
                {
                    Title = persionBlog.Title,
                    Content = persionBlog.Contents,
                };
                doc.DataTemplate.DataSources.Add("ds", itineraryData);
                doc.DataTemplate.Process();
                using (var layout = new GcWordLayout(doc))
                {
                    // save the whole document as PDF
                    layout.SaveAsPdf("PersionBlog.pdf", null, new PdfOutputSettings() { CompressionLevel = CompressionLevel.Fastest });
                }
                return Content("Create file success");
            }
            catch
            {

                return Content("Id da ton tai");
            }
       }
        [HttpPut("{id}")]
        public ActionResult Update(Guid id, PersionBlog persionBlog)
        {
          if (id != persionBlog.id)
            {
              return BadRequest();
        }
            _repositoryWrapper.PersionBlogRepository.Update(persionBlog);
            _repositoryWrapper.Save();

            return Content("Update thanh cong");
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            PersionBlog persionBlog = _repositoryWrapper.PersionBlogRepository.FindByID(id);
            if (id != persionBlog.id)
            {
                return BadRequest();
            }
            _repositoryWrapper.PersionBlogRepository.Delete(persionBlog);
            _repositoryWrapper.Save();
            return Content("Delete thanh cong");
        }

    }
}
