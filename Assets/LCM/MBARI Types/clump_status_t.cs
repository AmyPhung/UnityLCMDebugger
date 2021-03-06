/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace mwt
{
    public sealed class clump_status_t : LCM.LCM.LCMEncodable
    {
        public mwt.header_t header;
        public double heading_deg;
        public double turns;
        public double depth_m;
        public double altitude_m;
        public double delta_m;
        public double oxygen_um;
        public double analog_1;
        public double autohead_sp_deg;
        public bool autohead_enable;
        public double camera_tilt_deg;
 
        public clump_status_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x9dc3009e59c16737L;
 
        static clump_status_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("mwt.clump_status_t"))
                return 0L;
 
            classes.Add("mwt.clump_status_t");
            ulong hash = LCM_FINGERPRINT_BASE
                 + mwt.header_t._hashRecursive(classes)
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            this.header._encodeRecursive(outs); 
 
            outs.Write(this.heading_deg); 
 
            outs.Write(this.turns); 
 
            outs.Write(this.depth_m); 
 
            outs.Write(this.altitude_m); 
 
            outs.Write(this.delta_m); 
 
            outs.Write(this.oxygen_um); 
 
            outs.Write(this.analog_1); 
 
            outs.Write(this.autohead_sp_deg); 
 
            outs.Write(this.autohead_enable); 
 
            outs.Write(this.camera_tilt_deg); 
 
        }
 
        public clump_status_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public clump_status_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static mwt.clump_status_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            mwt.clump_status_t o = new mwt.clump_status_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.header = mwt.header_t._decodeRecursiveFactory(ins);
 
            this.heading_deg = ins.ReadDouble();
 
            this.turns = ins.ReadDouble();
 
            this.depth_m = ins.ReadDouble();
 
            this.altitude_m = ins.ReadDouble();
 
            this.delta_m = ins.ReadDouble();
 
            this.oxygen_um = ins.ReadDouble();
 
            this.analog_1 = ins.ReadDouble();
 
            this.autohead_sp_deg = ins.ReadDouble();
 
            this.autohead_enable = ins.ReadBoolean();
 
            this.camera_tilt_deg = ins.ReadDouble();
 
        }
 
        public mwt.clump_status_t Copy()
        {
            mwt.clump_status_t outobj = new mwt.clump_status_t();
            outobj.header = this.header.Copy();
 
            outobj.heading_deg = this.heading_deg;
 
            outobj.turns = this.turns;
 
            outobj.depth_m = this.depth_m;
 
            outobj.altitude_m = this.altitude_m;
 
            outobj.delta_m = this.delta_m;
 
            outobj.oxygen_um = this.oxygen_um;
 
            outobj.analog_1 = this.analog_1;
 
            outobj.autohead_sp_deg = this.autohead_sp_deg;
 
            outobj.autohead_enable = this.autohead_enable;
 
            outobj.camera_tilt_deg = this.camera_tilt_deg;
 
            return outobj;
        }
    }
}

