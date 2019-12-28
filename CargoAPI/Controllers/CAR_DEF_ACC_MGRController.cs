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
    public class CAR_DEF_ACC_MGRController : ApiController
    {
        private CARGOEntities1 db = new CARGOEntities1();

        // GET: api/CAR_DEF_ACC_MGR
        public IQueryable<CAR_DEF_ACC_MGR> GetCAR_DEF_ACC_MGR()
        {
            return db.CAR_DEF_ACC_MGR;
        }

        // GET: api/CAR_DEF_ACC_MGR/5
        [ResponseType(typeof(CAR_DEF_ACC_MGR))]
        public IHttpActionResult GetCAR_DEF_ACC_MGR(decimal id)
        {
            CAR_DEF_ACC_MGR cAR_DEF_ACC_MGR = db.CAR_DEF_ACC_MGR.Find(id);
            if (cAR_DEF_ACC_MGR == null)
            {
                return NotFound();
            }

            return Ok(cAR_DEF_ACC_MGR);
        }

        // PUT: api/CAR_DEF_ACC_MGR/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCAR_DEF_ACC_MGR(decimal id, CAR_DEF_ACC_MGR cAR_DEF_ACC_MGR)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cAR_DEF_ACC_MGR.CODE)
            {
                return BadRequest();
            }

            db.Entry(cAR_DEF_ACC_MGR).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CAR_DEF_ACC_MGRExists(id))
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

        // POST: api/CAR_DEF_ACC_MGR
        [ResponseType(typeof(CAR_DEF_ACC_MGR))]
        public IHttpActionResult PostCAR_DEF_ACC_MGR(CAR_DEF_ACC_MGR cAR_DEF_ACC_MGR)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CAR_DEF_ACC_MGR.Add(cAR_DEF_ACC_MGR);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CAR_DEF_ACC_MGRExists(cAR_DEF_ACC_MGR.CODE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cAR_DEF_ACC_MGR.CODE }, cAR_DEF_ACC_MGR);
        }

        // DELETE: api/CAR_DEF_ACC_MGR/5
        [ResponseType(typeof(CAR_DEF_ACC_MGR))]
        public IHttpActionResult DeleteCAR_DEF_ACC_MGR(decimal id)
        {
            CAR_DEF_ACC_MGR cAR_DEF_ACC_MGR = db.CAR_DEF_ACC_MGR.Find(id);
            if (cAR_DEF_ACC_MGR == null)
            {
                return NotFound();
            }

            db.CAR_DEF_ACC_MGR.Remove(cAR_DEF_ACC_MGR);
            db.SaveChanges();

            return Ok(cAR_DEF_ACC_MGR);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CAR_DEF_ACC_MGRExists(decimal id)
        {
            return db.CAR_DEF_ACC_MGR.Count(e => e.CODE == id) > 0;
        }
    }
}