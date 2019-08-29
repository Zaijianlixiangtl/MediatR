using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestMediatR.Command;
using TestMediatR.Notity;

namespace TestMediatR.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private readonly IMediator mediator;

		public ValuesController(IMediator mediator)
		{
			this.mediator = mediator;
		}
		// GET api/values
		[HttpGet]
		public void Get()
		{
			mediator.Publish(new CreateUser() );

			mediator.Publish(new DeleteUser());

			var a =  mediator.Send(new CreateUserCommand());
		}

		
	}
}
