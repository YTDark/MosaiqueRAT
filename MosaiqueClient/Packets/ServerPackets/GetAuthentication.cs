﻿using Client.Controllers;
using ZeroFormatter;

namespace Client.Packets.ServerPackets
{
    [ZeroFormattable]
    public class GetAuthentication : IPackets
    {
        public override TypePackets Type
        {
            get
            {
                return TypePackets.GetAuthentication;
            }
        }

        public void Execute(ClientMosaique client)
        {
            client.send(this);
        }
    }
}
