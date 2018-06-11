using System;

namespace Common
{
    public class BaseData : MarshalByRefObject
    {
        public BaseData()
        {
            Console.WriteLine("base data constructor called");
        }
        public string Greeting(string name)
        {
            var msg = "hellow " + name;
            Console.WriteLine(msg);
            return msg;
        }
        public string MessageData { get; set; } = "this is base message";
    }
}
