import * as pulumi from "@pulumi/pulumi";
import * as coolify from "@pulumi/coolify";

const myRandomResource = new coolify.Random("myRandomResource", {length: 24});
export const output = {
    value: myRandomResource.result,
};
