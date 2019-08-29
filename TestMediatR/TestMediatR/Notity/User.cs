using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace TestMediatR.Notity
{
	public class CreateUser : INotification
	{
	}

	public class DeleteUser : INotification
	{
	}

	public class CreateUserEvent : INotificationHandler<CreateUser>
	{
		public Task Handle(CreateUser notification, CancellationToken cancellationToken)
		{
			Console.WriteLine("创建用户成功");
			return Task.CompletedTask;
		}
	}

	public class DeleteUserEvent : INotificationHandler<DeleteUser>
	{
		public Task Handle(DeleteUser notification, CancellationToken cancellationToken)
		{
			Console.WriteLine("删除用户成功");
			return Task.CompletedTask;
		}
	}
}
