using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using WebApp2.Options.Configuration;

namespace WebApp2.Extensions.Authorization
{
    public class SkipCodeRequirement : AuthorizationHandler<SkipCodeRequirement>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, SkipCodeRequirement requirement)
        {
            var user = context.User;
            if (user.IsInRole("Tester"))
            {
                // todo: 如果加了某个固定的 header/param 则不对该次API的请求进行身份验证。
                // 可以用 Middle 实现类似的效果？
            }
            context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}