
using BigSchool_NHT.DTOs;
using BigSchool_NHT.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BigSchool_NHT.Controllers
{
    public class FollowingsController : ApiController
    {
        // GET: Followings
        private readonly ApplicationDbContext dbcontext;
        public FollowingsController()
        {
            dbcontext = new ApplicationDbContext();
        }

        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (dbcontext.Follwings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FollweeId))
                return BadRequest("Following already exists!");
            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FollweeId
            };
            dbcontext.Follwings.Add(folowing);
            dbcontext.SaveChanges();
            return Ok();
        }
    }
}