using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Seguritas.Api;
using Seguritas.Api.Models;
using Seguritas.Core;

namespace Seguritas.Api.Controllers
{
    public class ClientesController : ApiController
    {
        private SeguritasContext db = new SeguritasContext();

        // GET: api/Clientes
        public IQueryable<ClientesDTO> GetClientes()
        {

            var clientes = from b in db.Clientes
                           select new ClientesDTO()
                           {
                               Id = b.Id,
                               Nombre = b.Nombre,
                               FechaModificacion = b.FechaModificacion
                           };
            return clientes;
        }

        // GET: api/Clientes/5
        [ResponseType(typeof(Clientes))]
        public async Task<IHttpActionResult> GetClientes(int id)
        {
            Clientes clientes = await db.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }

            return Ok(clientes);
        }

        // PUT: api/Clientes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClientes(int id, Clientes clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientes.Id)
            {
                return BadRequest();
            }

            db.Entry(clientes).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientesExists(id))
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

        // POST: api/Clientes
        [ResponseType(typeof(Clientes))]
        public async Task<IHttpActionResult> PostClientes(Clientes clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Clientes.Add(clientes);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = clientes.Id }, clientes);
        }

        // DELETE: api/Clientes/5
        [ResponseType(typeof(Clientes))]
        public async Task<IHttpActionResult> DeleteClientes(int id)
        {
            Clientes clientes = await db.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }

            db.Clientes.Remove(clientes);
            await db.SaveChangesAsync();

            return Ok(clientes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientesExists(int id)
        {
            return db.Clientes.Count(e => e.Id == id) > 0;
        }
    }
}