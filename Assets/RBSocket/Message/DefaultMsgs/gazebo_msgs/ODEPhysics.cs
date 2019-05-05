using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class ODEPhysics : ExtendMessage
    {
        public bool auto_disable_bodies;
        public uint sor_pgs_precon_iters;
        public uint sor_pgs_iters;
        public double sor_pgs_w;
        public double sor_pgs_rms_error_tol;
        public double contact_surface_layer;
        public double contact_max_correcting_vel;
        public double cfm;
        public double erp;
        public uint max_contacts;
        public override string Type() { return "gazebo_msgs/ODEPhysics"; }
        public ODEPhysics()
        {
            auto_disable_bodies = false;
            sor_pgs_precon_iters = 0;
            sor_pgs_iters = 0;
            sor_pgs_w = 0.0f;
            sor_pgs_rms_error_tol = 0.0f;
            contact_surface_layer = 0.0f;
            contact_max_correcting_vel = 0.0f;
            cfm = 0.0f;
            erp = 0.0f;
            max_contacts = 0;
        }
    }
}