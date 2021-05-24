# HttpPerformance
HttpPerformance a  is a small library based on.NET5 helps developers to logs the time of request all incoming HTTP into applications. if you don't  want log all HTTP request in your application .you can set the HttpPerformance attribute on the desired controller or aaction

# Getting started
you can install  HttpPerformance on nuget.

Install-Package httpPerformance -Version 1.0.0

# how to use
it's easy ! you soud add middleware in startup class

  app.UseHttpPerformance(new SqlServerStoreProvider("Data Source=.;Initial Catalog=httpPerformance_db;Integrated security=true;MultipleActiveResultSets=True;"));
