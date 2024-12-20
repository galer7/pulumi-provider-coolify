import pulumi
import pulumi_coolify as coolify

my_random_resource = coolify.Random("myRandomResource", length=24)
pulumi.export("output", {
    "value": my_random_resource.result,
})
