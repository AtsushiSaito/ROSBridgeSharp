using System;

namespace RBS.Messages.turtlebot3_msgs
{
    [System.Serializable]
    public class SensorState : ExtendMessage
    {
        public uint BUMPER_FORWARD;
        public uint BUMPER_BACKWARD;
        public uint CLIFF;
        public uint SONAR;
        public uint ILLUMINATION;
        public uint BUTTON0;
        public uint BUTTON1;
        public uint ERROR_LEFT_MOTOR;
        public uint ERROR_RIGHT_MOTOR;
        public uint TORQUE_ON;
        public uint TORQUE_OFF;
        public RBS.Messages.std_msgs.Header header;
        public uint bumper;
        public float cliff;
        public float sonar;
        public float illumination;
        public uint led;
        public uint button;
        public bool torque;
        public int left_encoder;
        public int right_encoder;
        public float battery;
        public override string Type() { return "turtlebot3_msgs/SensorState"; }
        public SensorState()
        {
            BUMPER_FORWARD = 1;
            BUMPER_BACKWARD = 2;
            CLIFF = 1;
            SONAR = 1;
            ILLUMINATION = 1;
            BUTTON0 = 1;
            BUTTON1 = 2;
            ERROR_LEFT_MOTOR = 1;
            ERROR_RIGHT_MOTOR = 2;
            TORQUE_ON = 1;
            TORQUE_OFF = 2;
            header = new RBS.Messages.std_msgs.Header();
            bumper = 0;
            cliff = 0.0f;
            sonar = 0.0f;
            illumination = 0.0f;
            led = 0;
            button = 0;
            torque = false;
            left_encoder = 0;
            right_encoder = 0;
            battery = 0.0f;
        }
    }
}