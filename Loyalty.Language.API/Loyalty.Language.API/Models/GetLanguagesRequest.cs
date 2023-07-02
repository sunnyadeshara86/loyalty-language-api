namespace Loyalty.Language.API.Models
{
	public class GetLanguagesRequest
	{
        public string LocaleCode { get; set; }
        public int Page { get; set; }
        public int ItemsOnPage { get; set; }
        public string OrderBy { get; set; }
		public string OrderByDirection { get; set; }
	}
}
