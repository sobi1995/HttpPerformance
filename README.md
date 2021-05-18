# HttpPerformance
HttpPerformance is a small middleware based on .NET5 which helps developers to logs nad check time of requst all incoming http to their applications into a filestorage.

 
1- Install the package via nuget in visualstudio :

Install-Package httpPerformance -Version 1.0.0
 
 
app.UseHttpPerformance(new SqlServerStoreProvider("your connectionstring"));
