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
    public sealed class string_t : LCM.LCM.LCMEncodable
    {
        public mwt.header_t header;
        public String val;
 
        public string_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0xe82a35ae48fcbf5fL;
 
        static string_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("mwt.string_t"))
                return 0L;
 
            classes.Add("mwt.string_t");
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
            byte[] __strbuf = null;
            this.header._encodeRecursive(outs); 
 
            __strbuf = System.Text.Encoding.GetEncoding("US-ASCII").GetBytes(this.val); outs.Write(__strbuf.Length+1); outs.Write(__strbuf, 0, __strbuf.Length); outs.Write((byte) 0); 
 
        }
 
        public string_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public string_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static mwt.string_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            mwt.string_t o = new mwt.string_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            byte[] __strbuf = null;
            this.header = mwt.header_t._decodeRecursiveFactory(ins);
 
            __strbuf = new byte[ins.ReadInt32()-1]; ins.ReadFully(__strbuf); ins.ReadByte(); this.val = System.Text.Encoding.GetEncoding("US-ASCII").GetString(__strbuf);
 
        }
 
        public mwt.string_t Copy()
        {
            mwt.string_t outobj = new mwt.string_t();
            outobj.header = this.header.Copy();
 
            outobj.val = this.val;
 
            return outobj;
        }
    }
}

