﻿using DiscordBridge.CustomNetwork.RoleSync;
using DiscordBridge.CustomNetwork.Tickets;
using System;
using System.IO;

namespace DiscordBridge.CustomNetwork
{
    public static class WriterExtensions
    {
        public static BinaryWriter Write(this BinaryWriter writer, RoleSyncTicket ticket)
        {
            writer.Write(ticket.Code);
            writer.Write(ticket.ChangedAt.Ticks);
            writer.Write(ticket.CreatedAt.Ticks);
            writer.Write(ticket.Account);

            return writer;
        }

        public static BinaryWriter Write(this BinaryWriter writer, RoleSyncAccount account)
        {
            writer.Write(account.Name);
            writer.Write(account.Id);

            return writer;
        }

        public static BinaryWriter Write(this BinaryWriter writer, DateTime dateTime)
        {
            writer.Write(dateTime.ToBinary());
            return writer;
        }

        public static BinaryWriter Write(this BinaryWriter writer, TimeSpan timeSpan)
        {
            writer.Write(timeSpan.Ticks);
            return writer;
        }
    }
}
