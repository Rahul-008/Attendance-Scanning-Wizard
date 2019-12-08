using System;

namespace DataLayer.Models.BaseModels
{
    public abstract class BaseModel
    {

        public int Id { get; set; }

        private DateTime createdAt;

        public DateTime CreatedAt
        {

            get
            {
                if (createdAt == DateTime.MinValue)
                    return DateTime.Now;
                return createdAt;
            }
            private set => createdAt = value;

        }
        public abstract void IsVaild();
    }
}