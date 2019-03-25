using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExcelToChartAPI.Models;

namespace ExcelToChartAPI.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("GetValues")]
        public List<ExcelData> Get()
        {
            List<ExcelData> lst = new List<ExcelData>();
            lst.Add(new ExcelData
            {
                id = 1,
                name = "venkat",
                amount = 180,
                year = 2019
            });
            lst.Add(new ExcelData
            {
                id = 2,
                name = "srilekha",
                amount = 160,
                year = 2020
            });
            return lst;
        }

       // POST api/values
       [HttpPost]
       [Route("InsertValues")]
        public int Post(List<ExcelData> excelData)
        {
            return 1;
        }

    }
}
