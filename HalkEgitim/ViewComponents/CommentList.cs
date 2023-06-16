using HalkEgitim.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HalkEgitim.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Serhat"
                },
                new UserComment
                {
                    ID=2,
                    Username="Burak"
                },
                new UserComment
                {
                    ID=3,
                    Username="Beyza"
                },
            };
            return View(commentvalues);
        }
    }
}
