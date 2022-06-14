using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //Get /api/movies
        public IEnumerable<MovieDto> GetMovies()
        {
             return _context.Movies.Include(c => c.Genre).ToList().Select(Mapper.Map<Movie, MovieDto>);
        }

        //Get /api/movies/1
        public MovieDto GetMovie(int id)
        {
           var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Movie, MovieDto>(movie);
        }

        //POST /api/movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        /*
         * MovieDto will return 200 ok but we need to return 201 Created status and for this reason we will change it to
         * IHttpActionResult instead
         */
        {
            if (!ModelState.IsValid)
                //Throw new HttpResposeException(HttpStatusCode.BadRequest)
                return BadRequest();
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        //PUT api/movie/1
        [HttpPut]
        public void UpdateMovie(int id , MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            //First return the movie in Database
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            //In Update we can pass second argument which is movieInDb to track the existing object
            Mapper.Map(movieDto, movieInDb);

            //movieInDb.Name = movieDto.Name;
            //movieInDb.NumberInStock = movieDto.NumberInStock;
            //movieInDb.ReleaseDate = movieDto.ReleaseDate;

            _context.SaveChanges();
        }

        //Delete /api/movie/1
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            //First return the customer in Db
           var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
           if (movieInDb == null)
               throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();


        }

    }
}
