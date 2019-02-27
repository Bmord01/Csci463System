﻿using Csci463System.Interfaces;
using Csci463System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Models
{
    public class Zone : IZone
    {
        public enum ZoneType
        {
            Building=0,
            BuildingZone,
            Room,
            Hallway,
            Stairway,
            Elevator
        };

        public bool Manned;
        public ZoneType zoneType;
        public bool LockedDown;
        public string Uid;
        public bool ElevatorActive = false;
        public List<ISensor> sensors;
        public List<Zone> zones;
        public List<Keypad> keypads;

        public Zone(ZoneType inZoneType)
        {
            this.zoneType = inZoneType;
            zones = new List<Zone>();
            sensors = new List<ISensor>();
            keypads = new List<Keypad>();
            if(zoneType == ZoneType.Elevator)
            {
                ElevatorActive = true;
            }
        }

        public List<ISensor> GetSensors()
        {
            return sensors;
        }
        public List<Zone> GetZones()
        {
            return zones;
        }
        public List<Keypad> GetKeypads()
        {
            return keypads;
        }
        
        public void AddSensor(int type)
        {
            if (zoneType == ZoneType.Elevator)
            {
                return;
            }
            sensors.Add(new SensorService().CreateSensor((SensorService.SensorType)type));
        }

        public void AddInnerZone()
        {
            if (zoneType == ZoneType.Elevator)
            {
                return;
            }
            zones.Add(new Zone(0));
        }
        public void AddKeypad()
        {

        }

        public void LockDown()
        {
            if (zoneType == ZoneType.Elevator)
            {
                Deactivate();
                return;
            }
            LockedDown = true;
        }

        public void Unlock()
        {
            if (zoneType == ZoneType.Elevator)
            {
                Activate();
                return;
            }
            LockedDown = false;
        }

        public void Activate()
        {
            ElevatorActive = true;
        }

        public void Deactivate()
        {
            ElevatorActive = false;
        }
    }
}