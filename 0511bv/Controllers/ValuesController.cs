using _0511bv.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace _0511bv.Controllers
{
    public class ValuesController : ApiController
    {


        // POST api/values
        public async Task<HttpResponseMessage> Post()
        {
            //example request data
            //var requestSample = "{ 'id':'c833261e-f3c6-4564-8c11-4be73b4484e1','timestamp':'2017-05-11T16:42:49.117Z','lang':'en','result':{ 'source':'agent','resolvedQuery':'weather in london','speech':'','action':'','actionIncomplete':false,'parameters':{ 'city':'London'},'contexts':[],'metadata':{'intentId':'d4b0556f-2144-4a70-afe4-f7079180e3ff','webhookUsed':'true','webhookForSlotFillingUsed':'true','intentName':'weather in London'},'fulfillment':{'speech':'error!! web service fails','messages':[{'type':0,'speech':'error!! web service fails'}]},'score':1.0},'status':{'code':200,'errorType':'success'},'sessionId':'266f0bdd-cfab-461e-bb39-a2ed84144007'}";


            var str = "{'speech': 'do you want to book a room?','displayText': 'do you want to book a room?','data': {},'contextOut': [],'source': 'DuckDuckGo'}";


            var res = new ResRootObject();
            res.speech = "do you want to book a room?";
            res.displayText = "do you want to book a room?";
            res.contextOut = new List<object>();
            res.data = new Data();
            res.source = "DuckDuckGo";


            try
            {
                var jsonContent = await Request.Content.ReadAsStringAsync();
                RequestRootObject root = JsonConvert.DeserializeObject<RequestRootObject>(jsonContent);
                if (root.result.action.Equals("showroom"))
                {
                    var service = new RoomDisplayServices(root, res, str);
                    str = service.GenerateResponse();
                }
                else if (root.result.action.Equals("roomdisplay.roomdisplay-next"))
                {
                    var service = new BookingServices(root, res, str);
                    str = service.GenerateResponse();
                }
            }
            catch (Exception e)
            {
                //ERROR HANDEL
               
            }


            HttpResponseMessage response = new HttpResponseMessage()
            {
                Content = new StringContent(str, Encoding.UTF8, "application/json")
            };


            return response;
        }

    }





}
