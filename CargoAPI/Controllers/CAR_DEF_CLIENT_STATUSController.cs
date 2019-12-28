using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CargoAPI.Models;

namespace CargoAPI.Controllers
{
    public class CAR_DEF_CLIENT_STATUSController : ApiController
    {
        private CARGOEntities1 db = new CARGOEntities1();

        // GET: api/CAR_DEF_CLIENT_STATUS
        public IQueryable<CAR_DEF_CLIENT_STATUS> GetCAR_DEF_CLIENT_STATUS()
        {
            return db.CAR_DEF_CLIENT_STATUS;
        }

        // GET: api/CAR_DEF_CLIENT_STATUS/5
        [ResponseType(typeof(CAR_DEF_CLIENT_STATUS))]
        public IHttpActionResult GetCAR_DEF_CLIENT_STATUS(decimal id)
        {
            CAR_DEF_CLIENT_STATUS cAR_DEF_CLIENT_STATUS = db.CAR_DEF_CLIENT_STATUS.Find(id);
            if (cAR_DEF_CLIENT_STATUS == null)
            {
                return NotFound();
            }

            return Ok(cAR_DEF_CLIENT_STATUS);
        }

        // PUT: api/CAR_DEF_CLIENT_STATUS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCAR_DEF_CLIENT_STATUS(decimal id, CAR_DEF_CLIENT_STATUS cAR_DEF_CLIENT_STATUS)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (id != cAR_DEF_CLIENT_STATUS.CODE)
            {
                return BadRequest();
            }

            db.Entry(cAR_DEF_CLIENT_STATUS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CAR_DEF_CLIENT_STATUSExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CAR_DEF_CLIENT_STATUS
        [ResponseType(typeof(CAR_DEF_CLIENT_STATUS))]
        public IHttpActionResult PostCAR_DEF_CLIENT_STATUS(CAR_DEF_CLIENT_STATUS cAR_DEF_CLIENT_STATUS)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.CAR_DEF_CLIENT_STATUS.Add(cAR_DEF_CLIENT_STATUS);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CAR_DEF_CLIENT_STATUSExists(cAR_DEF_CLIENT_STATUS.CODE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cAR_DEF_CLIENT_STATUS.CODE }, cAR_DEF_CLIENT_STATUS);
        }

        // DELETE: api/CAR_DEF_CLIENT_STATUS/5
        [ResponseType(typeof(CAR_DEF_CLIENT_STATUS))]
        public IHttpActionResult DeleteCAR_DEF_CLIENT_STATUS(decimal id)
        {
            CAR_DEF_CLIENT_STATUS cAR_DEF_CLIENT_STATUS = db.CAR_DEF_CLIENT_STATUS.Find(id);
            if (cAR_DEF_CLIENT_STATUS == null)
            {
                return NotFound();
            }

            db.CAR_DEF_CLIENT_STATUS.Remove(cAR_DEF_CLIENT_STATUS);
            db.SaveChanges();

            return Ok(cAR_DEF_CLIENT_STATUS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CAR_DEF_CLIENT_STATUSExists(decimal id)
        {
            return db.CAR_DEF_CLIENT_STATUS.Count(e => e.CODE == id) > 0;
        }
    }
}