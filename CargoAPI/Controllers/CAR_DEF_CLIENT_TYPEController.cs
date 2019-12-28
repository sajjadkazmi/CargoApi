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
    public class CAR_DEF_CLIENT_TYPEController : ApiController
    {
        private CARGOEntities1 db = new CARGOEntities1();

        // GET: api/CAR_DEF_CLIENT_TYPE
        public IQueryable<CAR_DEF_CLIENT_TYPE> GetCAR_DEF_CLIENT_TYPE()
        {
            return db.CAR_DEF_CLIENT_TYPE;
        }

        // GET: api/CAR_DEF_CLIENT_TYPE/5
        [ResponseType(typeof(CAR_DEF_CLIENT_TYPE))]
        public IHttpActionResult GetCAR_DEF_CLIENT_TYPE(decimal id)
        {
            CAR_DEF_CLIENT_TYPE cAR_DEF_CLIENT_TYPE = db.CAR_DEF_CLIENT_TYPE.Find(id);
            if (cAR_DEF_CLIENT_TYPE == null)
            {
                return NotFound();
            }

            return Ok(cAR_DEF_CLIENT_TYPE);
        }

        // PUT: api/CAR_DEF_CLIENT_TYPE/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCAR_DEF_CLIENT_TYPE(decimal id, CAR_DEF_CLIENT_TYPE cAR_DEF_CLIENT_TYPE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cAR_DEF_CLIENT_TYPE.CODE)
            {
                return BadRequest();
            }

            db.Entry(cAR_DEF_CLIENT_TYPE).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CAR_DEF_CLIENT_TYPEExists(id))
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

        // POST: api/CAR_DEF_CLIENT_TYPE
        [ResponseType(typeof(CAR_DEF_CLIENT_TYPE))]
        public IHttpActionResult PostCAR_DEF_CLIENT_TYPE(CAR_DEF_CLIENT_TYPE cAR_DEF_CLIENT_TYPE)
        {

            db.CAR_DEF_CLIENT_TYPE.Add(cAR_DEF_CLIENT_TYPE);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CAR_DEF_CLIENT_TYPEExists(cAR_DEF_CLIENT_TYPE.CODE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cAR_DEF_CLIENT_TYPE.CODE }, cAR_DEF_CLIENT_TYPE);
        }

        // DELETE: api/CAR_DEF_CLIENT_TYPE/5
        [ResponseType(typeof(CAR_DEF_CLIENT_TYPE))]
        public IHttpActionResult DeleteCAR_DEF_CLIENT_TYPE(decimal id)
        {
            CAR_DEF_CLIENT_TYPE cAR_DEF_CLIENT_TYPE = db.CAR_DEF_CLIENT_TYPE.Find(id);
            if (cAR_DEF_CLIENT_TYPE == null)
            {
                return NotFound();
            }

            db.CAR_DEF_CLIENT_TYPE.Remove(cAR_DEF_CLIENT_TYPE);
            db.SaveChanges();

            return Ok(cAR_DEF_CLIENT_TYPE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CAR_DEF_CLIENT_TYPEExists(decimal id)
        {
            return db.CAR_DEF_CLIENT_TYPE.Count(e => e.CODE == id) > 0;
        }
    }
}