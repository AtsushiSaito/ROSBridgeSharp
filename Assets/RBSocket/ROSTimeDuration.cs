using System.Collections.Generic;
using UnityEngine;
using System;
// using System.Math;

namespace RBS
{
    public class Time
    {
        public int secs, nsecs;
        public Time() { }
        public Time(double time) { fromSec(time); }
        public Time(int secs, int nsecs)
        {
            this.secs = secs;
            this.nsecs = nsecs;
        }

        public Time fromSec(double t)
        {
            this.secs = (int)Math.Floor(t);
            this.nsecs = (int)Math.Round((t - this.secs) * 1e9);
            return this;
        }

        public static DateTime UNIX_EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public RBS.Messages.Time Now()
        {
            TimeSpan timeSpan = DateTime.Now.ToUniversalTime() - UNIX_EPOCH;
            double msecs = timeSpan.TotalMilliseconds;
            uint sec = (uint)(msecs / 1000);

            RBS.Messages.Time timeMessage = new Messages.Time();
            timeMessage.secs = sec;
            timeMessage.nsecs = (uint)((msecs / 1000 - sec) * 1e+9);
            return timeMessage;
        }
    }

    public class Duration
    {
        public int secs, nsecs;
        public Duration() { }
        public Duration(double time) { fromSec(time); }
        public Duration(int secs, int nsecs)
        {
            this.secs = secs;
            this.nsecs = nsecs;
        }

        public Duration fromSec(double t)
        {
            this.secs = (int)Math.Floor(t);
            this.nsecs = (int)Math.Round((t - this.secs) * 1e9);
            return this;
        }
    }
}