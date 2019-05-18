﻿using System;

namespace Plus.Event.Bus.Entities
{
    [Serializable]
    public class DomainEventEntry
    {
        public object SourceEntity
        {
            get;
        }

        public IEventData EventData
        {
            get;
        }

        public DomainEventEntry(object sourceEntity, IEventData eventData)
        {
            SourceEntity = sourceEntity;
            EventData = eventData;
        }
    }
}