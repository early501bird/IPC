using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Text;
using System.Threading.Tasks;

namespace IpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IpcClientChannel channel = new IpcClientChannel();
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownClientType(typeof(BaseData), "ipc://ServerChannel/RemoteData");
            //BaseData data = (BaseData)Activator.GetObject(typeof(BaseData), "ipc://ServerChannel/RemoteData");
            //if (data == null)
            //{
            //    Console.WriteLine("could not locate server");
            //    return;
            //}
            //BaseData data = new BaseData();
            //Console.WriteLine(data.Greeting("lee"));
            BaseData greeting = new BaseData();
            Console.WriteLine(greeting.MessageData);
            Console.ReadLine();
        }
    }
}
