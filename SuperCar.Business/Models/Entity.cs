using System;

namespace SuperCar.Business.Models
{
	public abstract class Entity
	{
		protected Entity()
		{
			Id = Guid.NewGuid();
		}

		public Guid Id { get; set; }
	}
}
