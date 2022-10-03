using SharpDX.Direct2D1;
using SharpDX.Mathematics.Interop;
using System.Collections.Generic;

namespace covet.cc.Rust.Structs
{
    class Entity
    {
        public UInt64 EntityBase;

        public Entity(UInt64 Base)
        {
            this.EntityBase = Base;
        }

        public float Health
        {
            get
            {
                try
                {
                    return Memory.Memory.Mem.ReadVirtualMemory<float>((IntPtr)EntityBase + 0x20C);
                }
                catch
                {
                    return 0;
                }
            }
        }

  

        public bool IsLocalPlayer
        {
            get
            {
                try
                {
                    UInt64 PlayerModel = Memory.Memory.Mem.ReadVirtualMemory<UInt64>((IntPtr)EntityBase + 0x4A8);

                    return Memory.Memory.Mem.ReadVirtualMemory<bool>((IntPtr)PlayerModel + 0x259);
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool IsVisible
        {
            get
            {
                try
                {
                    UInt64 PlayerModel = Memory.Memory.Mem.ReadVirtualMemory<UInt64>((IntPtr)EntityBase + 0x4A8);

                    return Memory.Memory.Mem.ReadVirtualMemory<bool>((IntPtr)PlayerModel + 0x248);
                }
                catch
                {
                    return false;
                }
            }
        }


        public Vector3 Position
        {
            get
            {
                try
                {
                    UInt64 PlayerModel = Memory.Memory.Mem.ReadVirtualMemory<UInt64>((IntPtr)EntityBase + 0x4A8);

                    return Memory.Memory.Mem.ReadVirtualMemory<Vector3>((IntPtr)PlayerModel + 0x1D8);
                }
                catch
                {
                    return new Vector3(0, 0, 0);
                }
            }
        }

        public Vector3 Velocity
        {
            get
            {
                try
                {
                    UInt64 PlayerModel = Memory.Memory.Mem.ReadVirtualMemory<UInt64>((IntPtr)EntityBase + 0x4A8);

                    return Memory.Memory.Mem.ReadVirtualMemory<Vector3>((IntPtr)PlayerModel + 0x1f4);
                }
                catch
                {
                    return new Vector3(0, 0, 0);
                }
            }
        }
        

        public Vector2 ViewAngle
        {
            get
            {
             
                    UInt64 PlayerModel = Memory.Memory.Mem.ReadVirtualMemory<UInt64>((IntPtr)EntityBase + 0x4C8);

                    return Memory.Memory.Mem.ReadVirtualMemory<Vector2>((IntPtr)PlayerModel + 0x3C);
               
            }
            set
            {           
                    UInt64 PlayerModel = Memory.Memory.Mem.ReadVirtualMemory<UInt64>((IntPtr)EntityBase + 0x4C8);

                    Memory.Memory.Mem.WriteVirtualMemory<Vector2>((IntPtr)PlayerModel + 0x3C, value);                            
            }
        }
        public Vector2 RecoilAngle
        {
            get
            {

                UInt64 PlayerModel = Memory.Memory.Mem.ReadVirtualMemory<UInt64>((IntPtr)EntityBase + 0x4C8);

                return Memory.Memory.Mem.ReadVirtualMemory<Vector2>((IntPtr)PlayerModel + 0x64);

            }
            set
            {

                UInt64 PlayerModel = Memory.Memory.Mem.ReadVirtualMemory<UInt64>((IntPtr)EntityBase + 0x4C8);

                Memory.Memory.Mem.WriteVirtualMemory<Vector2>((IntPtr)PlayerModel + 0x64, value);


            }
        }
        public string Name
        {
            get
            {

                UInt64 PlayerModel = Memory.Memory.Mem.ReadVirtualMemory<UInt64>((IntPtr)EntityBase + 0x4E8);

                return Memory.Memory.ReadString((long)PlayerModel + 0x14 , 1);

            }
           
        }
      

     
    }

 
}
