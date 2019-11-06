﻿// This file is part of VaultLib by heyitsleo.
// 
// Created: 10/19/2019 @ 5:40 PM.

using System.IO;
using VaultLib.Core.Utils;

namespace VaultLib.Core.Types
{
    public class DynamicSizeArray<T> : VLTBaseType, IPointerObject where T : VLTBaseType, new()
    {
        public T[] Items { get; set; }

        private uint _pointer;
        private long _srcPtr;
        private long _dstPtr;

        public override void Read(Vault vault, BinaryReader br)
        {
            _pointer = br.ReadUInt32();
            Items = new T[br.ReadInt32()];
        }

        public override void Write(Vault vault, BinaryWriter bw)
        {
            _srcPtr = bw.BaseStream.Position;
            bw.Write(0);
            bw.Write(Items.Length);
        }

        public void ReadPointerData(Vault vault, BinaryReader br)
        {
            br.BaseStream.Position = _pointer;
            for (int i = 0; i < Items.Length; i++)
            {
                Items[i] = new T();
                Items[i].Read(vault, br);
            }
        }

        public void WritePointerData(Vault vault, BinaryWriter bw)
        {
            _dstPtr = bw.BaseStream.Position;
            foreach (var vltBaseType in Items)
            {
                vltBaseType.Write(vault, bw);
            }
        }

        public void AddPointers(Vault vault)
        {
            vault.SaveContext.AddPointer(_srcPtr, _dstPtr, false);
        }
    }
}