﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HipHopOsijek.WebAPI.Models;

namespace HipHopOsijek.WebAPI.Controllers
{
    public class GuestsController : ApiController
    {
        private HipHopOsijekEntities1 db = new HipHopOsijekEntities1();

        public GuestsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Guests
        public IQueryable<Guest> GetGuests()
        {
            return db.Guests;
        }

        // GET: api/Guests/5
        [ResponseType(typeof(Guest))]
        public IHttpActionResult GetGuest(long id)
        {
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return NotFound();
            }

            return Ok(guest);
        }

        // PUT: api/Guests/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGuest(long id, Guest guest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != guest.Id)
            {
                return BadRequest();
            }

            db.Entry(guest).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuestExists(id))
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

        // POST: api/Guests
        [ResponseType(typeof(Guest))]
        public IHttpActionResult PostGuest(Guest guest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Guests.Add(guest);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (GuestExists(guest.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = guest.Id }, guest);
        }

        // DELETE: api/Guests/5
        [ResponseType(typeof(Guest))]
        public IHttpActionResult DeleteGuest(long id)
        {
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return NotFound();
            }

            db.Guests.Remove(guest);
            db.SaveChanges();

            return Ok(guest);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GuestExists(long id)
        {
            return db.Guests.Count(e => e.Id == id) > 0;
        }
    }
}