﻿using System;

namespace Weapsy.Blog.Domain.Post.Events
{
	public class PostUnpublishedEvent : IDomainEvent
	{
		public Guid Id { get; private set; }

		public PostUnpublishedEvent(Guid id)
		{
			Id = id;
		}
	}
}
