using _0511bv.Controllers;
using Newtonsoft.Json;


namespace _0511bv.Services
{
    public class RoomDisplayServices : APIAIService
    {
        public RoomDisplayServices(RequestRootObject root, ResRootObject res, string str) : 
            base( root,  res,  str)
        {
        }

        public override string GenerateResponse()
        {
            var roomType = root.result.parameters.RoomType;
            if (roomType.Equals("double room"))
            {
                res.speech = "double room should display";
                res.displayText = "double room should display";
                res.data = new Data
                {
                    facebook = new Facebook
                    {
                        attachment = new Attachment
                        {
                            type = "image",
                            payload = new Payload { url = "https://images.bookvisit.com/img/fcbaabdb-fe3f-48db-98c0-b8b643bfc928.jpg?maxwidth=1500&maxheight=1500&scale=both&anchor=MiddleCenter&sharpen=0.6" }
                        }
                    }
                };
                str = JsonConvert.SerializeObject(res);



            }
            else if (roomType.Equals("single room"))
            {
                res.speech = "single room should display";
                res.displayText = "single room should display";
                res.data = new Data
                {
                    facebook = new Facebook
                    {
                        attachment = new Attachment
                        {
                            type = "image",
                            payload = new Payload { url = "https://images.bookvisit.com/img/b52ffb14-1363-49af-a8fd-c9a704408914.jpg?maxwidth=1500&maxheight=1500&scale=both&anchor=MiddleCenter&sharpen=0.6" }
                        }
                    }
                };
                str = JsonConvert.SerializeObject(res);

            }
            else if (roomType.Equals("room"))
            {
                str = "{'speech': 'all rooms.','displayText': 'all rooms','data': {},'contextOut': [],'source': 'DuckDuckGo'}";
            }

            return str;
        }
    }
}