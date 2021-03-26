namespace api.Models
{
    public class ApiReponse<T>
    {
        public bool Status { get; set; }
        public int Code { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}