using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class BatteryState : ExtendMessage
    {
        public byte POWER_SUPPLY_STATUS_UNKNOWN;
        public byte POWER_SUPPLY_STATUS_CHARGING;
        public byte POWER_SUPPLY_STATUS_DISCHARGING;
        public byte POWER_SUPPLY_STATUS_NOT_CHARGING;
        public byte POWER_SUPPLY_STATUS_FULL;
        public byte POWER_SUPPLY_HEALTH_UNKNOWN;
        public byte POWER_SUPPLY_HEALTH_GOOD;
        public byte POWER_SUPPLY_HEALTH_OVERHEAT;
        public byte POWER_SUPPLY_HEALTH_DEAD;
        public byte POWER_SUPPLY_HEALTH_OVERVOLTAGE;
        public byte POWER_SUPPLY_HEALTH_UNSPEC_FAILURE;
        public byte POWER_SUPPLY_HEALTH_COLD;
        public byte POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE;
        public byte POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE;
        public byte POWER_SUPPLY_TECHNOLOGY_UNKNOWN;
        public byte POWER_SUPPLY_TECHNOLOGY_NIMH;
        public byte POWER_SUPPLY_TECHNOLOGY_LION;
        public byte POWER_SUPPLY_TECHNOLOGY_LIPO;
        public byte POWER_SUPPLY_TECHNOLOGY_LIFE;
        public byte POWER_SUPPLY_TECHNOLOGY_NICD;
        public byte POWER_SUPPLY_TECHNOLOGY_LIMN;
        public RBS.Messages.std_msgs.Header header;
        public float voltage;
        public float current;
        public float charge;
        public float capacity;
        public float design_capacity;
        public float percentage;
        public byte power_supply_status;
        public byte power_supply_health;
        public byte power_supply_technology;
        public bool present;
        public float[] cell_voltage;
        public string location;
        public string serial_number;
        public override string Type() { return "sensor_msgs/BatteryState"; }
        public BatteryState()
        {
            POWER_SUPPLY_STATUS_UNKNOWN = 0;
            POWER_SUPPLY_STATUS_CHARGING = 1;
            POWER_SUPPLY_STATUS_DISCHARGING = 2;
            POWER_SUPPLY_STATUS_NOT_CHARGING = 3;
            POWER_SUPPLY_STATUS_FULL = 4;
            POWER_SUPPLY_HEALTH_UNKNOWN = 0;
            POWER_SUPPLY_HEALTH_GOOD = 1;
            POWER_SUPPLY_HEALTH_OVERHEAT = 2;
            POWER_SUPPLY_HEALTH_DEAD = 3;
            POWER_SUPPLY_HEALTH_OVERVOLTAGE = 4;
            POWER_SUPPLY_HEALTH_UNSPEC_FAILURE = 5;
            POWER_SUPPLY_HEALTH_COLD = 6;
            POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE = 7;
            POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE = 8;
            POWER_SUPPLY_TECHNOLOGY_UNKNOWN = 0;
            POWER_SUPPLY_TECHNOLOGY_NIMH = 1;
            POWER_SUPPLY_TECHNOLOGY_LION = 2;
            POWER_SUPPLY_TECHNOLOGY_LIPO = 3;
            POWER_SUPPLY_TECHNOLOGY_LIFE = 4;
            POWER_SUPPLY_TECHNOLOGY_NICD = 5;
            POWER_SUPPLY_TECHNOLOGY_LIMN = 6;
            header = new RBS.Messages.std_msgs.Header();
            voltage = 0.0f;
            current = 0.0f;
            charge = 0.0f;
            capacity = 0.0f;
            design_capacity = 0.0f;
            percentage = 0.0f;
            power_supply_status = 0;
            power_supply_health = 0;
            power_supply_technology = 0;
            present = false;
            cell_voltage = new float[0];
            location = "";
            serial_number = "";
        }
    }
}