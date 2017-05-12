using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0511bv.Controllers
{
    public class Parameters
    {
        public string RoomType { get; set; }
        
        public DateTime checkinDate { get; set; }
        public DateTime checkoutDate { get; set; }
        public int numberAdult { get; set; }
        public int numberKid { get; set; }
        public string PeopleTypeAdult { get; set; }
        public string PeopleTypeKid { get; set; }

    }

    //public class Metadata
    //{
    //    public string intentId { get; set; }
    //    public string webhookUsed { get; set; }
    //    public string webhookForSlotFillingUsed { get; set; }
    //    public string intentName { get; set; }
    //}

    //public class Message
    //{
    //    public int type { get; set; }
    //    public string speech { get; set; }
    //}

    //public class Fulfillment
    //{
    //    public string speech { get; set; }
    //    public List<Message> messages { get; set; }
    //}

    public class Result
    {
        //public string source { get; set; }
        //public string resolvedQuery { get; set; }
        //public string speech { get; set; }
        public string action { get; set; }
        //public bool actionIncomplete { get; set; }
        public Parameters parameters { get; set; }
        public List<Context> contexts { get; set; }
        //public Metadata metadata { get; set; }
        //public Fulfillment fulfillment { get; set; }
        //public double score { get; set; }
    }

    //public class Status
    //{
    //    public int code { get; set; }
    //    public string errorType { get; set; }
    //}
    public class Context
    {
        public string name { get; set; }
        public Parameters2 parameters { get; set; }
        public int lifespan { get; set; }
    }


    public class Parameters2
    {
        public string RoomType { get; set; }
        //public string __invalid_name__PeopleTypeAdult.original { get; set; }
        //public string __invalid_name__checkinDate.original { get; set; }
        //public string numberKid { get; set; }
        //public string checkinDate { get; set; }
        //public string __invalid_name__numberKid.original { get; set; }
        //public string __invalid_name__checkoutDate.original { get; set; }
        //public string __invalid_name__numberAdult.original { get; set; }
        //public string checkoutDate { get; set; }
        //public string RoomType { get; set; }
        //public string PeopleTypeAdult { get; set; }
        //public string PeopleTypeKid { get; set; }
        //public string numberAdult { get; set; }
        //public string __invalid_name__PeopleTypeKid.original { get; set; }
        //public string __invalid_name__RoomType.original { get; set; }
    }
    public class RequestRootObject
    {
        //public string id { get; set; }
        //public string timestamp { get; set; }
        //public string lang { get; set; }
        public Result result { get; set; }
        //public Status status { get; set; }
        //public string sessionId { get; set; }
    }
}