﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace RemotingServiceHost
{
  class Program
  {
    static void Main(string[] args)
    {
      HelloRemotingService.HelloRemotingService remotingService = new HelloRemotingService.HelloRemotingService();
      TcpChannel tcpChannel = new TcpChannel(8080);
      ChannelServices.RegisterChannel(tcpChannel);
      RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService.HelloRemotingService), "GetMessage", WellKnownObjectMode.Singleton);
      Console.WriteLine("Remoting service is started at " + DateTime.Now);
      Console.ReadLine();
    }
  }
}
