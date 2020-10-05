using System.Threading.Tasks;
using GraphQL.Core.API.GraphQL;
using GraphQL.Core.API.Schemas;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL.Core.API.Controllers
{
    [Route("graphql")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        public GraphQLController(MessageSchema schema)
        {
            _schema = schema;
        }

        private readonly MessageSchema _schema;

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = _schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = query.Variables.ToInputs();
            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest(result);
            }

            return Ok(result.Data);
        }
    }
}