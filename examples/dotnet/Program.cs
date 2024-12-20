using System.Collections.Generic;
using System.Linq;
using Pulumi;
using coolify = Pulumi.coolify;

return await Deployment.RunAsync(() => 
{
    var myRandomResource = new coolify.Random("myRandomResource", new()
    {
        Length = 24,
    });

    return new Dictionary<string, object?>
    {
        ["output"] = 
        {
            { "value", myRandomResource.Result },
        },
    };
});

