# Cin7 Api Wrapper

A Wrapper for the [Cin7 API](https://api.cin7.com/api).

## Endpoints

The following endpoints are supported.

* Adjustments - Find
* BOM Masters - Find
* Branches - Create, Update and Find
* Branch Transfers  - Find
* Contacts - Create, Update and Find
* Credit Notes - Find
* Product Categories - Find
* Production Jobs - Create, Update and Find
* Product Options - Find
* Products - Find
* Purchase Orders - Create, Update and Find
* Quotes - Create, Update and Find
* Sales Orders - Create, Update and Find
* Serial Numbers - Find
* Stock - Find
* Users - Find
* Vouchers - Find 

## Installation
Download directly into Visual Studio using the NuGet command **PM&gt; Install-Package Cin7ApiWrapper** 

## Examples
### Find a Sales Order
```csharp
var api = new Cin7Api(new ApiUser("{API_USERNAME}", "{API_KEY}"));

SalesOrder sale = api.SalesOrders.Find(78);
```

### Find a List of Sales Orders
```csharp
void Main()
{
	var api = new Cin7Api(new ApiUser("{API_USERNAME}", "{API_KEY}"));

	int page = 1;
	var list = new List<SalesOrderDTO>();

	while (true)
	{
		var items = api.SalesOrders.Find<SalesOrderDTO>(
						page, 
						modifiedSince: DateTime.UtcNow.Date.AddDays(-7)
						);

		if (items.Count() == 0)
		{
			break;
		}

		list.AddRange(items);
		page++;
	}

	Console.WriteLine(list);
}

public class SalesOrderDTO
{
	public int Id { get; set; }
	public DateTime? InvoiceDate { get; set; }
	public string InvoiceNumber { get; set; }
	public IEnumerable<SalesOrderLineDTO> LineItems { get; set; }
}
public class SalesOrderLineDTO
{
	public string Name { get; set; }
	public string Code { get; set; }
	public decimal UnitPrice { get; set; }
}
```

### Create a Sales Order
```csharp
var api = new Cin7Api(new ApiUser("{API_USERNAME}", "{API_KEY}"));

var sale = new SalesOrder()
{
	MemberId = 77,
	TaxStatus = TaxStatus.Incl,
	TaxRate = 15,
	LineItems = new List<SalesOrderLineitem>() {
			new SalesOrderLineitem(){ Code = " 123", Qty = 1, UnitPrice = 10.5m }
		}
};

CreateResult result = api.SalesOrders.Create(sale);
```

### Create a List of Sales Orders
```csharp
var api = new Cin7Api(new ApiUser("{API_USERNAME}", "{API_KEY}"));

var batch = new List<SalesOrder>()
{
	new SalesOrder()
	{
		MemberId = 1,
		TaxStatus = TaxStatus.Incl,
		TaxRate = 15,
		LineItems = new List<SalesOrderLineitem>() {
			new SalesOrderLineitem(){ Code = " 123", Qty = 1, UnitPrice = 10.5m }
		}
	},
	new SalesOrder()
	{
		MemberId = 1,
		TaxStatus = TaxStatus.Incl,
		TaxRate = 15,
		LineItems = new List<SalesOrderLineitem>() {
			new SalesOrderLineitem(){ Code = " abc", Qty = 2, UnitPrice = 1.5m }
		}
	}
};

CreateBatchResult result = api.SalesOrders.Create(batch);
```

### Update a Sales Order
```csharp
var api = new Cin7Api(new ApiUser("{API_USERNAME}", "{API_KEY}"));

var sale = new SalesOrder()
{
	Id = 100,
	DispatchedDate = DateTime.UtcNow
};

UpdateResult result = api.SalesOrders.Update(sale);
```

### Update a List of Sales Orders
```csharp
var api = new Cin7Api(new ApiUser("{API_USERNAME}", "{API_KEY}"));

IEnumerable<SalesOrder> list = api.SalesOrders.Find(where: "InternalComments <> 'Test'");

foreach (var sale in list)
{
	sale.InternalComments = "Test";
}

UpdateBatchResult result = api.SalesOrders.Update(list);
```

## License

This software is published under the [MIT License](http://en.wikipedia.org/wiki/MIT_License).

MIT License

Copyright (c) 2019 JNTHND

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
