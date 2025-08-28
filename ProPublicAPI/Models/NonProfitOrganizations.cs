using Newtonsoft.Json;

namespace ProPublicAPI.Models
{
    public class Organization
    {
        [JsonProperty("ein")]
        public int? Ein { get; set; }

        [JsonProperty("strein")]
        public string? Strein { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("sub_name")]
        public string? SubName { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("ntee_code")]
        public string? NteeCode { get; set; }

        [JsonProperty("raw_ntee_code")]
        public string? RawNteeCode { get; set; }

        [JsonProperty("subseccd")]
        public int? Subseccd { get; set; }

        [JsonProperty("has_subseccd")]
        public bool? HasSubseccd { get; set; }

        [JsonProperty("have_filings")]
        public object? HaveFilings { get; set; }

        [JsonProperty("have_extracts")]
        public object? HaveExtracts { get; set; }

        [JsonProperty("have_pdfs")]
        public object? HavePdfs { get; set; }

        [JsonProperty("score")]
        public double? Score { get; set; }
    }

    public class NonProfitOrganizations
    {
        [JsonProperty("total_results")]
        public int? TotalResults { get; set; }

        [JsonProperty("organizations")]
        public List<Organization>? Organizations { get; set; }

        [JsonProperty("num_pages")]
        public int? NumPages { get; set; }

        [JsonProperty("cur_page")]
        public int? CurPage { get; set; }

        [JsonProperty("page_offset")]
        public int? PageOffset { get; set; }

        [JsonProperty("per_page")]
        public int? PerPage { get; set; }

        [JsonProperty("search_query")]
        public string? SearchQuery { get; set; }

        [JsonProperty("selected_state")]
        public object? SelectedState { get; set; }

        [JsonProperty("selected_ntee")]
        public object? SelectedNtee { get; set; }

        [JsonProperty("selected_code")]
        public object? SelectedCode { get; set; }

        [JsonProperty("data_source")]
        public string? DataSource { get; set; }

        [JsonProperty("api_version")]
        public int? ApiVersion { get; set; }
    }
}
