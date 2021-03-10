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
    public sealed class controller_status_t : LCM.LCM.LCMEncodable
    {
        public double cmd;
        public double measure;
        public double integral;
        public double derivative;
        public double output;
        public double kp;
        public double ki;
        public double kd;
        public double tau;
        public double output_scale;
 
        public controller_status_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0xc07e52da64ca459eL;
 
        static controller_status_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("mwt.controller_status_t"))
                return 0L;
 
            classes.Add("mwt.controller_status_t");
            ulong hash = LCM_FINGERPRINT_BASE
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
            outs.Write(this.cmd); 
 
            outs.Write(this.measure); 
 
            outs.Write(this.integral); 
 
            outs.Write(this.derivative); 
 
            outs.Write(this.output); 
 
            outs.Write(this.kp); 
 
            outs.Write(this.ki); 
 
            outs.Write(this.kd); 
 
            outs.Write(this.tau); 
 
            outs.Write(this.output_scale); 
 
        }
 
        public controller_status_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public controller_status_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static mwt.controller_status_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            mwt.controller_status_t o = new mwt.controller_status_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.cmd = ins.ReadDouble();
 
            this.measure = ins.ReadDouble();
 
            this.integral = ins.ReadDouble();
 
            this.derivative = ins.ReadDouble();
 
            this.output = ins.ReadDouble();
 
            this.kp = ins.ReadDouble();
 
            this.ki = ins.ReadDouble();
 
            this.kd = ins.ReadDouble();
 
            this.tau = ins.ReadDouble();
 
            this.output_scale = ins.ReadDouble();
 
        }
 
        public mwt.controller_status_t Copy()
        {
            mwt.controller_status_t outobj = new mwt.controller_status_t();
            outobj.cmd = this.cmd;
 
            outobj.measure = this.measure;
 
            outobj.integral = this.integral;
 
            outobj.derivative = this.derivative;
 
            outobj.output = this.output;
 
            outobj.kp = this.kp;
 
            outobj.ki = this.ki;
 
            outobj.kd = this.kd;
 
            outobj.tau = this.tau;
 
            outobj.output_scale = this.output_scale;
 
            return outobj;
        }
    }
}
