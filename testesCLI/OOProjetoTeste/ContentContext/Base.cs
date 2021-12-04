using System;
using OOProjetoTeste.NotificationContext;

namespace OOProjetoTeste.ContentContext
{

    public abstract class Base : Notifiable
    {

        public Guid Id { get; set; }
        public Base()
        {
            Id = Guid.NewGuid();
        }

    }
}