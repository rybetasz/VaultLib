﻿// This file is part of VaultLib by heyitsleo.
// 
// Created: 10/19/2019 @ 4:49 PM.

using System.Collections.Generic;
using System.IO;
using VaultLib.Core.Utils;

namespace VaultLib.Core.Types
{
    public class VLTListContainer<T> : VLTBaseType, IPointerObject where T : VLTBaseType, new()
    {
        public List<T> Items { get; }

        private uint _pointer;

        private long _srcPtr;
        private long _dstPtr;

        public VLTListContainer(int count)
        {
            Items = new List<T>(count);
        }

        public override void Read(Vault vault, BinaryReader br)
        {
            _pointer = br.ReadUInt32();
        }

        public override void Write(Vault vault, BinaryWriter bw)
        {
            _srcPtr = bw.BaseStream.Position;
            bw.Write(0);
        }

        public void ReadPointerData(Vault vault, BinaryReader br)
        {
            br.BaseStream.Position = _pointer;

            for (int i = 0; i < Items.Capacity; i++)
            {
                T item = new T();
                item.Read(vault, br);
                Items.Add(item);
            }
        }

        public void WritePointerData(Vault vault, BinaryWriter bw)
        {
            _dstPtr = bw.BaseStream.Position;

            foreach (var item in Items)
            {
                item.Write(vault, bw);
            }
        }

        public void AddPointers(Vault vault)
        {
            vault.SaveContext.AddPointer(_srcPtr, _dstPtr, false);
        }
    }
}