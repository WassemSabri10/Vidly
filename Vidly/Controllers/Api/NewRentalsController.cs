using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using System.Data.Entity;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {

            //Get the customer and movies from _context then iterate through movies and create rental object for each movie
            //and set Customer, Movie, and DateRented then add the object to the database and save the changes.
            //I will need a validation for edge cases such as 
            //1. CustomerId is invalid. (For this validation I need to use SingleOrDefault instead of Single) 
            //2. No MovieIds, 
            //3. One or more MovieIds are invalid, 
            //4. One or more movies are not available

            //this is the second edge case we don't want to query database if no movieId provided
            if (newRental.MovieIds.Count == 0)
                return BadRequest("No Movie Ids have been given.");

            var customer = _context.Customers.SingleOrDefault(
                c => c.Id == newRental.CustomerId);

            if (customer == null)
                return BadRequest("CustomerId is not valid.");


            var movies   = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            //Edge case 3
            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or more movieIds are invalid.");

            foreach (var movie in movies)
            {
                //Edge case 4
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");
                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);

            }
            _context.SaveChanges();

            return Ok();
        }
    }
}
