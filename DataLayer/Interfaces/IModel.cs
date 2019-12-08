using System;

namespace DataLayer.Interfaces
{
    public interface IModel
    {
        int Id { get; set; }

        DateTime CreatedAt { get; }

        void IsValid();
    }
}
