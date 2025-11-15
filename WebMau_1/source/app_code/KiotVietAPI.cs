using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

public class KiotAPIClient
{
	private readonly HttpClient _httpClient;
	private readonly IDataService Db = DataServiceFactory.GetDbService();

	public KiotAPIClient(string url, string token)
	{
		_httpClient = new HttpClient() { BaseAddress = new Uri(url) };

		_httpClient.DefaultRequestHeaders.Add("retailer", "nestmart");
		_httpClient.DefaultRequestHeaders.Add("publicapikey", "F625634318E4F75291ED3441C030EEA5DC949C4D");
		_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
		_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
	}

	public KiotAPIClient() { }

	public string GetAccessToken()
	{
		var currentToken = Db.Table<pp_Kiot_AccessToken>().FirstOrDefault();
		var token = "";

		if (currentToken != null && (DateTime.Now - currentToken.CreatedTime).TotalHours < 24)
		{
			token = currentToken.Token;
		}
		else
		{
			using (var client = new HttpClient())
			{
				var body = new FormUrlEncodedContent(new[]
				{
					new KeyValuePair<string, string>("scopes", "PublicApi.Access"),
					new KeyValuePair<string, string>("grant_type", "client_credentials"),
					new KeyValuePair<string, string>("client_id", "3df7520e-5061-44aa-ad70-dfec26e86992"),
					new KeyValuePair<string, string>("client_secret", "F625634318E4F75291ED3441C030EEA5DC949C4D"),
					new KeyValuePair<string, string>("retailer", "nestmart")
				});

				var response = client.PostAsync("https://id.kiotviet.vn/connect/token", body).GetAwaiter().GetResult();
				string result = response.Content.ReadAsStringAsync().Result;

				dynamic resData = JsonConvert.DeserializeObject<dynamic>(result);

				if (!response.IsSuccessStatusCode)
					throw new Exception($"Lỗi lấy token: {response.StatusCode} - {result}");

				token = resData.access_token;

				if (currentToken == null)
				{
					currentToken = new pp_Kiot_AccessToken
					{
						Token = token,
						CreatedTime = DateTime.Now
					};
					Db.Insert(currentToken);
				}
				else
				{
					currentToken.Token = token;
					currentToken.CreatedTime = DateTime.Now;
					Db.Update(currentToken);
				}
			}
		}

		return token;
	}

	public KiotProduct GetProducts(int pagesize, string orderBy, int catId, int currentItem)
	{
		var param = $"products?orderBy={orderBy}&pagesize={pagesize}&categoryId={catId}&currentItem={currentItem}";
		var response = _httpClient.GetAsync(param).GetAwaiter().GetResult();
		var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

		json = json.TrimStart('\uFEFF').TrimStart();

		if (!response.IsSuccessStatusCode)
			throw new HttpRequestException($"API lỗi {(int)response.StatusCode}: {response.ReasonPhrase}\n{json}");

		var result = JsonConvert.DeserializeObject<KiotProduct>(json);
		return result;
	}

	public KiotCategory GetCategories(int pagesize)
	{
		var param = $"categories?pagesize={pagesize}";
		var response = _httpClient.GetAsync(param).GetAwaiter().GetResult();
		var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

		json = json.TrimStart('\uFEFF').TrimStart();

		if (!response.IsSuccessStatusCode)
			throw new HttpRequestException($"API lỗi {(int)response.StatusCode}: {response.ReasonPhrase}\n{json}");

		var result = JsonConvert.DeserializeObject<KiotCategory>(json);
		return result;
	}
}
