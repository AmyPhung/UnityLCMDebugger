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
    public sealed class camera_cfg_t : LCM.LCM.LCMEncodable
    {
        public int gain;
        public int exposure;
        public int binning;
        public int framerate;
        public int exit_app;
 
        public camera_cfg_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0xa9d746f8344af438L;
 
        static camera_cfg_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("mwt.camera_cfg_t"))
                return 0L;
 
            classes.Add("mwt.camera_cfg_t");
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
            outs.Write(this.gain); 
 
            outs.Write(this.exposure); 
 
            outs.Write(this.binning); 
 
            outs.Write(this.framerate); 
 
            outs.Write(this.exit_app); 
 
        }
 
        public camera_cfg_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public camera_cfg_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static mwt.camera_cfg_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            mwt.camera_cfg_t o = new mwt.camera_cfg_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.gain = ins.ReadInt32();
 
            this.exposure = ins.ReadInt32();
 
            this.binning = ins.ReadInt32();
 
            this.framerate = ins.ReadInt32();
 
            this.exit_app = ins.ReadInt32();
 
        }
 
        public mwt.camera_cfg_t Copy()
        {
            mwt.camera_cfg_t outobj = new mwt.camera_cfg_t();
            outobj.gain = this.gain;
 
            outobj.exposure = this.exposure;
 
            outobj.binning = this.binning;
 
            outobj.framerate = this.framerate;
 
            outobj.exit_app = this.exit_app;
 
            return outobj;
        }
    }
}

