using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;

public class KiotAPIClient
{
	private readonly HttpClient _httpClient;

	public class KiotProduct
	{
		public int Total { get; set; }
		public int PageSize { get; set; }
		public List<VM_Product> Data { get; set; }
	}


	public KiotAPIClient(string url, string retailer, string key, string token)
	{
		_httpClient = new HttpClient() { BaseAddress = new Uri(url) };

		_httpClient.DefaultRequestHeaders.Add("retailer", retailer);
		_httpClient.DefaultRequestHeaders.Add("publicapikey", key);
		_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
		_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
	}

	public KiotProduct GetProducts(int pagesize, string orderBy)
	{
		var param = $"products?orderBy={orderBy}&pagesize={pagesize}";
		var response = _httpClient.GetAsync(param).GetAwaiter().GetResult(); 
		var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

		json = json.TrimStart('\uFEFF').TrimStart();

		if (!response.IsSuccessStatusCode)
			throw new HttpRequestException($"API lỗi {(int)response.StatusCode}: {response.ReasonPhrase}\n{json}");

		var result = JsonConvert.DeserializeObject<KiotProduct>(json);
		return result;
	}
}
