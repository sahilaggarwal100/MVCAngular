using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MVCAngular.Models;

namespace MVCAngular.Controllers
{
    public class Test_Vishnu_Table1Controller : ApiController
    {
        private SystematicRevV2Entities db = new SystematicRevV2Entities();

        // GET api/Test_Vishnu_Table1
        public IEnumerable<Test_Vishnu_Table1> GetTest_Vishnu_Table1()
        {
            return db.Test_Vishnu_Table1.AsEnumerable();
        }

        // GET api/Test_Vishnu_Table1/5
        public Test_Vishnu_Table1 GetTest_Vishnu_Table1(int id)
        {
            Test_Vishnu_Table1 test_vishnu_table1 = db.Test_Vishnu_Table1.Find(id);
            if (test_vishnu_table1 == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return test_vishnu_table1;
        }

        // PUT api/Test_Vishnu_Table1/5
        public HttpResponseMessage PutTest_Vishnu_Table1(int id, Test_Vishnu_Table1 test_vishnu_table1)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != test_vishnu_table1.SID)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(test_vishnu_table1).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Test_Vishnu_Table1
        public HttpResponseMessage PostTest_Vishnu_Table1(Test_Vishnu_Table1 test_vishnu_table1)
        {
            if (ModelState.IsValid)
            {
                db.Test_Vishnu_Table1.Add(test_vishnu_table1);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, test_vishnu_table1);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = test_vishnu_table1.SID }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Test_Vishnu_Table1/5
        public HttpResponseMessage DeleteTest_Vishnu_Table1(int id)
        {
            Test_Vishnu_Table1 test_vishnu_table1 = db.Test_Vishnu_Table1.Find(id);
            if (test_vishnu_table1 == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Test_Vishnu_Table1.Remove(test_vishnu_table1);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, test_vishnu_table1);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}