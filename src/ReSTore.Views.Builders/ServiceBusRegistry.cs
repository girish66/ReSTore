﻿using System;
using System.Configuration;
using MassTransit;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace ReSTore.Views.Builders
{
    public class ServiceBusRegistry : Registry
    {
        public ServiceBusRegistry()
        {
            For<IServiceBus>().Use("Creating the message bus", CreateMessageBus);
        }

        public static IServiceBus CreateMessageBus(IContext context)
        {
            var bus = ServiceBusFactory.New(cfg =>
                {
                    cfg.ReceiveFrom("rabbitmq://localhost/restore-viewbuilders");
                    cfg.UseRabbitMq();
                });
            return bus;
        }
    }
}