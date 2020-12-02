# aspnet-core-extensions

##  web api filter
```
[HttpGet]
public async Task<IActionResult> Get([FromQuery(Name = "$filter")] FilterModel<SomeViewModel> filter)
{
    var parameter = Expression.Parameter(typeof(SomeEntity), "x");
    if (filter?.Node != null)
    {
        var expr = filter.Node.ToExpression(parameter);
        var lambda = Expression.Lambda<Func<SomeEntity, bool>>(expr, parameter);

        var list = await _dbContext.SomeEntity.Where(lambda).ToListAsync();
        ...
    }
    ...
}
```
> 简单实现该指南 [https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#97-filtering](https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#97-filtering)
