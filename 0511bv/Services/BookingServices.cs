using _0511bv.Controllers;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace _0511bv.Services
{
    public class BookingServices : APIAIService
    {
        public BookingServices(RequestRootObject root, ResRootObject res, string str) :
            base(root, res, str)
        {
        }

        public override string GenerateResponse()
        {
            try
            {
                var roomtype = "(room type not found)";
                try
                {
                    roomtype = root.result.contexts.FirstOrDefault()?.parameters?.RoomType;
                }
                catch (Exception e)
                {

                }
                var parameters = root.result.parameters;
                var str = $"a booking is made checkindate {parameters.checkinDate} - checkoutdate {parameters.checkoutDate}"
                    + $" - customer data {parameters.numberAdult} adults and {parameters.numberKid} kids "
                    + $"- the booked room is type of !important {roomtype} !important";
                res.data = new Data
                {
                    facebook = new Facebook
                    {
                        text = str
                    }
                };

            }
            catch (Exception e)
            {
                res.data.facebook.text = e.ToString();
            }
            str = JsonConvert.SerializeObject(res);
            return str;
        }
    }
}