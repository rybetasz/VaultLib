﻿using System.IO;

namespace VaultLib.Core.Chunks
{
    public class VLTVersionChunk : ChunkBase
    {
        public ulong Version { get; set; }

        public override void Read(Vault vault, BinaryReader br)
        {
            Version = br.ReadUInt64();

            //Debug.WriteLine("VLT version is: {0:X16}", Version);
        }

        public override void Write(Vault vault, BinaryWriter bw)
        {
            bw.Write(0x6838F8C1836A18DE);
        }

        public override uint ID => 0x56657273;
        public override uint Size { get; set; }
        public override long Offset { get; set; }
    }
}
