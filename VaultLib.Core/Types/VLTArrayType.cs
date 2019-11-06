﻿// This file is part of VaultLib by heyitsleo.
// 
// Created: 09/25/2019 @ 8:20 PM.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CoreLibraries.IO;
using VaultLib.Core.DB;
using VaultLib.Core.Types.EA.Reflection;
using VaultLib.Core.Utils;

namespace VaultLib.Core.Types
{
    public class VLTArrayType : VLTBaseType, ICanBootstrap, IReferencesStrings, IReferencesCollections
    {
        public ushort FieldSize { get; set; }

        public ushort Capacity { get; set; }

        public int ItemAlignment { get; set; }

        public Type ItemType { get; set; }

        public VLTBaseType[] Items { get; set; }

        public override void Read(Vault vault, BinaryReader br)
        {
            Capacity = br.ReadUInt16();
            var count = br.ReadUInt16();
            Debug.Assert(count <= Capacity);
            Items = new VLTBaseType[count];
            FieldSize = br.ReadUInt16();
            ushort _u1 = br.ReadUInt16();

            for (int i = 0; i < Items.Length; i++)
            {
                Items[i] = (VLTBaseType)Activator.CreateInstance(ItemType);
                Items[i].ArrayIndex = i;

                br.AlignReader(ItemAlignment);

                if (Items[i] is VLTUnknown unknown)
                {
                    unknown.Size = FieldSize;
                }

                var start = br.BaseStream.Position;

                Items[i].Collection = Collection;
                Items[i].Class = Class;
                Items[i].Field = Field;
                Items[i].Read(vault, br);

                if (!(Items[i] is PrimitiveTypeBase) && br.BaseStream.Position - start != FieldSize)
                {
                    Debug.WriteLine("{0} start at {1:X} end at {2:X} (diff {3} vs {4})", ItemType, start, br.BaseStream.Position, br.BaseStream.Position - start, FieldSize);
                    throw new Exception();
                }
            }

            br.BaseStream.Position += (Capacity - count) * FieldSize;
        }

        public override void Write(Vault vault, BinaryWriter bw)
        {
            bw.Write(Capacity);
            bw.Write((ushort)Items.Length);
            bw.Write(FieldSize);
            bw.Write((ushort)0);

            foreach (var t in Items)
            {
                bw.AlignWriter(ItemAlignment);
                long start = bw.BaseStream.Position;
                t.Write(vault, bw);
                if (!(t is PrimitiveTypeBase))
                {
                    Debug.Assert(bw.BaseStream.Position - start == FieldSize);
                }
            }

            for (int i = 0; i < Capacity - Items.Length; i++)
            {
                bw.AlignWriter(ItemAlignment);
                bw.Write(new byte[FieldSize]);
            }
        }

        /**
         * The reason these functions are implemented is because arrays may contain items that have pointers.
         * This system is complicated.
         */

        public IEnumerable<string> GetStrings()
        {
            return Items.OfType<IReferencesStrings>().SelectMany(r => r.GetStrings());
        }

        public void ReadPointerData(Vault vault, BinaryReader br)
        {
            foreach (var pointerObject in Items.OfType<IPointerObject>())
            {
                pointerObject.ReadPointerData(vault, br);
            }
        }

        public void WritePointerData(Vault vault, BinaryWriter bw)
        {
            foreach (var pointerObject in Items.OfType<IPointerObject>())
            {
                bw.AlignWriter(ItemAlignment);
                pointerObject.WritePointerData(vault, bw);
            }
        }

        public void AddPointers(Vault vault)
        {
            foreach (var pointerObject in Items.OfType<IPointerObject>())
            {
                pointerObject.AddPointers(vault);
            }
        }

        public override string ToString()
        {
            return string.Join<VLTBaseType>(" | ", Items);
        }

        public void Bootstrap()
        {
            Items = new VLTBaseType[0];
        }

        public IEnumerable<CollectionReferenceInfo> GetReferencedCollections(Database database, Vault vault)
        {
            return Items.OfType<IReferencesCollections>().SelectMany(rc => rc.GetReferencedCollections(database, vault));
        }

        public bool ReferencesCollection(string classKey, string collectionKey)
        {
            return Items.OfType<IReferencesCollections>().Any(rc => rc.ReferencesCollection(classKey, collectionKey));
        }
    }
}