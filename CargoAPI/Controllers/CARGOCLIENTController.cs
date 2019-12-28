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
    public class CARGOCLIENTController : ApiController
    {
        private CARGOEntities1 db = new CARGOEntities1();

        // GET: api/CARGOCLIENT
        public IQueryable<CAR_CLIENT> GetCAR_CLIENT()
        {
            return db.CAR_CLIENT;
        }

        // GET: api/CARGOCLIENT/5
        [ResponseType(typeof(CAR_CLIENT))]
        public IHttpActionResult GetCAR_CLIENT(decimal id)
        {
            CAR_CLIENT cAR_CLIENT = db.CAR_CLIENT.Find(id);
            if (cAR_CLIENT == null)
            {
                return NotFound();
            }

            return Ok(cAR_CLIENT);
        }

        // PUT: api/CARGOCLIENT/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCAR_CLIENT(decimal id, CAR_CLIENT cAR_CLIENT)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (id != cAR_CLIENT.PARTY_CODE)
            {
                return BadRequest();
            }

            db.Entry(cAR_CLIENT).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CAR_CLIENTExists(id))
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

        // POST: api/CARGOCLIENT
        [ResponseType(typeof(CAR_CLIENT))]
        public IHttpActionResult PostCAR_CLIENT(CAR_CLIENT cAR_CLIENT)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.CAR_CLIENT.Add(cAR_CLIENT);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CAR_CLIENTExists(cAR_CLIENT.PARTY_CODE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cAR_CLIENT.PARTY_CODE }, cAR_CLIENT);
        }

        // DELETE: api/CARGOCLIENT/5
        [ResponseType(typeof(CAR_CLIENT))]
        public IHttpActionResult DeleteCAR_CLIENT(decimal id)
        {
            CAR_CLIENT cAR_CLIENT = db.CAR_CLIENT.Find(id);
            if (cAR_CLIENT == null)
            {
                return NotFound();
            }

            db.CAR_CLIENT.Remove(cAR_CLIENT);
            db.SaveChanges();

            return Ok(cAR_CLIENT);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CAR_CLIENTExists(decimal id)
        {
            return db.CAR_CLIENT.Count(e => e.PARTY_CODE == id) > 0;
        }
    }
}