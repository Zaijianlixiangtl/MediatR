using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace TestMediatR.Command
{
	public class CreateUserCommand :IRequest<string>
	{
	}

	public class UserCommandHandle : IRequestHandler<CreateUserCommand,string>
	{
		Task<string> IRequestHandler<CreateUserCommand, string>.Handle(CreateUserCommand request, CancellationToken cancellationToken)
		{
			return Task.FromResult("创建成功");
		}
	}
}
