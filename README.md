# ASP.NET Core Project Template for Platform.sh

This project provides a starter kit for ASP.NET Core 2.2 projects hosted on Platform.sh. 

You may choose to use this as a template for your new project, or borrow whatever code is needed to make your existing application work on Platform.

## Key Elements of this Repository

This repository is was created from an ASP.NET Core MVC template and most of it still resembles that.

Here are the files that have been added or significantly changed:

#### Platform-specific config files:

* [.platform/routes.yaml](.platform/routes.yaml) describes routing of incoming HTTP requests:
    * What URLs and domains to listen on
    * Redirects
    * Caching
    * SSI/HSTS
* [.platform/services.yaml](.platform/services.yaml) - Describes related services:
    * MySQL
    * Redis
    * RabbitMQ
    * ElasticSearch
    * ...

* [.platform.app.yaml](.platform.app.yaml) - Describes the application
    * Application type
    * Build & deployment process
    * Webserver configuration
    * Disk allocation

#### Source Code:
* [Program.cs](Program.cs)
    * We've modified this file to look for Platform-specific environment variables on startup, and listen on the correct TCP port.
* [Startup.cs](Startup.cs)
    * We've added a DbContext and a Redis cache as an example on how to do these.
    * We've removed `app.UseHttpsRedirection();` as this is now handled in [.platform/routes.yaml](.platform/routes.yaml).
 * [Helpers/PlatformRelationship.cs](Helpers/PlatformRelationship.cs)
    * This is a simple helper class for retrieving connection strings for services.

#### Full Documentation
Please see the [documentation](https://docs.platform.sh/) for more information on these files.