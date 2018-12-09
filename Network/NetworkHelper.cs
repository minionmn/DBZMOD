﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Terraria;

namespace Network
{
    internal class NetworkHelper
    { 
        public const byte TransformationHandler = 1;
        public const byte FlightMovementHandler = 2;
        //public const byte FlightAuraHandler = 3;
        //public const byte FlightHandler = 4;
        //public const byte KiChargingHandler = 5;
        //public const byte KiChangeHandler = 6;
        //public const byte KiFragmentHandler = 7;
        public const byte PlayerHandler = 8;

        internal static TransformationPacketHandler formSync = new TransformationPacketHandler(TransformationHandler);
        internal static FlightMovementPacketHandler flightMovementSync = new FlightMovementPacketHandler(FlightMovementHandler);
        internal static PlayerPacketHandler playerSync = new PlayerPacketHandler(PlayerHandler);
        //internal static FlightAuraPacketHandler flightAuraSync = new FlightAuraPacketHandler(FlightAuraHandler);
        //internal static FlightPacketHandler flightSync = new FlightPacketHandler(FlightHandler);
        //internal static KiChargingPacketHandler kiChargingSync = new KiChargingPacketHandler(KiChargingHandler);
        //internal static KiChangePacketHandler kiChangeSync = new KiChangePacketHandler(KiChangeHandler);
        //internal static KiFragmentPacketHandler kiFragmentSync = new KiFragmentPacketHandler(KiFragmentHandler);

        public static void HandlePacket(BinaryReader r, int fromWho)
        {
            switch (r.ReadByte())
            {
                case TransformationHandler:
                    formSync.HandlePacket(r, fromWho);
                    break;
                case FlightMovementHandler:
                    flightMovementSync.HandlePacket(r, fromWho);
                    break;
                //case FlightAuraHandler:
                //    flightAuraSync.HandlePacket(r, fromWho);
                //    break;
                //case FlightHandler:
                //    flightSync.HandlePacket(r, fromWho);
                //    break;
                //case KiChargingHandler:
                //    kiChargingSync.HandlePacket(r, fromWho);
                //    break;
                //case KiChangeHandler:
                //    kiChangeSync.HandlePacket(r, fromWho);
                //    break;
                //case KiFragmentHandler:
                //    kiFragmentSync.HandlePacket(r, fromWho);
                //    break;
                case PlayerHandler:
                    playerSync.HandlePacket(r, fromWho);
                    break;
            }
        }
    }
}