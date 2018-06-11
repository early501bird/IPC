using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Text;
using System.Threading.Tasks;

namespace IpcService
{
    class Program
    {
        static void Main(string[] args)
        {
            IpcServerChannel channel = new IpcServerChannel("ServerChannel");
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(BaseData), "RemoteData", WellKnownObjectMode.SingleCall);

            Console.WriteLine("press return to exit");
            Console.ReadLine();
        }
    }
}
