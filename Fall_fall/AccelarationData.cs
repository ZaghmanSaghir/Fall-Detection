﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websocket.Client;

using WebSocketSharp;

namespace Fall_fall
{
    public class AccelarationData
    {
        public void Pussy()
        {
            // Creating instance for webSocketserver
            WebSocket ws = new WebSocket("ws://192.168.0.27:8081/sensor/connect?type=android.sensor.accelerometer");

            ws.Connect();
        }
        
        

        
    }
}
