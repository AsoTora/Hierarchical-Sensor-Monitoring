﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HSMServer.Authentication;
using SensorsService;

namespace HSMServer.MonitoringServerCore
{
    public interface IMonitoringQueueManager
    {
        public bool IsUserRegistered(User user);
        public void AddUserSession(User user);
        public void AddUserSession(User user, IPAddress address, int port);
        public void RemoveUserSession(User user);
        public List<SensorUpdateMessage> GetUserUpdates(User user);
        public void AddSensorData(SensorUpdateMessage message);
    }
}
