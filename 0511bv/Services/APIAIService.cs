using _0511bv.Controllers;


namespace _0511bv.Services
{
    public abstract class APIAIService
    {
        protected RequestRootObject root;
        protected ResRootObject res;
        protected string str;
        public APIAIService(RequestRootObject root, ResRootObject res, string str)
        {
            this.root = root;
            this.res = res;
            this.str = str;
        }

        public abstract string GenerateResponse();

    }
}