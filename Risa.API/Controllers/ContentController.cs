using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Risa.SDK;

namespace Risa.API.Controllers
{
	[ApiController]
	public class ContentController : ControllerBase
	{
		[Route("api/v1/content/getRandom")]
		[HttpGet]
		public Content GetRandom()
		{
			return new Content { 
				Value = "お元気ですか!"
			};
		}

		[Route("api/v1/content/add")]
		[HttpPost]
		public void Add([FromBody] Content value)
		{
			Debug.WriteLine(value.Value);
		}
	}
}
