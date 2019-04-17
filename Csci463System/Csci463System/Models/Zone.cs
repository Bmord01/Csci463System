using Csci463System.Interfaces;
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
            Elevator,
            Floor
        };

        public bool Manned;
        public ZoneType zoneType;
        public bool LockedDown;
        public string ZoneName;
        public static int uid = 1;
        public int UID;
        public bool ElevatorActive = false;
        public List<FireSensor> FSensors;
        public List<LightSensor> LSensors;
        public List<DoorSensor> DSensors;
        public List<Zone> zones;
        public List<Keypad> keypads;

        public Zone()
        {

        }
        public Zone(int inZoneType,string ZoneName)
        {
            UID = uid++;
            this.zoneType = (ZoneType) inZoneType;
            this.ZoneName = ZoneName;
            zones = new List<Zone>();
            LSensors = new List<LightSensor>();
            FSensors = new List<FireSensor>();
            DSensors = new List<DoorSensor>();
            keypads = new List<Keypad>();
            if(zoneType == ZoneType.Elevator)
            {
                ElevatorActive = true;
            }
        }

        public void ChangedMannedState()
        {
            if (Manned)
            {
                Manned = false;
                return;
            }
            else
            {
                Manned = true;
                return;
            }
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
            switch (type)
            {
                case 0:
                    FSensors.Add((FireSensor)new SensorService().CreateSensor(type));
                    break;
                case 1:
                    LSensors.Add((LightSensor)new SensorService().CreateSensor(type));
                    break;
                case 2:
                    DSensors.Add((DoorSensor)new SensorService().CreateSensor(type));
                    break;
                default:
                    break;
            }
            
        }

        public void AddInnerZone(int type)
        {
            if (zoneType == ZoneType.Elevator)
            {
                return;
            }
            zones.Add(new Zone(type,"zone1"));
        }
        public void AddKeypad()
        {
            if(zoneType == ZoneType.Elevator)
            {
                return;
            }
            keypads.Add(new Keypad());
        }

        public void LockDown()
        {
            if (zoneType == ZoneType.Elevator)
            {
                Deactivate();
                return;
            }
            LockedDown = true;
            foreach (Zone z in zones)
            {
                z.LockDown();
            }
        }

        public void Unlock()
        {
            if (zoneType == ZoneType.Elevator)
            {
                Activate();
                return;
            }
            LockedDown = false;
            foreach(Zone z in zones)
            {
                z.Unlock();
            }
        }

        public void Activate()
        {
            ElevatorActive = true;
        }

        public void Deactivate()
        {
            ElevatorActive = false;
        }

        public Tuple<List<ISensor>,List<Alarm>,List<int>> CheckSensors()
        {
            List<ISensor> sensors = new List<ISensor>();
            List<ISensor> sensorsIn = new List<ISensor>();
            List<Alarm> alarms = new List<Alarm>();
            List<int> uids = new List<int>();
            foreach(Zone z in zones)
            {
                sensorsIn = new List<ISensor>(z.GetAllSensors());
                foreach(ISensor s in sensorsIn)
                {
                    if (s.GetActive())
                    {
                        sensors.Add(s);
                        alarms.Add(s.GetAlarm());
                        uids.Add(s.getSensorUID());
                    }
                }
            }
            return Tuple.Create(sensors,alarms,uids);
        }
        public List<ISensor> GetAllSensors()
        {
            List<ISensor> sensors = new List<ISensor>();
            foreach (DoorSensor d in DSensors)
            {
                sensors.Add(d);
            }
            foreach (FireSensor f in FSensors)
            {
                sensors.Add(f);
            }
            foreach (LightSensor l in LSensors)
            {
                sensors.Add(l);
            }
            return sensors;
        }
    }
}
