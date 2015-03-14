using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    using WebAPI.DataAccess;
    public class MessageAPIController : ApiController
    {
        [HttpPost]
        public Messages Add(Messages message)
        {
            using (var dataContext = new WebAPI.DataAccess.MessageBaseEntities())
            {
                dataContext.Messages.Add(new Messages
                {
                    Text = message.Text,
                    Time = DateTime.Now
                });
                dataContext.SaveChanges();
            }

            return message;
        }
    }
}

