using PustokDb2022.Models;

namespace PustokDb2022.ViewModels
{
    public class ShopViewModel
    {
        public PaginationList<Book> Books { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Author> Authors { get; set; }
        public List<Tag> Tags { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }

    }
}
