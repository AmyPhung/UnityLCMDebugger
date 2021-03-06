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
    public sealed class mini_rov_attitude_t : LCM.LCM.LCMEncodable
    {
        public mwt.header_t header;
        public double roll_deg;
        public double pitch_deg;
        public double yaw_deg;
 
        public mini_rov_attitude_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x9f02cf94eb7c49f0L;
 
        static mini_rov_attitude_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("mwt.mini_rov_attitude_t"))
                return 0L;
 
            classes.Add("mwt.mini_rov_attitude_t");
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
 
            outs.Write(this.roll_deg); 
 
            outs.Write(this.pitch_deg); 
 
            outs.Write(this.yaw_deg); 
 
        }
 
        public mini_rov_attitude_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public mini_rov_attitude_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static mwt.mini_rov_attitude_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            mwt.mini_rov_attitude_t o = new mwt.mini_rov_attitude_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.header = mwt.header_t._decodeRecursiveFactory(ins);
 
            this.roll_deg = ins.ReadDouble();
 
            this.pitch_deg = ins.ReadDouble();
 
            this.yaw_deg = ins.ReadDouble();
 
        }
 
        public mwt.mini_rov_attitude_t Copy()
        {
            mwt.mini_rov_attitude_t outobj = new mwt.mini_rov_attitude_t();
            outobj.header = this.header.Copy();
 
            outobj.roll_deg = this.roll_deg;
 
            outobj.pitch_deg = this.pitch_deg;
 
            outobj.yaw_deg = this.yaw_deg;
 
            return outobj;
        }
    }
}

