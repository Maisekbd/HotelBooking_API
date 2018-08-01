using HotelBooking.Model;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HotelBooking.WebAPI.Controllers
{
    public class CustomerController : ApiController
    {
    //    private HotelBookingContext db = new HotelBookingContext();

    //    // GET: api/Hotels  
    //    public IQueryable<Customer> GetCustomers()
    //    {
    //        return db.Customers;
    //    }



    //    // PUT: api/Employees/5  

    //    public HttpResponseMessage PutCustomer(Customer Customer)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
    //        }


    //        db.Entry(Customer).State = EntityState.Modified;

    //        try
    //        {
    //            db.SaveChanges();
    //        }
    //        catch (DbUpdateConcurrencyException ex)
    //        {
    //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
    //        }

    //        return Request.CreateResponse(HttpStatusCode.OK);
    //    }

    //    // POST: api/Employees  

    //    public HttpResponseMessage PostCustomer(Customer Customer)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Customers.Add(Customer);
    //            db.SaveChanges();
    //            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, Customer);
    //            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = Customer.ID }));
    //            return response;
    //        }
    //        else
    //        {
    //            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
    //        }

    //    }

    //    // DELETE: api/Employees/5  

    //    public HttpResponseMessage DeleteCustomer(Customer Customer)
    //    {
    //        Customer remove_Customer = db.Customers.Find(Customer.ID);
    //        if (remove_Customer == null)
    //        {
    //            return Request.CreateResponse(HttpStatusCode.NotFound);
    //        }

    //        db.Customers.Remove(remove_Customer);
    //        try
    //        {
    //            db.SaveChanges();
    //        }
    //        catch (DbUpdateConcurrencyException ex)
    //        {
    //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
    //        }

    //        return Request.CreateResponse(HttpStatusCode.OK);
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

        
    }
}