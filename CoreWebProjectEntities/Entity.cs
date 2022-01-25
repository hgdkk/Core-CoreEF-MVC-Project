using System;

namespace CoreWebProjectEntities
{
    public class Entity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
